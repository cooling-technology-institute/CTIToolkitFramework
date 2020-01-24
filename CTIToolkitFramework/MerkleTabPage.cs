// Copyright Cooling Technology Institute 2019-2020

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CalculationLibrary;
using Models;
using ViewModels;

namespace CTIToolkit
{
    public partial class MerkelTabPage: UserControl
    {
        const int ELEVATION = 0;
        const int PRESSURE = 1;

        private MerkelViewModel MerkelViewModel { get; set; }
        private MerkelData MerkelData { get; set; }
        private MerkelCalculationLibrary MerkelCalculationLibrary { get; set; }
        private bool IsDemo { get; set; }
        private bool IsInternationalSystemOfUnits_IS_ { get; set; }

        public MerkelTabPage(ApplicationSettings applicationSettings)
        {
            InitializeComponent();

            IsInternationalSystemOfUnits_IS_ = (applicationSettings.UnitsSelection == UnitsSelection.International_System_Of_Units_SI);

            MerkelViewModel = new MerkelViewModel(IsDemo, IsInternationalSystemOfUnits_IS_);
            MerkelCalculationLibrary = new MerkelCalculationLibrary();

            Setup();

            CalculateMerkel();

        }

        private void Setup()
        {
            TemperatureHotWaterLabel.Text = MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.InputMessage + ":";
            TemperatureHotWaterLabel.TextAlign = ContentAlignment.MiddleRight;
            Merkel_HotWaterTemperature_Value.Text = MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.InputValue;
            toolTip1.SetToolTip(Merkel_HotWaterTemperature_Value, MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.ToolTip);

            TemperatureColdWaterLabel.Text = MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.InputMessage + ":";
            TemperatureColdWaterLabel.TextAlign = ContentAlignment.MiddleRight;
            Merkel_ColdWaterTemperature_Value.Text = MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.InputValue;
            toolTip1.SetToolTip(Merkel_ColdWaterTemperature_Value, MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.ToolTip);

            MerkelWetBulbTemperatureLabel.Text = MerkelViewModel.MerkelInputData.WetBulbTemperatureDataValue.InputMessage + ":";
            MerkelWetBulbTemperatureLabel.TextAlign = ContentAlignment.MiddleRight;
            Merkel_WetBulbTemperature_Value.Text = MerkelViewModel.MerkelInputData.WetBulbTemperatureDataValue.InputValue;
            toolTip1.SetToolTip(Merkel_WetBulbTemperature_Value, MerkelViewModel.MerkelInputData.WetBulbTemperatureDataValue.ToolTip);

            Merkel_LiquidtoGasRatio_Value.Text = MerkelViewModel.MerkelInputData.LiquidtoGasRatioDataValue.InputValue;
            toolTip1.SetToolTip(Merkel_LiquidtoGasRatio_Value, MerkelViewModel.MerkelInputData.LiquidtoGasRatioDataValue.ToolTip);

            Merkle_Elevation_Pressure_Selector.SelectedIndex = ELEVATION;
        }

        public void SetUnitsStandard(ApplicationSettings applicationSettings)
        {
            IsInternationalSystemOfUnits_IS_ = (applicationSettings.UnitsSelection == UnitsSelection.International_System_Of_Units_SI);
            SwitchUnitedStatesCustomaryUnits_IP_InternationalSystemOfUnits_IS_();
        }

        private void SwitchUnitedStatesCustomaryUnits_IP_InternationalSystemOfUnits_IS_()
        {
            if (MerkelViewModel.ConvertValues(IsInternationalSystemOfUnits_IS_, (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)))
            {
                SwitchCalculation();
            }

            if (IsInternationalSystemOfUnits_IS_)
            {
                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Meter;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureKiloPascal;
                }
            }
            else
            {
                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Foot;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureInchOfMercury;
                }
            }
        }

        private void SwitchElevationPressure()
        {
            //string message;

            if (MerkelViewModel.ConvertValues(IsInternationalSystemOfUnits_IS_, (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)))
            {
                SwitchCalculation();
            }

            if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
            {
                //double value = 0.0;
                //if (double.TryParse(Merkel_Elevation_Value.Text, out value))
                //{
                //    if (IsInternationalSystemOfUnits_IS_)
                //    {
                //        value = UnitConverter.ConvertKilopascalToElevationInMeters(value);
                //    }
                //    else
                //    {
                //        value = UnitConverter.ConvertBarometricPressureToElevationInFeet(value);
                //    }
                //}
                //else
                //{
                //    value = MerkelInputData.ElevationDataValue.Default;
                //}
                //MerkelInputData.BarometricPressureDataValue.UpdateValue(value.ToString(), out message);
                //Merkel_Elevation_Value.Text = MerkelInputData.ElevationDataValue.InputValue;
                //MerkelElevationPressureLabel.Text = MerkelInputData.ElevationDataValue.InputMessage + ":";
                if (IsInternationalSystemOfUnits_IS_)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Meter;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Foot;
                }
            }
            else
            {
                //double value = 0.0;
                //if (double.TryParse(Merkel_Elevation_Value.Text, out value))
                //{
                //   if (IsInternationalSystemOfUnits_IS_)
                //    {
                //        value = UnitConverter.ConvertElevationInMetersToKilopascal(value);
                //    }
                //    else
                //    {
                //        value = UnitConverter.CalculatePressureFahrenheit(UnitConverter.ConvertElevationInFeetToBarometricPressure(value));
                //    }
                //}
                //else
                //{
                //    value = MerkelInputData.BarometricPressureDataValue.Default;
                //}
                //MerkelInputData.BarometricPressureDataValue.UpdateValue(value.ToString(), out message);
                //Merkel_Elevation_Value.Text = MerkelInputData.BarometricPressureDataValue.InputValue;
                //MerkelElevationPressureLabel.Text = MerkelInputData.BarometricPressureDataValue.InputMessage + ":";
                if (IsInternationalSystemOfUnits_IS_)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureKiloPascal;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureInchOfMercury;
                }
            }
        }

        private void SwitchCalculation()
        {
            string tooltip = string.Empty;


            if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
            {
                Merkel_Elevation_Value.Text = MerkelViewModel.ElevationDataValue.InputValue;
                if (IsInternationalSystemOfUnits_IS_)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Meter;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.Foot;
                }
            }
            else
            {
                Merkel_Elevation_Value.Text = MerkelViewModel.BarometricPressureDataValue.InputValue;
                if (IsInternationalSystemOfUnits_IS_)
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureKiloPascal;
                }
                else
                {
                    MerkelElevationPressureUnits.Text = ConstantUnits.BarometricPressureInchOfMercury;
                }
            }

            if (IsInternationalSystemOfUnits_IS_)
            {
                MerkelTemperatureHotWaterUnits.Text = ConstantUnits.TemperatureCelsius;
                MerkelTemperatureColdWaterUnits.Text = ConstantUnits.TemperatureCelsius;
                MerkelWebBulbTemperatureUnits.Text = ConstantUnits.TemperatureCelsius;
            }
            else
            {
                MerkelTemperatureHotWaterUnits.Text = ConstantUnits.TemperatureFahrenheit;
                MerkelTemperatureColdWaterUnits.Text = ConstantUnits.TemperatureFahrenheit;
                MerkelWebBulbTemperatureUnits.Text = ConstantUnits.TemperatureFahrenheit;
            }
        }

        private void CalculateMerkel()
        {
            try
            {
                string errorMessage = string.Empty;

                if(MerkelViewModel.CalculateMerkel((Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION), errorMessage))
                {

                }


                // clear data set
                if (MerkelGridView.DataSource != null)
                {
                    MerkelGridView.DataSource = null;
                }

                DataTable table = null;

                string message = string.Empty;

                if(!MerkelViewModel.MerkelInputData.FillData(MerkelData, (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION), IsInternationalSystemOfUnits_IS_, out message))
                {
                    MessageBox.Show(message);
                    return;
                }

                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    if (!MerkelViewModel.MerkelInputData.ElevationDataValue.UpdateValue(Merkel_Elevation_Value.Text, out message))
                    {
                    }
                }
                else
                {
                    if (!MerkelViewModel.MerkelInputData.BarometricPressureDataValue.UpdateValue(Merkel_Elevation_Value.Text, out message))
                    {
                        MessageBox.Show(message);
                        return;
                    }
                }

                if (MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.Current < MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.Current)
                {
                    MessageBox.Show("The Hot Water Temperature value must be greater than the Cold Water Temperature value");
                    return;
                }

                if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
                {
                    MerkelData.Elevation = MerkelViewModel.MerkelInputData.ElevationDataValue.Current;
                }
                else
                {
                    MerkelData.BarometricPressure = MerkelViewModel.MerkelInputData.BarometricPressureDataValue.Current;
                }

                //MerkelData.IsElevation = (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION);

                MerkelData.HotWaterTemperature = MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.Current;
                MerkelData.ColdWaterTemperature = MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.Current;
                MerkelData.WetBulbTemperature = MerkelViewModel.MerkelInputData.WetBulbTemperatureDataValue.Current;
                MerkelData.LiquidtoGasRatio = MerkelViewModel.MerkelInputData.LiquidtoGasRatioDataValue.Current;

                if (MerkelViewModel.MerkelOutputData.NameValueUnitsDataTable.DataTable != null)
                {
                    // Set a DataGrid control's DataSource to the DataView.
                    MerkelGridView.DataSource = new DataView(MerkelViewModel.MerkelOutputData.NameValueUnitsDataTable.DataTable);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Error in Merkel calculation. Please check your input values. Exception Message: {0}", exception.Message), "Merkel Calculation Error");
            }
        }

        private void MerkelCalculate_Click(object sender, EventArgs e)
        {
            CalculateMerkel();
        }

        private void Merkle_Elevation_Pressure_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchElevationPressure();
            CalculateMerkel();
        }

        private void Merkel_ColdWaterTemperature_Value_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if(!MerkelViewModel.MerkelInputData.ColdWaterTemperatureDataValue.UpdateValue(Merkel_ColdWaterTemperature_Value.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage);

            }
        }

        private void Merkel_HotWaterTemperature_Value_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (!MerkelViewModel.MerkelInputData.HotWaterTemperatureDataValue.UpdateValue(Merkel_HotWaterTemperature_Value.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void Merkel_WetBulbTemperature_Value_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (!MerkelViewModel.MerkelInputData.WetBulbTemperatureDataValue.UpdateValue(Merkel_WetBulbTemperature_Value.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage);
            }

        }

        private void Merkel_Elevation_Value_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (Merkle_Elevation_Pressure_Selector.SelectedIndex == ELEVATION)
            {
                if (!MerkelViewModel.MerkelInputData.ElevationDataValue.UpdateValue(Merkel_Elevation_Value.Text, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                if (!MerkelViewModel.MerkelInputData.BarometricPressureDataValue.UpdateValue(Merkel_Elevation_Value.Text, out errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void Merkel_LiquidtoGasRatio_Value_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;

            if (!MerkelViewModel.MerkelInputData.LiquidtoGasRatioDataValue.UpdateValue(Merkel_LiquidtoGasRatio_Value.Text, out errorMessage))
            {
                MessageBox.Show(errorMessage);
            }

        }
    }
}
