// Copyright Cooling Technology Institute 2019-2020

using CalculationLibrary;
using Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace ViewModels
{
    public class PsychrometricsViewModel
    {
        public PsychrometricsInputData PsychrometricsInputData { get; set; }
        public PsychrometricsOutputData PsychrometricsOutputData { get; set; }
        private PsychrometricsData PsychrometricsData { get; set; }
        private PsychrometricsCalculationLibrary PsychrometricsCalculationLibrary { get; set; }
        private bool IsInternationalSystemOfUnits_IS_ { get; set; }
        private bool IsDemo { get; set; }
        public PsychrometricsCalculationType CalculationType { get; set; }

        public PsychrometricsViewModel(bool isDemo, bool isInternationalSystemOfUnits_IS_)
        {
            IsInternationalSystemOfUnits_IS_ = isInternationalSystemOfUnits_IS_;
            IsDemo = isDemo;
            PsychrometricsInputData = new PsychrometricsInputData(IsDemo, IsInternationalSystemOfUnits_IS_);
            PsychrometricsOutputData = new PsychrometricsOutputData(IsInternationalSystemOfUnits_IS_);
            PsychrometricsCalculationLibrary = new PsychrometricsCalculationLibrary();
            PsychrometricsData = new PsychrometricsData();
        }

        public bool ConvertValues(bool isInternationalSystemOfUnits_IS_)
        {
            if(IsInternationalSystemOfUnits_IS_ != isInternationalSystemOfUnits_IS_)
            {
                IsInternationalSystemOfUnits_IS_ = isInternationalSystemOfUnits_IS_;
                return PsychrometricsInputData.ConvertValues(IsInternationalSystemOfUnits_IS_);
            }
            return false;
        }

        public string CalculatePsychrometrics()
        {
            try
            {
                PsychrometricsData = new PsychrometricsData();
                PsychrometricsOutputData.ClearTable();

                // transfer data from input data to PsychrometricsData
                PsychrometricsInputData.FillData(PsychrometricsData);


                //DataTable table = null;

                //string message = string.Empty;

                //if (PyschmetricsElevationRadio.Checked)
                //{
                //    if (!PsychrometricsInputData.ElevationDataValue.UpdateValue(Psychrometrics_Elevation_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //}
                //else
                //{
                //    if (!PsychrometricsInputData.BarometricPressureDataValue.UpdateValue(Psychrometrics_Elevation_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //}

                //if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
                //{
                //    if (!PsychrometricsInputData.DryBulbTemperatureDataValue.UpdateValue(Psychrometrics_DBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //    if (!PsychrometricsInputData.RelativeHumitityDataValue.UpdateValue(Psychrometrics_WBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //}
                //else if (Psychrometrics_Enthalpy.Checked)
                //{
                //    if (!PsychrometricsInputData.EnthalpyDataValue.UpdateValue(Psychrometrics_DBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //}
                //else
                //{
                //    if (!PsychrometricsInputData.DryBulbTemperatureDataValue.UpdateValue(Psychrometrics_DBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //    if (!PsychrometricsInputData.WetBulbTemperatureDataValue.UpdateValue(Psychrometrics_WBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }
                //    if (PsychrometricsInputData.DryBulbTemperatureDataValue.Current < PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.Current)
                //    {
                //        MessageBox.Show("The Dry Bulb Temperature value must be greater than the Wet Bulb Temperature value");
                //        return;
                //    }
                //}

                //if (PyschmetricsElevationRadio.Checked)
                //{
                //    PsychrometricsData.Elevation = PsychrometricsViewModel.PsychrometricsInputData.ElevationDataValue.Current;
                //}
                //else
                //{
                //    PsychrometricsData.BarometricPressure = PsychrometricsViewModel.PsychrometricsInputData.BarometricPressureDataValue.Current;
                //}

                //PsychrometricsData.IsElevation = PyschmetricsElevationRadio.Checked;
                //PsychrometricsData.SetInternationalSystemOfUnits_IS_(IsInternationalSystemOfUnits_IS_);

                //if (Psychrometrics_WetBulbTemperature_DryBulbTemperature.Checked)
                //{
                //    PsychrometricsData.CalculationType = PsychrometricsCalculationType.Psychrometrics_WetBulbTemperature_DryBulbTemperature;
                //    PsychrometricsViewModel.PsychrometricsInputData.CalculationType = PsychrometricsCalculationType.Psychrometrics_WetBulbTemperature_DryBulbTemperature;
                //    PsychrometricsData.TemperatureDryBulb = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.Current;
                //    PsychrometricsData.TemperatureWetBulb = PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.Current;
                //}
                //else if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
                //{
                //    PsychrometricsData.CalculationType = PsychrometricsCalculationType.Psychrometrics_DryBulbTemperature_RelativeHumidity;
                //    PsychrometricsViewModel.PsychrometricsInputData.CalculationType = PsychrometricsCalculationType.Psychrometrics_DryBulbTemperature_RelativeHumidity;
                //    PsychrometricsData.RelativeHumidity = PsychrometricsViewModel.PsychrometricsInputData.RelativeHumitityDataValue.Current;
                //    PsychrometricsData.TemperatureDryBulb = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.Current;
                //}
                //else if (Psychrometrics_Enthalpy.Checked)
                //{
                //    PsychrometricsData.CalculationType = PsychrometricsCalculationType.Psychrometrics_Enthalpy;
                //    PsychrometricsViewModel.PsychrometricsInputData.CalculationType = PsychrometricsCalculationType.Psychrometrics_Enthalpy;
                //    PsychrometricsData.Enthalpy = PsychrometricsViewModel.PsychrometricsInputData.EnthalpyDataValue.Current;
                //}

                string errorMessage = PsychrometricsCalculationLibrary.PsychrometricsCalculation(PsychrometricsData);

                if (string.IsNullOrEmpty(errorMessage))
                {
                    //convert data to table
                    PsychrometricsOutputData.FillTable(PsychrometricsData);
                }
                return errorMessage;
            }
            catch (Exception exception)
            {
                return string.Format("Error in Psychrometrics calculation. Please check your input values. Exception Message: {0}", exception.Message);
            }
        }
        
        public string UpdateCalculationType(PsychrometricsCalculationType psychrometricsCalculationType)
        {
            string errorMessage = string.Empty;
            switch(psychrometricsCalculationType)
            {
                case PsychrometricsCalculationType.Psychrometrics_DryBulbTemperature_RelativeHumidity:
                    if (!PsychrometricsInputData.DryBulbTemperatureDataValue.UpdateValue(Psychrometrics_DBT_Value.Text, out errorMessage))
                    //    {
                    //        MessageBox.Show(message);
                    //        return;
                    //    }
                    if (!PsychrometricsInputData.RelativeHumitityDataValue.UpdateValue(Psychrometrics_WBT_Value.Text, out errorMessage))
                    //    {
                    //        MessageBox.Show(message);
                    //        return;
                    //    }
                    break;
                case PsychrometricsCalculationType.Psychrometrics_Enthalpy:

                    break;
                case PsychrometricsCalculationType.Psychrometrics_WetBulbTemperature_DryBulbTemperature:
                    break;

            }

            return errorMessage;
        }
    }
}
