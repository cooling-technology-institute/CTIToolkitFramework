// Copyright Cooling Technology Institute 2019-2020

using CalculationLibrary;
using Models;
using System;

namespace ViewModels
{
    public class MerkelViewModel
    {
        public MerkelInputData MerkelInputData { get; set; }
        public MerkelOutputData MerkelOutputData { get; set; }
        public MerkelData MerkelData { get; set; }
        public MerkelCalculationLibrary MerkelCalculationLibrary { get; set; }
        
        public MerkelViewModel(bool isDemo, bool isInternationalSystemOfUnits_IS_)
        {
            MerkelInputData = new MerkelInputData(isDemo, isInternationalSystemOfUnits_IS_);
            MerkelOutputData = new MerkelOutputData(isInternationalSystemOfUnits_IS_);
        }
        
        public bool CalculateMerkel(bool isElevation, out string errorMessage)
        {
            try
            {
                MerkelData = new MerkelData();

                //MerkelData.IsElevation = isElevation;
                MerkelData.HotWaterTemperature = MerkelInputData.HotWaterTemperatureDataValue.Current;
                MerkelData.ColdWaterTemperature = MerkelInputData.ColdWaterTemperatureDataValue.Current;
                MerkelData.WetBulbTemperature = MerkelInputData.WetBulbTemperatureDataValue.Current;
                MerkelData.LiquidtoGasRatio = MerkelInputData.LiquidtoGasRatioDataValue.Current;

                if(!MerkelCalculationLibrary.MerkelCalculation(MerkelData, out errorMessage))
                {
                    return false;
                }

                // output data in MerkelOutputData
                MerkelOutputData.NameValueUnitsDataTable.DataTable.Clear();

                //data.BarometricPressure = truncit(data.BarometricPressure, 5);
                MerkelOutputData.NameValueUnitsDataTable.AddRow("KaV/L", MerkelData.KaV_L.ToString("F5"), string.Empty);

                return true;
            }
            catch (Exception exception)
            {
                errorMessage = string.Format("Error in Merkel calculation. Please check your input values. Exception Message: {0}", exception.Message);
                return false;
            }
        }
    }
}
