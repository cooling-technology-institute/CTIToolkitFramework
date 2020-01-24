// Copyright Cooling Technology Institute 2019-2020

using CalculationLibrary;
using Models;

namespace ViewModels
{
    public class MerkelViewModel
    {
        public MerkelInputData MerkelInputData { get; set; }
        public MerkelOutputData MerkelOutputData { get; set; }
        public MerkelCalculationLibrary MerkelCalculationLibrary { get; set; }
        
        public MerkelViewModel(bool isDemo, bool isInternationalSystemOfUnits_IS_)
        {
            MerkelInputData = new MerkelInputData(isDemo, isInternationalSystemOfUnits_IS_);

        }
        
        public void CalculateMerkel()
        {
            try
            {
                MerkelData = new MerkelData();

                // clear data set
                if (MerkelGridView.DataSource != null)
                {
                    MerkelGridView.DataSource = null;
                }

                DataTable table = null;

                string message = string.Empty;

                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    if (!MerkelInputData.ElevationDataValue.UpdateValue(Merkel_Elevation_Value.Text, out message))
                    {
                        MessageBox.Show(message);
                        return;
                    }
                }
                else
                {
                    if (!MerkelInputData.BarometricPressureDataValue.UpdateValue(Merkel_Elevation_Value.Text, out message))
                    {
                        MessageBox.Show(message);
                        return;
                    }
                }

                if (!MerkelInputData.ColdWaterTemperatureDataValue.UpdateValue(Merkel_CWT_Value.Text, out message))
                {
                    MessageBox.Show(message);
                    return;
                }

                if (!MerkelInputData.HotWaterTemperatureDataValue.UpdateValue(Merkel_HWT_Value.Text, out message))
                {
                    MessageBox.Show(message);
                    return;
                }

                if (!MerkelInputData.WetBulbTemperatureDataValue.UpdateValue(Merkel_Wet_Bulb_Value.Text, out message))
                {
                    MessageBox.Show(message);
                    return;
                }

                if (!MerkelInputData.WaterAirFlowRateDataValue.UpdateValue(Merkel_LG_Value.Text, out message))
                {
                    MessageBox.Show(message);
                    return;
                }

                if (MerkelInputData.HotWaterTemperatureDataValue.Current < MerkelInputData.ColdWaterTemperatureDataValue.Current)
                {
                    MessageBox.Show("The Hot Water Temperature value must be greater than the Cold Water Temperature value");
                    return;
                }

                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    MerkelData.Elevation = MerkelInputData.ElevationDataValue.Current;
                }
                else
                {
                    MerkelData.BarometricPressure = MerkelInputData.BarometricPressureDataValue.Current;
                }

                //MerkelData.IsElevation = (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION);

                MerkelData.HotWaterTemperature = MerkelInputData.HotWaterTemperatureDataValue.Current;
                MerkelData.ColdWaterTemperature = MerkelInputData.ColdWaterTemperatureDataValue.Current;
                MerkelData.WetBulbTemperature = MerkelInputData.WetBulbTemperatureDataValue.Current;
                MerkelData.WaterAirRatio = MerkelInputData.WaterAirFlowRateDataValue.Current;

                table = new MerkelCalculationLibrary().MerkelCalculation(MerkelData);

                if (table != null)
                {
                    // Create a DataView using the DataTable.
                    DataView view = new DataView(table);

                    // Set a DataGrid control's DataSource to the DataView.
                    MerkelGridView.DataSource = view;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Error in Merkel calculation. Please check your input values. Exception Message: {0}", exception.Message), "Merkel Calculation Error");
            }
        }
    }
}
