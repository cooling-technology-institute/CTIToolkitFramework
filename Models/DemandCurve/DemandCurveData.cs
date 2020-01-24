﻿// Copyright Cooling Technology Institute 2019-2020

using System.Data;

namespace Models
{
    public class DemandCurveData
    {
        public DataTable DataTable { get; set; }

        public double CurveC1 { set; get; }
        public double CurveC2 { set; get; }
        public double WaterAirRatio { set; get; } //L/G
        public double Elevation { set; get; }
        public double BarometricPressure { set; get; }
        public double KaV_L { set; get; }
        public double CurveMinimum { set; get; }
        public double CurveMaximum { set; get; }
        public double WetBulbTemperature { set; get; }
        public double Range { set; get; }
        public double Approach { set; get; }

        public string UnitsTemperature { set; get; }
        public string UnitsEnthalpy { set; get; }

        //public Units Units { get; set; }
        public bool IsDemo { get; set; }
        public bool IsInternationalSystemOfUnits_IS_ { get; set; }
        public bool IsElevation { get; set; } // attitude
        public bool IsCoef { get; set; } // coef
        public bool IsWaterAirRatio { get; set; } // lg


        //public DemandCurveData(bool isInternationalSystemOfUnits_IS_, bool isElevation, bool isDemo = false)
        public DemandCurveData(bool isInternationalSystemOfUnits_IS_)
        {
            IsDemo = false;
            IsInternationalSystemOfUnits_IS_ = isInternationalSystemOfUnits_IS_;
            IsElevation = true;

//#ifdef _DEMO_VERSION
//            CurveC1 = 2.0;
//            CurveC2 = (-0.75);
//#else
            CurveC1 = 0;
            CurveC2 = 0;
//#endif
            WaterAirRatio = 1.0;
            BarometricPressure = 0.0;
            Elevation = 0;
            KaV_L = 0;
            CurveMinimum = 0.5;
            CurveMaximum = 2.5;
            if (IsInternationalSystemOfUnits_IS_)
            {
                WetBulbTemperature = 26.667;
                Range = 18;
            }
            else
            {
                WetBulbTemperature = 80;
                Range = 10;
            }

            DataTable = new DataTable();

            //SetUnits();
        }

        //private void SetUnits()
        //{
        //    if (IsInternationalSystemOfUnits_IS_)
        //    {
        //        Units = new UnitsSI();
        //    }
        //    else
        //    {
        //        Units = new UnitsIP();
        //    }
        //}

        public void SetInternationalSystemOfUnits_IS_(bool value)
        {
            IsInternationalSystemOfUnits_IS_ = value;
            //SetUnits();
        }

        public void SetElevation(bool value)
        {
            IsElevation = value;
        }

        public void SetDemo(bool value)
        {
            IsDemo = value;
            //SetUnits();
        }
    }
}