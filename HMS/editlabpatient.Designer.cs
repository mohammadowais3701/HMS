namespace HMS
{
    partial class editlabpatient
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.idtb = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.agetb = new System.Windows.Forms.TextBox();
            this.fathernametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitbtn.Location = new System.Drawing.Point(510, 451);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(125, 39);
            this.submitbtn.TabIndex = 59;
            this.submitbtn.Text = "SUBMIT>>";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtn.Location = new System.Drawing.Point(125, 451);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(127, 39);
            this.backbtn.TabIndex = 58;
            this.backbtn.Text = "BACK<<";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(221, 173);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(466, 20);
            this.idtb.TabIndex = 57;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(64, 173);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 22);
            this.ID.TabIndex = 56;
            this.ID.Text = "ID";
            // 
            // agetb
            // 
            this.agetb.Location = new System.Drawing.Point(221, 340);
            this.agetb.Name = "agetb";
            this.agetb.Size = new System.Drawing.Size(466, 20);
            this.agetb.TabIndex = 51;
            // 
            // fathernametb
            // 
            this.fathernametb.Location = new System.Drawing.Point(221, 288);
            this.fathernametb.Name = "fathernametb";
            this.fathernametb.Size = new System.Drawing.Size(466, 20);
            this.fathernametb.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "AGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "FATHER NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "NAME";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(221, 233);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(466, 20);
            this.nametb.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 61;
            this.label4.Text = "PHONE #";
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(221, 391);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(466, 20);
            this.phonetb.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(530, 61);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "EDIT LAB PATIENT\'S DETAILS";
            // 
            // editlabpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(749, 581);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.agetb);
            this.Controls.Add(this.fathernametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editlabpatient";
            this.Text = "editlabpatient";
            this.Load += new System.EventHandler(this.editlabpatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.TextBox fathernametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.TextBox textBox1;
    }
}