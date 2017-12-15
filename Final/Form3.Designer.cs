namespace Final
{
    partial class FormPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.btnStar = new System.Windows.Forms.Button();
            this.btnhin = new System.Windows.Forms.Button();
            this.pn1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnsolution = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pntime = new System.Windows.Forms.Panel();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.pntime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStar
            // 
            this.btnStar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStar.Location = new System.Drawing.Point(8, 3);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(101, 57);
            this.btnStar.TabIndex = 2;
            this.btnStar.Text = "Start";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnhin
            // 
            this.btnhin.Enabled = false;
            this.btnhin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhin.Location = new System.Drawing.Point(137, 3);
            this.btnhin.Name = "btnhin";
            this.btnhin.Size = new System.Drawing.Size(99, 57);
            this.btnhin.TabIndex = 2;
            this.btnhin.Text = "Hints";
            this.btnhin.UseVisualStyleBackColor = true;
            this.btnhin.Click += new System.EventHandler(this.btnhin_Click);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pn1.ColumnCount = 9;
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.Location = new System.Drawing.Point(12, 11);
            this.pn1.Name = "pn1";
            this.pn1.RowCount = 9;
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.pn1.Size = new System.Drawing.Size(400, 401);
            this.pn1.TabIndex = 3;
            this.pn1.Paint += new System.Windows.Forms.PaintEventHandler(this.pn1_Paint);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.White;
            this.txt2.Enabled = false;
            this.txt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt2.Location = new System.Drawing.Point(127, 7);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(55, 32);
            this.txt2.TabIndex = 4;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.WordWrap = false;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnsolution
            // 
            this.btnsolution.Enabled = false;
            this.btnsolution.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsolution.Location = new System.Drawing.Point(9, 79);
            this.btnsolution.Name = "btnsolution";
            this.btnsolution.Size = new System.Drawing.Size(100, 50);
            this.btnsolution.TabIndex = 5;
            this.btnsolution.Text = "Solution";
            this.btnsolution.UseVisualStyleBackColor = true;
            this.btnsolution.Click += new System.EventHandler(this.btnsolution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số ô còn lại:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pntime
            // 
            this.pntime.Controls.Add(this.lb3);
            this.pntime.Controls.Add(this.lb2);
            this.pntime.Controls.Add(this.lb1);
            this.pntime.Location = new System.Drawing.Point(31, 62);
            this.pntime.Name = "pntime";
            this.pntime.Size = new System.Drawing.Size(196, 104);
            this.pntime.TabIndex = 7;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(114, 25);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(69, 57);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "00";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(76, 25);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(38, 57);
            this.lb2.TabIndex = 0;
            this.lb2.Text = ":";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(10, 25);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(69, 57);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "00";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(137, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 57);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStar);
            this.panel1.Controls.Add(this.btnsolution);
            this.panel1.Controls.Add(this.btnhin);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Location = new System.Drawing.Point(13, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 141);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Location = new System.Drawing.Point(32, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 48);
            this.panel2.TabIndex = 9;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.ForeColor = System.Drawing.Color.Red;
            this.lb5.Location = new System.Drawing.Point(25, 377);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(0, 23);
            this.lb5.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pt1);
            this.panel3.Controls.Add(this.lb5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pntime);
            this.panel3.Location = new System.Drawing.Point(418, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 424);
            this.panel3.TabIndex = 11;
            // 
            // pt1
            // 
            this.pt1.BackColor = System.Drawing.Color.Transparent;
            this.pt1.Image = ((System.Drawing.Image)(resources.GetObject("pt1.Image")));
            this.pt1.Location = new System.Drawing.Point(0, 0);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(277, 421);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 0;
            this.pt1.TabStop = false;
            this.pt1.Visible = false;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing_1);
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.pntime.ResumeLayout(false);
            this.pntime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnhin;
        private System.Windows.Forms.TableLayoutPanel pn1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnsolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pntime;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pt1;
    }
}