namespace ChampionCompare
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.champOneDropdown = new System.Windows.Forms.ComboBox();
            this.champTwoDropdown = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DataChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Title = "Stats";
            chartArea1.AxisX2.Interval = 1D;
            chartArea1.Name = "MainArea";
            this.DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DataChart.Legends.Add(legend1);
            this.DataChart.Location = new System.Drawing.Point(38, 12);
            this.DataChart.Name = "DataChart";
            this.DataChart.Size = new System.Drawing.Size(938, 569);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "Data Chart";
            // 
            // champOneDropdown
            // 
            this.champOneDropdown.AllowDrop = true;
            this.champOneDropdown.FormattingEnabled = true;
            this.champOneDropdown.Location = new System.Drawing.Point(1004, 89);
            this.champOneDropdown.Name = "champOneDropdown";
            this.champOneDropdown.Size = new System.Drawing.Size(182, 21);
            this.champOneDropdown.TabIndex = 1;
            // 
            // champTwoDropdown
            // 
            this.champTwoDropdown.FormattingEnabled = true;
            this.champTwoDropdown.Location = new System.Drawing.Point(1007, 168);
            this.champTwoDropdown.Name = "champTwoDropdown";
            this.champTwoDropdown.Size = new System.Drawing.Size(179, 21);
            this.champTwoDropdown.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(1016, 442);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(170, 67);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 644);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.champTwoDropdown);
            this.Controls.Add(this.champOneDropdown);
            this.Controls.Add(this.DataChart);
            this.Name = "MainForm";
            this.Text = "Champion Compare";
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);

        }        

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.ComboBox champOneDropdown;
        private System.Windows.Forms.ComboBox champTwoDropdown;
        private System.Windows.Forms.Button submitButton;

        
    }

}

