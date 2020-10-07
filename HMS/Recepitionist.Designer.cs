namespace HMS
{
    partial class Recepitionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recepitionist));
            this.button1 = new System.Windows.Forms.Button();
            this.admission = new System.Windows.Forms.Button();
            this.appointments = new System.Windows.Forms.Button();
            this.Hsstory = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new HMS.HMSDataSet1TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Stats = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Doctors";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admission
            // 
            this.admission.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admission.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admission.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.admission.Location = new System.Drawing.Point(0, 78);
            this.admission.Name = "admission";
            this.admission.Size = new System.Drawing.Size(202, 80);
            this.admission.TabIndex = 5;
            this.admission.Text = "Admission";
            this.admission.UseVisualStyleBackColor = false;
            this.admission.Click += new System.EventHandler(this.admission_Click);
            // 
            // appointments
            // 
            this.appointments.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.appointments.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.appointments.Location = new System.Drawing.Point(0, 151);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(200, 82);
            this.appointments.TabIndex = 6;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = false;
            this.appointments.Click += new System.EventHandler(this.appointments_Click);
            // 
            // Hsstory
            // 
            this.Hsstory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hsstory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hsstory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hsstory.Location = new System.Drawing.Point(0, 225);
            this.Hsstory.Name = "Hsstory";
            this.Hsstory.Size = new System.Drawing.Size(202, 82);
            this.Hsstory.TabIndex = 7;
            this.Hsstory.Text = "History";
            this.Hsstory.UseVisualStyleBackColor = false;
            this.Hsstory.Click += new System.EventHandler(this.Hsstory_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.SteelBlue;
            this.back.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(0, 38);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(48, 46);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_labTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HMS.HMSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 378);
            this.panel1.TabIndex = 9;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(47, 44);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.Stats);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.admission);
            this.panel2.Controls.Add(this.appointments);
            this.panel2.Controls.Add(this.Hsstory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(47, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 378);
            this.panel2.TabIndex = 10;
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stats.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stats.Location = new System.Drawing.Point(0, 296);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(202, 82);
            this.Stats.TabIndex = 8;
            this.Stats.Text = "Backup";
            this.Stats.UseVisualStyleBackColor = false;
            this.Stats.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Recepitionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::HMS.Properties.Resources.HMS_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Recepitionist";
            this.Text = "     ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button admission;
        private System.Windows.Forms.Button appointments;
        private System.Windows.Forms.Button Hsstory;
        private System.Windows.Forms.Button back;
        private HMSDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stats;
    }
}