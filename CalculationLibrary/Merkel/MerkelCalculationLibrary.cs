﻿// Copyright Cooling Technology Institute 2019-2020

using Models;

namespace CalculationLibrary
{
    public class MerkelCalculationLibrary
    {
        public string MerkelCalculation(MerkelData data)
        {
            data.Range = data.HotWaterTemperature - data.ColdWaterTemperature;
            data.Approach = data.ColdWaterTemperature - data.WetBulbTemperature;

            CalculationLibrary.CalculateMerkel(data);

            return Merkel_CheckCalculationValues(data);
        }

        public void MerkelConvertValues(bool isInternationalSystemOfUnits_IS_, bool isElevation, MerkelData data)
        {
            if (isInternationalSystemOfUnits_IS_)
            {
                //    WBT = fnCelcToFar(WBT);
                //    T1 = fnCelcToFar(T1);
                //    T2 = fnCelcToFar(T2);
                data.WetBulbTemperature = UnitConverter.ConvertCelsiusToFahrenheit(data.WetBulbTemperature);
                data.ColdWaterTemperature = UnitConverter.ConvertCelsiusToFahrenheit(data.ColdWaterTemperature);
                data.HotWaterTemperature = UnitConverter.ConvertCelsiusToFahrenheit(data.HotWaterTemperature);

                if (!isElevation)
                {
                    data.Elevation = UnitConverter.ConvertMetersToFeet(UnitConverter.ConvertKilopascalToElevationInMeters(data.BarometricPressure));
                }
            }
            else
            {
                if (!isElevation)
                {
                    data.Elevation = UnitConverter.ConvertBarometricPressureToElevationInFeet(UnitConverter.CalculatePressureCelcius(data.BarometricPressure));
                }
            }
        }

        public string Merkel_CheckCalculationValues(MerkelData data)
        {
            return string.Empty;
        }
    }
}