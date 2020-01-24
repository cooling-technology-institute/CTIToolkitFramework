namespace CTIToolkit
{
    partial class MerkelTabPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MerkelGridView = new System.Windows.Forms.DataGridView();
            this.InputPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.Merkle_Elevation_Pressure_Selector = new System.Windows.Forms.ComboBox();
            this.MerkelWebBulbTemperatureUnits = new System.Windows.Forms.Label();
            this.MerkelElevationPressureUnits = new System.Windows.Forms.Label();
            this.Merkel_Elevation_Value = new System.Windows.Forms.TextBox();
            this.LiquidtoGasRatioLabel = new System.Windows.Forms.Label();
            this.Merkel_LiquidtoGasRatio_Value = new System.Windows.Forms.TextBox();
            this.MerkelWetBulbTemperatureLabel = new System.Windows.Forms.Label();
            this.MerkelTemperatureColdWaterUnits = new System.Windows.Forms.Label();
            this.MerkelTemperatureHotWaterUnits = new System.Windows.Forms.Label();
            this.Merkel_WetBulbTemperature_Value = new System.Windows.Forms.TextBox();
            this.Merkel_ColdWaterTemperature_Value = new System.Windows.Forms.TextBox();
            this.Merkel_HotWaterTemperature_Value = new System.Windows.Forms.TextBox();
            this.TemperatureColdWaterLabel = new System.Windows.Forms.Label();
            this.TemperatureHotWaterLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MerkelCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MerkelGridView)).BeginInit();
            this.InputPropertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MerkelGridView
            // 
            this.MerkelGridView.AllowUserToAddRows = false;
            this.MerkelGridView.AllowUserToDeleteRows = false;
            this.MerkelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MerkelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MerkelGridView.Location = new System.Drawing.Point(10, 317);
            this.MerkelGridView.Name = "MerkelGridView";
            this.MerkelGridView.ReadOnly = true;
            this.MerkelGridView.Size = new System.Drawing.Size(742, 294);
            this.MerkelGridView.TabIndex = 13;
            // 
            // InputPropertiesGroupBox
            // 
            this.InputPropertiesGroupBox.Controls.Add(this.Merkle_Elevation_Pressure_Selector);
            this.InputPropertiesGroupBox.Controls.Add(this.MerkelWebBulbTemperatureUnits);
            this.InputPropertiesGroupBox.Controls.Add(this.MerkelElevationPressureUnits);
            this.InputPropertiesGroupBox.Controls.Add(this.Merkel_Elevation_Value);
            this.InputPropertiesGroupBox.Controls.Add(this.LiquidtoGasRatioLabel);
            this.InputPropertiesGroupBox.Controls.Add(this.Merkel_LiquidtoGasRatio_Value);
            this.InputPropertiesGroupBox.Controls.Add(this.MerkelWetBulbTemperatureLabel);
            this.InputPropertiesGroupBox.Controls.Add(this.MerkelTemperatureColdWaterUnits);
            this.InputPropertiesGroupBox.Controls.Add(this.MerkelTemperatureHotWaterUnits);
            this.InputPropertiesGroupBox.Controls.Add(this.Merkel_WetBulbTemperature_Value);
            this.InputPropertiesGroupBox.Controls.Add(this.Merkel_ColdWaterTemperature_Value);
            this.InputPropertiesGroupBox.Controls.Add(this.Merkel_HotWaterTemperature_Value);
            this.InputPropertiesGroupBox.Controls.Add(this.TemperatureColdWaterLabel);
            this.InputPropertiesGroupBox.Controls.Add(this.TemperatureHotWaterLabel);
            this.InputPropertiesGroupBox.Location = new System.Drawing.Point(9, 10);
            this.InputPropertiesGroupBox.Name = "InputPropertiesGroupBox";
            this.InputPropertiesGroupBox.Size = new System.Drawing.Size(743, 186);
            this.InputPropertiesGroupBox.TabIndex = 11;
            this.InputPropertiesGroupBox.TabStop = false;
            this.InputPropertiesGroupBox.Text = "Input Properties";
            // 
            // Merkle_Elevation_Pressure_Selector
            // 
            this.Merkle_Elevation_Pressure_Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Merkle_Elevation_Pressure_Selector.FormattingEnabled = true;
            this.Merkle_Elevation_Pressure_Selector.Items.AddRange(new object[] {
            "Elevation:",
            "Barometric Pressure:"});
            this.Merkle_Elevation_Pressure_Selector.Location = new System.Drawing.Point(15, 114);
            this.Merkle_Elevation_Pressure_Selector.Name = "Merkle_Elevation_Pressure_Selector";
            this.Merkle_Elevation_Pressure_Selector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Merkle_Elevation_Pressure_Selector.Size = new System.Drawing.Size(123, 21);
            this.Merkle_Elevation_Pressure_Selector.TabIndex = 21;
            this.Merkle_Elevation_Pressure_Selector.SelectedIndexChanged += new System.EventHandler(this.Merkle_Elevation_Pressure_Selector_SelectedIndexChanged);
            // 
            // MerkelWebBulbTemperatureUnits
            // 
            this.MerkelWebBulbTemperatureUnits.AutoSize = true;
            this.MerkelWebBulbTemperatureUnits.Location = new System.Drawing.Point(259, 91);
            this.MerkelWebBulbTemperatureUnits.Name = "MerkelTemperatureWebBulbUnits";
            this.MerkelWebBulbTemperatureUnits.Size = new System.Drawing.Size(17, 13);
            this.MerkelWebBulbTemperatureUnits.TabIndex = 18;
            this.MerkelWebBulbTemperatureUnits.Text = "°F";
            // 
            // MerkelElevationPressureUnits
            // 
            this.MerkelElevationPressureUnits.AutoSize = true;
            this.MerkelElevationPressureUnits.Location = new System.Drawing.Point(259, 117);
            this.MerkelElevationPressureUnits.Name = "MerkelElevationPressureUnits";
            this.MerkelElevationPressureUnits.Size = new System.Drawing.Size(13, 13);
            this.MerkelElevationPressureUnits.TabIndex = 16;
            this.MerkelElevationPressureUnits.Text = "ft";
            // 
            // Merkel_Elevation_Value
            // 
            this.Merkel_Elevation_Value.Location = new System.Drawing.Point(152, 114);
            this.Merkel_Elevation_Value.Name = "Merkel_Elevation_Value";
            this.Merkel_Elevation_Value.Size = new System.Drawing.Size(100, 20);
            this.Merkel_Elevation_Value.TabIndex = 15;
            this.Merkel_Elevation_Value.Text = "0";
            this.Merkel_Elevation_Value.TextChanged += new System.EventHandler(this.Merkel_Elevation_Value_TextChanged);
            // 
            // LiquidtoGasRatioLabel
            // 
            this.LiquidtoGasRatioLabel.Location = new System.Drawing.Point(12, 145);
            this.LiquidtoGasRatioLabel.Name = "LGLabel";
            this.LiquidtoGasRatioLabel.Size = new System.Drawing.Size(132, 13);
            this.LiquidtoGasRatioLabel.TabIndex = 14;
            this.LiquidtoGasRatioLabel.Text = "L/G:";
            this.LiquidtoGasRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Merkel_LiquidtoGasRatio_Value
            // 
            this.Merkel_LiquidtoGasRatio_Value.Location = new System.Drawing.Point(152, 142);
            this.Merkel_LiquidtoGasRatio_Value.Name = "Merkel_LG_Value";
            this.Merkel_LiquidtoGasRatio_Value.Size = new System.Drawing.Size(100, 20);
            this.Merkel_LiquidtoGasRatio_Value.TabIndex = 12;
            this.Merkel_LiquidtoGasRatio_Value.Text = "0";
            this.Merkel_LiquidtoGasRatio_Value.TextChanged += new System.EventHandler(this.Merkel_LiquidtoGasRatio_Value_TextChanged);
            // 
            // MerkelWetBulbTemperatureLabel
            // 
            this.MerkelWetBulbTemperatureLabel.Location = new System.Drawing.Point(12, 91);
            this.MerkelWetBulbTemperatureLabel.Name = "MerkelWetBulbTemperatureLabel";
            this.MerkelWetBulbTemperatureLabel.Size = new System.Drawing.Size(132, 13);
            this.MerkelWetBulbTemperatureLabel.TabIndex = 11;
            this.MerkelWetBulbTemperatureLabel.Text = "Wet Bulb Temperature:";
            this.MerkelWetBulbTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MerkelTemperatureColdWaterUnits
            // 
            this.MerkelTemperatureColdWaterUnits.AutoSize = true;
            this.MerkelTemperatureColdWaterUnits.Location = new System.Drawing.Point(259, 65);
            this.MerkelTemperatureColdWaterUnits.Name = "MerkelTemperatureColdWaterUnits";
            this.MerkelTemperatureColdWaterUnits.Size = new System.Drawing.Size(17, 13);
            this.MerkelTemperatureColdWaterUnits.TabIndex = 7;
            this.MerkelTemperatureColdWaterUnits.Text = "°F";
            // 
            // MerkelTemperatureHotWaterUnits
            // 
            this.MerkelTemperatureHotWaterUnits.AutoSize = true;
            this.MerkelTemperatureHotWaterUnits.Location = new System.Drawing.Point(259, 36);
            this.MerkelTemperatureHotWaterUnits.Name = "MerkelTemperatureHotWaterUnits";
            this.MerkelTemperatureHotWaterUnits.Size = new System.Drawing.Size(17, 13);
            this.MerkelTemperatureHotWaterUnits.TabIndex = 6;
            this.MerkelTemperatureHotWaterUnits.Text = "°F";
            // 
            // Merkel_WebBulbTemperature_Value
            // 
            this.Merkel_WetBulbTemperature_Value.Location = new System.Drawing.Point(152, 88);
            this.Merkel_WetBulbTemperature_Value.Name = "Merkel_Wet_Bulb_Value";
            this.Merkel_WetBulbTemperature_Value.Size = new System.Drawing.Size(100, 20);
            this.Merkel_WetBulbTemperature_Value.TabIndex = 5;
            this.Merkel_WetBulbTemperature_Value.Text = "0";
            this.Merkel_WetBulbTemperature_Value.TextChanged += new System.EventHandler(this.Merkel_WetBulbTemperature_Value_TextChanged);
            // 
            // Merkel_ColdWaterTemperature_Value
            // 
            this.Merkel_ColdWaterTemperature_Value.Location = new System.Drawing.Point(152, 62);
            this.Merkel_ColdWaterTemperature_Value.Name = "Merkel_CWT_Value";
            this.Merkel_ColdWaterTemperature_Value.Size = new System.Drawing.Size(100, 20);
            this.Merkel_ColdWaterTemperature_Value.TabIndex = 4;
            this.Merkel_ColdWaterTemperature_Value.Text = "90";
            this.Merkel_ColdWaterTemperature_Value.TextChanged += new System.EventHandler(this.Merkel_ColdWaterTemperature_Value_TextChanged);
            // 
            // Merkel_HotWaterTemperature_Value
            // 
            this.Merkel_HotWaterTemperature_Value.Location = new System.Drawing.Point(152, 36);
            this.Merkel_HotWaterTemperature_Value.Name = "Merkel_HWT_Value";
            this.Merkel_HotWaterTemperature_Value.Size = new System.Drawing.Size(100, 20);
            this.Merkel_HotWaterTemperature_Value.TabIndex = 3;
            this.Merkel_HotWaterTemperature_Value.Text = "80";
            this.Merkel_HotWaterTemperature_Value.TextChanged += new System.EventHandler(this.Merkel_HotWaterTemperature_Value_TextChanged);
            // 
            // TemperatureColdWaterLabel
            // 
            this.TemperatureColdWaterLabel.Location = new System.Drawing.Point(12, 65);
            this.TemperatureColdWaterLabel.Name = "TemperatureColdWaterLabel";
            this.TemperatureColdWaterLabel.Size = new System.Drawing.Size(132, 13);
            this.TemperatureColdWaterLabel.TabIndex = 1;
            this.TemperatureColdWaterLabel.Text = "Cold Water Temperature:";
            this.TemperatureColdWaterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TemperatureHotWaterLabel
            // 
            this.TemperatureHotWaterLabel.Location = new System.Drawing.Point(12, 39);
            this.TemperatureHotWaterLabel.Name = "TemperatureHotWaterLabel";
            this.TemperatureHotWaterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TemperatureHotWaterLabel.Size = new System.Drawing.Size(132, 13);
            this.TemperatureHotWaterLabel.TabIndex = 0;
            this.TemperatureHotWaterLabel.Text = "Hot Water Temperature:";
            this.TemperatureHotWaterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MerkelCalculate
            // 
            this.MerkelCalculate.Location = new System.Drawing.Point(10, 242);
            this.MerkelCalculate.Name = "MerkelCalculate";
            this.MerkelCalculate.Size = new System.Drawing.Size(75, 23);
            this.MerkelCalculate.TabIndex = 15;
            this.MerkelCalculate.Text = "Calculate";
            this.MerkelCalculate.UseVisualStyleBackColor = true;
            this.MerkelCalculate.Click += new System.EventHandler(this.MerkelCalculate_Click);
            // 
            // MerkelTabPage
            // 
            this.Controls.Add(this.MerkelCalculate);
            this.Controls.Add(this.MerkelGridView);
            this.Controls.Add(this.InputPropertiesGroupBox);
            this.Name = "MerkelTabPage";
            this.Size = new System.Drawing.Size(767, 622);
            ((System.ComponentModel.ISupportInitialize)(this.MerkelGridView)).EndInit();
            this.InputPropertiesGroupBox.ResumeLayout(false);
            this.InputPropertiesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MerkelGridView;
        private System.Windows.Forms.GroupBox InputPropertiesGroupBox;
        private System.Windows.Forms.Label MerkelWetBulbTemperatureLabel;
        private System.Windows.Forms.Label MerkelTemperatureColdWaterUnits;
        private System.Windows.Forms.Label MerkelTemperatureHotWaterUnits;
        private System.Windows.Forms.TextBox Merkel_WetBulbTemperature_Value;
        private System.Windows.Forms.TextBox Merkel_ColdWaterTemperature_Value;
        private System.Windows.Forms.TextBox Merkel_HotWaterTemperature_Value;
        private System.Windows.Forms.Label TemperatureColdWaterLabel;
        private System.Windows.Forms.Label TemperatureHotWaterLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LiquidtoGasRatioLabel;
        private System.Windows.Forms.TextBox Merkel_LiquidtoGasRatio_Value;
        private System.Windows.Forms.Label MerkelElevationPressureUnits;
        private System.Windows.Forms.TextBox Merkel_Elevation_Value;
        private System.Windows.Forms.Label MerkelWebBulbTemperatureUnits;
        private System.Windows.Forms.Button MerkelCalculate;
        private System.Windows.Forms.ComboBox Merkle_Elevation_Pressure_Selector;
    }
}
