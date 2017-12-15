namespace Final
{
    partial class FormLevel
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEasy = new System.Windows.Forms.Button();
            this.txtMedium = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnhard = new System.Windows.Forms.Button();
            this.btnEvil = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final.Properties.Resources.pt3;
            this.pictureBox2.Location = new System.Drawing.Point(115, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Final.Properties.Resources.sdk5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEasy.Location = new System.Drawing.Point(193, 147);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(171, 55);
            this.btnEasy.TabIndex = 2;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.click);
            // 
            // txtMedium
            // 
            this.txtMedium.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtMedium.Location = new System.Drawing.Point(193, 208);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(171, 55);
            this.txtMedium.TabIndex = 2;
            this.txtMedium.Text = "Medium";
            this.txtMedium.UseVisualStyleBackColor = false;
            this.txtMedium.Click += new System.EventHandler(this.click);
            // 
            // btnDiff
            // 
            this.btnDiff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDiff.Location = new System.Drawing.Point(193, 269);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(171, 55);
            this.btnDiff.TabIndex = 2;
            this.btnDiff.Text = "Difficult";
            this.btnDiff.UseVisualStyleBackColor = false;
            this.btnDiff.Click += new System.EventHandler(this.click);
            // 
            // btnhard
            // 
            this.btnhard.BackColor = System.Drawing.Color.SkyBlue;
            this.btnhard.Location = new System.Drawing.Point(193, 330);
            this.btnhard.Name = "btnhard";
            this.btnhard.Size = new System.Drawing.Size(171, 55);
            this.btnhard.TabIndex = 2;
            this.btnhard.Text = "Hard";
            this.btnhard.UseVisualStyleBackColor = false;
            this.btnhard.Click += new System.EventHandler(this.click);
            // 
            // btnEvil
            // 
            this.btnEvil.BackColor = System.Drawing.Color.Plum;
            this.btnEvil.Location = new System.Drawing.Point(193, 391);
            this.btnEvil.Name = "btnEvil";
            this.btnEvil.Size = new System.Drawing.Size(171, 55);
            this.btnEvil.TabIndex = 2;
            this.btnEvil.Text = "Evil";
            this.btnEvil.UseVisualStyleBackColor = false;
            this.btnEvil.Click += new System.EventHandler(this.click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCustom.Location = new System.Drawing.Point(193, 452);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(171, 55);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // FormLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 531);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnEvil);
            this.Controls.Add(this.btnhard);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button txtMedium;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnhard;
        private System.Windows.Forms.Button btnEvil;
        private System.Windows.Forms.Button btnCustom;
    }
}