﻿using System;
using System.Configuration;

namespace CTIToolkit
{
    public enum UnitsSelection
    {
        United_States_Customary_Units_IP,
        International_System_Of_Units_SI
    }

    public class ApplicationSettings
    {
        private UnitsSelection _UnitsSelection = UnitsSelection.United_States_Customary_Units_IP;

        public UnitsSelection UnitsSelection
        {
            get { return _UnitsSelection; }
            set
            {
                if (_UnitsSelection != value)
                {
                    _UnitsSelection = value;
                    UpdateSettings();
                }
            }
        }

        private bool _IsDemo = true;

        public bool IsDemo
        {
            get { return _IsDemo; }
            set 
            {
                if (_IsDemo != value)
                {
                    _IsDemo = value;
                    UpdateSettings();
                }
            }
        }

        private void UpdateSettings()
        {
            //Properties.Settings.Default.UnitsSelection = UnitsSelection.ToString();
            //Properties.Settings.Default.IsDemo = IsDemo.ToString();
            //Properties.Settings.Default.Save();
            ////Load appsettings
            //Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

            ////Check if key exists in the settings
            //if (config.AppSettings.Settings["UnitsSelection"] != null)
            //{
            //    config.AppSettings.Settings.Add("UnitsSelection", UnitsSelection.ToString());
            //    //If key exists, delete it
            //    //config.AppSettings.Settings.Remove("UnitsSelection");
            //}
            //else
            //{
            //    config.AppSettings.Settings["UnitsSelection"].Value = UnitsSelection.ToString();
            //}

            //////Add new key-value pair
            ////config.AppSettings.Settings.Add("UnitsSelection", UnitsSelection.ToString());

            ////Save the changed settings
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
        }

        public void Read()
        {
            UnitsSelection initialUnitsSelection = UnitsSelection.United_States_Customary_Units_IP;

            string appSettingsUnitsSelection = null;
            try
            {
                //appSettingsUnitsSelection = Properties.Settings.Default.UnitsSelection;
            }
            catch
            { }

            if (string.IsNullOrWhiteSpace(appSettingsUnitsSelection))
            {
                _UnitsSelection = initialUnitsSelection;
            }
            else if(Enum.TryParse<UnitsSelection>(appSettingsUnitsSelection, out initialUnitsSelection))
            {
                _UnitsSelection = initialUnitsSelection; 
            }
        }
    }
}
