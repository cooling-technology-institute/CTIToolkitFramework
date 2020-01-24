// Copyright Cooling Technology Institute 2019-2020

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models
{
    public class RangeColdWaterTemperaturesDesignData
    {
        public TemperatureDesignData Temperatures { set; get; }

        public RangeColdWaterTemperaturesDesignData()
        {
            Temperatures = new TemperatureDesignData();
        }
    }
}