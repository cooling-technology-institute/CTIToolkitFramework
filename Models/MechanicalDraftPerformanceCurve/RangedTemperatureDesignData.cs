// Copyright Cooling Technology Institute 2019-2020

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models
{
    public class RangedTemperaturesDesignData
    {
        public double WaterFlowRate { set; get; }

        public TemperatureDesignData WetBulbTemperatures { set; get; }

        public RangeColdWaterTemperaturesDesignData RangeWetBulbTemperatures1 { set; get; }
        public RangeColdWaterTemperaturesDesignData RangeWetBulbTemperatures2 { set; get; }
        public RangeColdWaterTemperaturesDesignData RangeWetBulbTemperatures3 { set; get; }
        public RangeColdWaterTemperaturesDesignData RangeWetBulbTemperatures4 { set; get; }
        public RangeColdWaterTemperaturesDesignData RangeWetBulbTemperatures5 { set; get; }

        public RangedTemperaturesDesignData()
        {
            WetBulbTemperatures = new TemperatureDesignData();
            RangeWetBulbTemperatures1 = new RangeColdWaterTemperaturesDesignData();
            RangeWetBulbTemperatures2 = new RangeColdWaterTemperaturesDesignData();
            RangeWetBulbTemperatures3 = new RangeColdWaterTemperaturesDesignData();
            RangeWetBulbTemperatures4 = new RangeColdWaterTemperaturesDesignData();
            RangeWetBulbTemperatures5 = new RangeColdWaterTemperaturesDesignData();
        }
    }
}