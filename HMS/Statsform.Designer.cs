namespace HMS
{
    partial class Statsform
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dischargepatients = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dischargepatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dischargepatients
            // 
            chartArea1.Name = "ChartArea1";
            this.dischargepatients.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dischargepatients.Legends.Add(legend1);
            this.dischargepatients.Location = new System.Drawing.Point(-2, 4);
            this.dischargepatients.Name = "dischargepatients";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.dischargepatients.Series.Add(series1);
            this.dischargepatients.Size = new System.Drawing.Size(403, 312);
            this.dischargepatients.TabIndex = 12;
            this.dischargepatients.Click += new System.EventHandler(this.dischargepatients_Click);
            // 
            // Statsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 316);
            this.Controls.Add(this.dischargepatients);
            this.Name = "Statsform";
            this.Text = "Statsform";
            this.Load += new System.EventHandler(this.Statsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dischargepatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dischargepatients;
    }
}