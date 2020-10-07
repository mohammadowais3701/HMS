namespace HMS
{
    partial class labpatientAdmissionSlip
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HMSDataSet1 = new HMS.HMSDataSet1();
            this.tbl_labBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_labTableAdapter = new HMS.HMSDataSet1TableAdapters.tbl_labTableAdapter();
            this.searchbtn = new System.Windows.Forms.Button();
            this.Idtb = new System.Windows.Forms.TextBox();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labpatientdataset = new HMS.labpatientdataset();
            this.DataTable1TableAdapter = new HMS.labpatientdatasetTableAdapters.DataTable1TableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_labPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HMSDataSet = new HMS.HMSDataSet();
            this.tbl_labPatientsTableAdapter = new HMS.HMSDataSetTableAdapters.tbl_labPatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_labBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labpatientdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_labPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_labPatientsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HMS.labReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // HMSDataSet1
            // 
            this.HMSDataSet1.DataSetName = "HMSDataSet1";
            this.HMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_labBindingSource
            // 
            this.tbl_labBindingSource.DataMember = "tbl_lab";
            this.tbl_labBindingSource.DataSource = this.HMSDataSet1;
            // 
            // tbl_labTableAdapter
            // 
            this.tbl_labTableAdapter.ClearBeforeFill = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(501, 32);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Idtb
            // 
            this.Idtb.Location = new System.Drawing.Point(98, 32);
            this.Idtb.Name = "Idtb";
            this.Idtb.Size = new System.Drawing.Size(350, 20);
            this.Idtb.TabIndex = 2;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.labpatientdataset;
            // 
            // labpatientdataset
            // 
            this.labpatientdataset.DataSetName = "labpatientdataset";
            this.labpatientdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(612, 32);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back<<";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // tbl_labPatientsBindingSource
            // 
            this.tbl_labPatientsBindingSource.DataMember = "tbl_labPatients";
            this.tbl_labPatientsBindingSource.DataSource = this.HMSDataSet;
            // 
            // HMSDataSet
            // 
            this.HMSDataSet.DataSetName = "HMSDataSet";
            this.HMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_labPatientsTableAdapter
            // 
            this.tbl_labPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // labpatientAdmissionSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Idtb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.reportViewer1);
            this.Name = "labpatientAdmissionSlip";
            this.Text = "labpatientAdmissionSlip";
            this.Load += new System.EventHandler(this.labpatientAdmissionSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_labBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labpatientdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_labPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private labpatientdataset labpatientdataset;
        private System.Windows.Forms.BindingSource tbl_labBindingSource;
        private HMSDataSet1 HMSDataSet1;
        private labpatientdatasetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private HMSDataSet1TableAdapters.tbl_labTableAdapter tbl_labTableAdapter;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox Idtb;
        private System.Windows.Forms.BindingSource tbl_labPatientsBindingSource;
        private HMSDataSet HMSDataSet;
        private HMSDataSetTableAdapters.tbl_labPatientsTableAdapter tbl_labPatientsTableAdapter;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
    }
}