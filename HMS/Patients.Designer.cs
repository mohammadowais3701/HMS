namespace HMS
{
    partial class Patients
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
            this.back = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(-2, 243);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(289, 64);
            this.back.TabIndex = 9;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view.Location = new System.Drawing.Point(-2, 182);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(289, 64);
            this.view.TabIndex = 8;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.remove.Location = new System.Drawing.Point(-2, 121);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(289, 64);
            this.remove.TabIndex = 7;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edit.Location = new System.Drawing.Point(-2, 60);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(289, 64);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(-2, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(289, 64);
            this.add.TabIndex = 5;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 305);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.add);
            this.Name = "Patients";
            this.Text = "Patients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button add;
    }
}