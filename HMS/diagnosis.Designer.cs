namespace HMS
{
    partial class diagnosis
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
            this.testlistbtn = new System.Windows.Forms.Button();
            this.viewreportbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testlistbtn
            // 
            this.testlistbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testlistbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.testlistbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.testlistbtn.Location = new System.Drawing.Point(68, 86);
            this.testlistbtn.Name = "testlistbtn";
            this.testlistbtn.Size = new System.Drawing.Size(165, 54);
            this.testlistbtn.TabIndex = 0;
            this.testlistbtn.Text = "TEST LIST";
            this.testlistbtn.UseVisualStyleBackColor = false;
            this.testlistbtn.Click += new System.EventHandler(this.testlistbtn_Click);
            // 
            // viewreportbtn
            // 
            this.viewreportbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewreportbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewreportbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewreportbtn.Location = new System.Drawing.Point(354, 86);
            this.viewreportbtn.Name = "viewreportbtn";
            this.viewreportbtn.Size = new System.Drawing.Size(165, 54);
            this.viewreportbtn.TabIndex = 1;
            this.viewreportbtn.Text = "VIEW REPORTS";
            this.viewreportbtn.UseVisualStyleBackColor = false;
            this.viewreportbtn.Click += new System.EventHandler(this.viewreportbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(197, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 61);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "Diagnosis";
            // 
            // diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::HMS.Properties.Resources.lab2;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewreportbtn);
            this.Controls.Add(this.testlistbtn);
            this.Name = "diagnosis";
            this.Text = "diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testlistbtn;
        private System.Windows.Forms.Button viewreportbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}