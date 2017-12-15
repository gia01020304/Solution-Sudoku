namespace Final
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Bisque;
            this.btnNew.Location = new System.Drawing.Point(168, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(204, 78);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.MistyRose;
            this.btnScore.Location = new System.Drawing.Point(168, 372);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(204, 77);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Final.Properties.Resources.sdk5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 493);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConti
            // 
            this.btnConti.BackColor = System.Drawing.Color.MistyRose;
            this.btnConti.Location = new System.Drawing.Point(168, 273);
            this.btnConti.Name = "btnConti";
            this.btnConti.Size = new System.Drawing.Size(204, 78);
            this.btnConti.TabIndex = 1;
            this.btnConti.Text = "Continue";
            this.btnConti.UseVisualStyleBackColor = false;
            this.btnConti.Click += new System.EventHandler(this.btnConti_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 493);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnConti);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnConti;
    }
}

