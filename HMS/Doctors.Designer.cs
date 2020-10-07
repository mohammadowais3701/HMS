namespace HMS
{
    partial class Doctors
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
            this.add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.add.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.add.Location = new System.Drawing.Point(2, -1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(289, 64);
            this.add.TabIndex = 0;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Edit.Location = new System.Drawing.Point(2, 59);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(289, 64);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.remove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.remove.Location = new System.Drawing.Point(2, 120);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(289, 64);
            this.remove.TabIndex = 2;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.view.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.view.Location = new System.Drawing.Point(2, 181);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(289, 64);
            this.view.TabIndex = 3;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.back.Location = new System.Drawing.Point(2, 238);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(289, 68);
            this.back.TabIndex = 4;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.add);
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back;
    }
}