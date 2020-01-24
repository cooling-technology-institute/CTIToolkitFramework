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
    public partial class PsychrometricsTabPage: UserControl
    {
        PsychrometricsViewModel PsychrometricsViewModel { get; set; }
        private bool IsDemo { get; set; }
        private bool IsInternationalSystemOfUnits_IS_ { get; set; }

        public PsychrometricsTabPage(ApplicationSettings applicationSettings)
        {
            InitializeComponent();

            IsInternationalSystemOfUnits_IS_ = (applicationSettings.UnitsSelection == UnitsSelection.International_System_Of_Units_SI);
            IsInternationalSystemOfUnits_IS_ = false;

            IsDemo = applicationSettings.IsDemo;
            IsInternationalSystemOfUnits_IS_ = false;

            PsychrometricsViewModel = new PsychrometricsViewModel(IsDemo, IsInternationalSystemOfUnits_IS_);

            SwitchCalculation();

            PsychrometricsViewModel.CalculatePsychrometrics();

        }

        public void SetUnitsStandard(ApplicationSettings applicationSettings)
        {
            IsInternationalSystemOfUnits_IS_ = (applicationSettings.UnitsSelection == UnitsSelection.International_System_Of_Units_SI);
            SwitchUnitsSelection();
        }

        private void SwitchUnitsSelection()
        {
            if (PsychrometricsViewModel.ConvertValues(IsInternationalSystemOfUnits_IS_))
            {
                SwitchCalculation();
            }

            if (IsInternationalSystemOfUnits_IS_)
            {
                if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.Percentage;
                }
                else
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.TemperatureCelsius;
                }

                if (Psychrometrics_Enthalpy.Checked)
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.KilojoulesPerKilogram;
                }
                else
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureCelsius;
                }

                if (PyschmetricsElevationRadio.Checked)
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.Meter;
                }
                else
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.BarometricPressureKiloPascal;
                }
            }
            else
            {
                if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.Percentage;
                }
                else
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.TemperatureFahrenheit;
                }

                if (Psychrometrics_Enthalpy.Checked)
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.BtuPerPound;
                }
                else
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureFahrenheit;
                }

                if (PyschmetricsElevationRadio.Checked)
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.Foot;
                }
                else
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.BarometricPressureInchOfMercury;
                }
            }
        }

        private void SwitchElevationPressure()
        {
            //PsychrometricsData.SetElevation(PyschmetricsElevationRadio.Checked);

            if (PyschmetricsElevationRadio.Checked)
            {
                double value = 0.0;
                if (double.TryParse(Psychrometrics_Elevation_Value.Text, out value))
                {
                    value = UnitConverter.ConvertBarometricPressureToElevationInFeet(value);
                }
                else
                {
                    value = PsychrometricsViewModel.PsychrometricsInputData.ElevationDataValue.Default;
                }
                Psychrometrics_Elevation_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.ElevationDataValue.InputValue;
                PsychrometricsElevationPressureLabel1.Text = PsychrometricsViewModel.PsychrometricsInputData.ElevationDataValue.InputMessage + ":";
                if (IsInternationalSystemOfUnits_IS_)
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.Meter;
                }
                else
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.Foot;
                }
            }
            else
            {
                double value = 0.0;
                if (double.TryParse(Psychrometrics_Elevation_Value.Text, out value))
                {
                    value = UnitConverter.ConvertElevationInFeetToBarometricPressure(value);
                    value = UnitConverter.CalculatePressureFahrenheit(value);

                }
                else
                {
                    value = PsychrometricsViewModel.PsychrometricsInputData.BarometricPressureDataValue.Default;
                }
                Psychrometrics_Elevation_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.BarometricPressureDataValue.InputValue;
                PsychrometricsElevationPressureLabel1.Text = PsychrometricsViewModel.PsychrometricsInputData.BarometricPressureDataValue.InputMessage + ":";
                if (IsInternationalSystemOfUnits_IS_)
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.BarometricPressureKiloPascal;
                }
                else
                {
                    PsychrometricsElevationPressureLabel2.Text = ConstantUnits.BarometricPressureInchOfMercury;
                }
            }
        }

        private void SwitchCalculation()
        {
            string tooltip = string.Empty;

            if (Psychrometrics_Enthalpy.Checked)
            {
                TemperatureWetBulbLabel.Visible = false;
                PsychrometricsTemperatureWetBulbUnits.Visible = false;
                Psychrometrics_WBT_Value.Visible = false;
            }
            else
            {
                TemperatureWetBulbLabel.Visible = true;
                PsychrometricsTemperatureWetBulbUnits.Visible = true;
                Psychrometrics_WBT_Value.Visible = true;
            }

            if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
            {
                TemperatureWetBulbLabel.Text = PsychrometricsViewModel.PsychrometricsInputData.RelativeHumidityDataValue.InputMessage + ":";
                TemperatureWetBulbLabel.TextAlign = ContentAlignment.MiddleRight;
                PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.Percentage;
                Psychrometrics_WBT_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.RelativeHumidityDataValue.InputValue;
                toolTip1.SetToolTip(Psychrometrics_WBT_Value, PsychrometricsViewModel.PsychrometricsInputData.RelativeHumidityDataValue.ToolTip);

                TemperatureDryBulbLabel.Text = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.InputMessage + ":";
                Psychrometrics_DBT_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.InputValue;
                toolTip1.SetToolTip(Psychrometrics_DBT_Value, PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.ToolTip);
                if (IsInternationalSystemOfUnits_IS_)
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureCelsius;
                }
                else
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureFahrenheit;
                }
            }
            else if (Psychrometrics_Enthalpy.Checked)
            {
                TemperatureDryBulbLabel.Text = PsychrometricsViewModel.PsychrometricsInputData.EnthalpyDataValue.InputMessage + ":";
                TemperatureDryBulbLabel.TextAlign = ContentAlignment.MiddleRight;
                toolTip1.SetToolTip(Psychrometrics_DBT_Value, PsychrometricsViewModel.PsychrometricsInputData.EnthalpyDataValue.ToolTip);

                if (IsInternationalSystemOfUnits_IS_)
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.KilojoulesPerKilogram;
                }
                else
                {
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.BtuPerPound;
                }
                Psychrometrics_DBT_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.EnthalpyDataValue.InputValue;
            }
            else
            {
                TemperatureWetBulbLabel.Text = PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.InputMessage + ":";
                TemperatureWetBulbLabel.TextAlign = ContentAlignment.MiddleRight;
                Psychrometrics_WBT_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.InputValue;
                toolTip1.SetToolTip(Psychrometrics_WBT_Value, PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.ToolTip);

                TemperatureDryBulbLabel.Text = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.InputMessage + ":";
                TemperatureDryBulbLabel.TextAlign = ContentAlignment.MiddleRight;
                Psychrometrics_DBT_Value.Text = PsychrometricsViewModel.PsychrometricsInputData.DryBulbTemperatureDataValue.InputValue;
                toolTip1.SetToolTip(Psychrometrics_WBT_Value, PsychrometricsViewModel.PsychrometricsInputData.WetBulbTemperatureDataValue.ToolTip);

                if (IsInternationalSystemOfUnits_IS_)
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.TemperatureCelsius;
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureCelsius;
                }
                else
                {
                    PsychrometricsTemperatureWetBulbUnits.Text = ConstantUnits.TemperatureFahrenheit;
                    PsychrometricsTemperatureDryBulbUnits.Text = ConstantUnits.TemperatureFahrenheit;
                }
            }
        }


        private void PyschmetricsElevationRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PyschmetricsElevationRadio.Checked)
            {
                SwitchElevationPressure();

                PsychrometricsViewModel.CalculatePsychrometrics();
            }
        }

        private void PyschmetricsPressureRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PyschmetricsPressureRadio.Checked)
            {
                SwitchElevationPressure();

                PsychrometricsViewModel.CalculatePsychrometrics();
            }
        }

        private void Psychrometrics_WetBulbTemperature_DryBulbTemperature_CheckedChanged(object sender, EventArgs e)
        {
            if (Psychrometrics_WetBulbTemperature_DryBulbTemperature.Checked)
            {
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

                PsychrometricsViewModel.PsychrometricsInputData.CalculationType = PsychrometricsCalculationType.Psychrometrics_WetBulbTemperature_DryBulbTemperature;

                SwitchCalculation();

                PsychrometricsViewModel.CalculatePsychrometrics();
            }

        }

        private void Psychrometrics_DryBulbTemperature_RelativeHumidity_CheckedChanged(object sender, EventArgs e)
        {
            if (Psychrometrics_DryBulbTemperature_RelativeHumidity.Checked)
            {
                PsychrometricsViewModel.UpdateCalculationType(PsychrometricsCalculationType.Psychrometrics_DryBulbTemperature_RelativeHumidity);

                SwitchCalculation();

                string errorMessage = PsychrometricsViewModel.CalculatePsychrometrics();

                if (string.IsNullOrEmpty(errorMessage))
                {
                    //convert data to table
                    // clear data set
                    if (Psychrometrics_GridView.DataSource != null)
                    {
                        Psychrometrics_GridView.DataSource = null;
                    }

                    // Create a DataView using the DataTable.
                    DataView view = new DataView(PsychrometricsViewModel.PsychrometricsOutputData.NameValueUnitsDataTable.DataTable);

                    // Set a DataGrid control's DataSource to the DataView.
                    Psychrometrics_GridView.DataSource = view;
                }
                else
                {
                    MessageBox.Show(errorMessage, "Psychrometrics Calculation Error");
                }
            }
        }

        private void Psychrometrics_Enthalpy_CheckedChanged(object sender, EventArgs e)
        {
            if (Psychrometrics_Enthalpy.Checked)
            {
                //    if (!PsychrometricsInputData.EnthalpyDataValue.UpdateValue(Psychrometrics_DBT_Value.Text, out message))
                //    {
                //        MessageBox.Show(message);
                //        return;
                //    }

                PsychrometricsViewModel.PsychrometricsInputData.CalculationType = PsychrometricsCalculationType.Psychrometrics_Enthalpy;

                SwitchCalculation();

                PsychrometricsViewModel.CalculatePsychrometrics();
            }
        }

        private void PsychrometricsCalculate_Click(object sender, EventArgs e)
        {
            PsychrometricsViewModel.CalculatePsychrometrics();
        }
    }
}
