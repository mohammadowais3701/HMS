namespace HMS
{
    partial class Statistics
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
            this.dischargePatients = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dischargePatients
            // 
            this.dischargePatients.Location = new System.Drawing.Point(2, 1);
            this.dischargePatients.Name = "dischargePatients";
            this.dischargePatients.Size = new System.Drawing.Size(253, 46);
            this.dischargePatients.TabIndex = 0;
            this.dischargePatients.Text = "Discharge Patients";
            this.dischargePatients.UseVisualStyleBackColor = true;
            this.dischargePatients.Click += new System.EventHandler(this.dischargePatients_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 268);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dischargePatients);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dischargePatients;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}