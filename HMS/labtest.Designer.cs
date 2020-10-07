namespace HMS
{
    partial class labtest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labtest));
            this.labtestgrid = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.addtest = new System.Windows.Forms.Button();
            this.edittest = new System.Windows.Forms.Button();
            this.removetest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.labtestgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labtestgrid
            // 
            this.labtestgrid.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.labtestgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labtestgrid.Location = new System.Drawing.Point(2, 2);
            this.labtestgrid.Name = "labtestgrid";
            this.labtestgrid.Size = new System.Drawing.Size(338, 290);
            this.labtestgrid.TabIndex = 0;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtn.Location = new System.Drawing.Point(340, 258);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(206, 42);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "BACK<<";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addtest
            // 
            this.addtest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.addtest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addtest.Location = new System.Drawing.Point(340, 149);
            this.addtest.Name = "addtest";
            this.addtest.Size = new System.Drawing.Size(206, 38);
            this.addtest.TabIndex = 2;
            this.addtest.Text = "Add Test";
            this.addtest.UseVisualStyleBackColor = false;
            this.addtest.Click += new System.EventHandler(this.addtest_Click);
            // 
            // edittest
            // 
            this.edittest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edittest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.edittest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edittest.Location = new System.Drawing.Point(340, 184);
            this.edittest.Name = "edittest";
            this.edittest.Size = new System.Drawing.Size(206, 38);
            this.edittest.TabIndex = 3;
            this.edittest.Text = "Edit";
            this.edittest.UseVisualStyleBackColor = false;
            this.edittest.Click += new System.EventHandler(this.edittest_Click);
            // 
            // removetest
            // 
            this.removetest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removetest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.removetest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removetest.Location = new System.Drawing.Point(340, 218);
            this.removetest.Name = "removetest";
            this.removetest.Size = new System.Drawing.Size(206, 43);
            this.removetest.TabIndex = 4;
            this.removetest.Text = "Remove";
            this.removetest.UseVisualStyleBackColor = false;
            this.removetest.Click += new System.EventHandler(this.removetest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(340, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 151);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removetest);
            this.Controls.Add(this.edittest);
            this.Controls.Add(this.addtest);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.labtestgrid);
            this.Name = "labtest";
            this.Text = "labtest";
            this.Load += new System.EventHandler(this.labtest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labtestgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView labtestgrid;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addtest;
        private System.Windows.Forms.Button edittest;
        private System.Windows.Forms.Button removetest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}