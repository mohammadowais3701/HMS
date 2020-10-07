namespace HMS
{
    partial class DischargeForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RemovepatientData = new HMS.RemovepatientData();
            this.tbl_patientshistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_patientshistoryTableAdapter = new HMS.RemovepatientDataTableAdapters.tbl_patientshistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RemovepatientData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_patientshistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 1;
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(462, 22);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(75, 23);
            this.generatebtn.TabIndex = 2;
            this.generatebtn.Text = "GENERATE";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(557, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "BACK <<";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbl_patientshistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HMS.dischargereport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(585, 505);
            this.reportViewer1.TabIndex = 4;
            // 
            // RemovepatientData
            // 
            this.RemovepatientData.DataSetName = "RemovepatientData";
            this.RemovepatientData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_patientshistoryBindingSource
            // 
            this.tbl_patientshistoryBindingSource.DataMember = "tbl_patientshistory";
            this.tbl_patientshistoryBindingSource.DataSource = this.RemovepatientData;
            // 
            // tbl_patientshistoryTableAdapter
            // 
            this.tbl_patientshistoryTableAdapter.ClearBeforeFill = true;
            // 
            // DischargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 633);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DischargeForm";
            this.Text = "DischargeForm";
            this.Load += new System.EventHandler(this.DischargeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RemovepatientData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_patientshistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button backbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_patientshistoryBindingSource;
        private RemovepatientData RemovepatientData;
        private RemovepatientDataTableAdapters.tbl_patientshistoryTableAdapter tbl_patientshistoryTableAdapter;
    }
}