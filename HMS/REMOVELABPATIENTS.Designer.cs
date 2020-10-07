namespace HMS
{
    partial class REMOVELABPATIENTS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(161, 114);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(320, 20);
            this.idtb.TabIndex = 2;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(161, 169);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(320, 20);
            this.nametb.TabIndex = 3;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtn.Location = new System.Drawing.Point(382, 218);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(109, 36);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "BACK<<";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.removebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removebtn.Location = new System.Drawing.Point(118, 221);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(107, 33);
            this.removebtn.TabIndex = 5;
            this.removebtn.Text = "REMOVE";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 61);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "REMOVE LAB PATIENT";
            // 
            // REMOVELABPATIENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "REMOVELABPATIENTS";
            this.Text = "REMOVELABPATIENTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}