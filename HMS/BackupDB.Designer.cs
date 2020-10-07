namespace HMS
{
    partial class BackupDB
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
            this.servernametb = new System.Windows.Forms.TextBox();
            this.dbnametb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.locationbtn = new System.Windows.Forms.Button();
            this.restorebtn = new System.Windows.Forms.Button();
            this.rdbtb = new System.Windows.Forms.TextBox();
            this.rservernametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backupbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servernametb
            // 
            this.servernametb.Location = new System.Drawing.Point(158, 62);
            this.servernametb.Name = "servernametb";
            this.servernametb.ReadOnly = true;
            this.servernametb.Size = new System.Drawing.Size(198, 20);
            this.servernametb.TabIndex = 2;
            this.servernametb.Text = "(localdb)\\MSSQLLocalDB";
            this.servernametb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dbnametb
            // 
            this.dbnametb.Location = new System.Drawing.Point(158, 111);
            this.dbnametb.Name = "dbnametb";
            this.dbnametb.ReadOnly = true;
            this.dbnametb.Size = new System.Drawing.Size(198, 20);
            this.dbnametb.TabIndex = 3;
            this.dbnametb.Text = "HMS";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 26);
            this.textBox1.TabIndex = 5;
            // 
            // locationbtn
            // 
            this.locationbtn.Location = new System.Drawing.Point(384, 68);
            this.locationbtn.Name = "locationbtn";
            this.locationbtn.Size = new System.Drawing.Size(28, 20);
            this.locationbtn.TabIndex = 6;
            this.locationbtn.Text = "...";
            this.locationbtn.UseVisualStyleBackColor = true;
            this.locationbtn.Click += new System.EventHandler(this.locationbtn_Click);
            // 
            // restorebtn
            // 
            this.restorebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restorebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restorebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restorebtn.Location = new System.Drawing.Point(358, 164);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(93, 31);
            this.restorebtn.TabIndex = 11;
            this.restorebtn.Text = "Restore";
            this.restorebtn.UseVisualStyleBackColor = false;
            this.restorebtn.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // rdbtb
            // 
            this.rdbtb.Location = new System.Drawing.Point(231, 170);
            this.rdbtb.Name = "rdbtb";
            this.rdbtb.ReadOnly = true;
            this.rdbtb.Size = new System.Drawing.Size(125, 20);
            this.rdbtb.TabIndex = 10;
            this.rdbtb.Text = "HMS";
            // 
            // rservernametb
            // 
            this.rservernametb.Location = new System.Drawing.Point(231, 121);
            this.rservernametb.Name = "rservernametb";
            this.rservernametb.ReadOnly = true;
            this.rservernametb.Size = new System.Drawing.Size(125, 20);
            this.rservernametb.TabIndex = 9;
            this.rservernametb.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataBase Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, -2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.dbnametb);
            this.splitContainer1.Panel1.Controls.Add(this.servernametb);
            this.splitContainer1.Panel1.Controls.Add(this.backupbtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.restorebtn);
            this.splitContainer1.Panel2.Controls.Add(this.locationbtn);
            this.splitContainer1.Panel2.Controls.Add(this.rdbtb);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.rservernametb);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(451, 499);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location\r\n\r\n";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 49);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "BACKUP YOUR DATABASE";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(451, 49);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "RESTORE YOUR DATABASE";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Server Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "DataBase Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(170, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "BACK<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backupbtn
            // 
            this.backupbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backupbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backupbtn.Location = new System.Drawing.Point(358, 104);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(94, 31);
            this.backupbtn.TabIndex = 4;
            this.backupbtn.Text = "Backup";
            this.backupbtn.UseVisualStyleBackColor = false;
            this.backupbtn.Click += new System.EventHandler(this.backupbtn_Click);
            // 
            // BackupDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 498);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BackupDB";
            this.Text = "BackupDB";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox servernametb;
        private System.Windows.Forms.TextBox dbnametb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button locationbtn;
        private System.Windows.Forms.Button restorebtn;
        private System.Windows.Forms.TextBox rdbtb;
        private System.Windows.Forms.TextBox rservernametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button backupbtn;
    }
}