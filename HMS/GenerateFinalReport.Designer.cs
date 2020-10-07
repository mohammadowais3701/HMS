namespace HMS
{
    partial class GenerateFinalReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewReportDataset = new HMS.ViewReportDataset();
            this.Generatebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new HMS.ViewReportDatasetTableAdapters.DataTable1TableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ViewReportDataset;
            // 
            // ViewReportDataset
            // 
            this.ViewReportDataset.DataSetName = "ViewReportDataset";
            this.ViewReportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Generatebtn
            // 
            this.Generatebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Generatebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Generatebtn.Location = new System.Drawing.Point(378, 49);
            this.Generatebtn.Name = "Generatebtn";
            this.Generatebtn.Size = new System.Drawing.Size(103, 33);
            this.Generatebtn.TabIndex = 0;
            this.Generatebtn.Text = "Generate";
            this.Generatebtn.UseVisualStyleBackColor = false;
            this.Generatebtn.Click += new System.EventHandler(this.Generatebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(124, 49);
            this.IDtb.Multiline = true;
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(248, 25);
            this.IDtb.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.SteelBlue;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HMS.VierReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(64, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(476, 288);
            this.reportViewer1.TabIndex = 3;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtn.Location = new System.Drawing.Point(487, 49);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(89, 33);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back<<";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // GenerateFinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(588, 415);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generatebtn);
            this.Name = "GenerateFinalReport";
            this.Text = "GenerateFinalReport";
            this.Load += new System.EventHandler(this.GenerateFinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtb;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ViewReportDataset ViewReportDataset;
        private ViewReportDatasetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button backbtn;
    }
}