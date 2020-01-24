﻿// Copyright Cooling Technology Institute 2019-2020

using System;
using System.Data;
using System.Text;

namespace ViewModels
{
    public class LiquidToGasRatioRateDataValue : DataValue
    {
        public const double LGDefault = 1.0; //DDV_MinMaxDouble(pDX, m_dblLg, LG_P3_MIN_IP (0.0), LG_P3_MAX_IP (5.0), LG_P3_MIN_SI (0.0), LG_P3_MAX_SI (5.0), 2);
        public const double LGMinimum = 0.0;
        public const double LGMaximum = 5.0;

        public const double LGDefaultDemo = 1.0;
        public const double LGMinimumDemo = 1.0;
        public const double LGMaximumDemo = 5.0;

        public const double LGDefault_InternationalSystemOfUnits_IS_ = 1.0;
        public const double LGMinimum_InternationalSystemOfUnits_IS_ = 1.0;
        public const double LGMaximum_InternationalSystemOfUnits_IS_ = 5.0;

        public const double LGDefault_InternationalSystemOfUnits_IS_Demo = 1.0;
        public const double LGMinimum_InternationalSystemOfUnits_IS_Demo = 1.0;
        public const double LGMaximum_InternationalSystemOfUnits_IS_Demo = 5.0;

        public const string LGToolTipFormat = "L/G.\nValue should be between {0} and {1}.\n";

        public LiquidToGasRatioRateDataValue(bool isDemo, bool isInternationalSystemOfUnits_IS_)
        {
            IsDemo = isDemo;
            InputMessage = "L/G";
            Format = "F2";
            ConvertValue(isInternationalSystemOfUnits_IS_);
        }

        public override void ConvertValue(bool isInternationalSystemOfUnits_IS_, bool doConversion = false)
        {
            if (isInternationalSystemOfUnits_IS_)
            {
                if (IsDemo)
                {
                    Default = LGDefault_InternationalSystemOfUnits_IS_Demo;
                    Minimum = LGMinimum_InternationalSystemOfUnits_IS_Demo;
                    Maximum = LGMaximum_InternationalSystemOfUnits_IS_Demo;
                }
                else
                {
                    Default = LGDefault_InternationalSystemOfUnits_IS_;
                    Minimum = LGMinimum_InternationalSystemOfUnits_IS_;
                    Maximum = LGMaximum_InternationalSystemOfUnits_IS_;
                }
            }
            else
            {
                if (IsDemo)
                {
                    Default = LGDefaultDemo;
                    Minimum = LGMinimumDemo;
                    Maximum = LGMaximumDemo;
                }
                else
                {
                    Default = LGDefault;
                    Minimum = LGMinimum;
                    Maximum = LGMaximum;
                }
            }

            if (doConversion)
            {
                if (IsInternationalSystemOfUnits_IS_ && !isInternationalSystemOfUnits_IS_)
                {
                }
                else
                {
                }
            }
            else
            {
                Current = Default;
            }

            InputValue = Current.ToString(Format);
            ToolTip = string.Format(LGToolTipFormat, Minimum, Maximum);

            IsInternationalSystemOfUnits_IS_ = isInternationalSystemOfUnits_IS_;
        }
    }
}