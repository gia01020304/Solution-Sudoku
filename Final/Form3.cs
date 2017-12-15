using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FormPlay : Form
    {
       
        private int[,] dapAn;
        private int[,] de;
        private int[,] continues;
        private int column;
        private int soluong;
        public Regex re = null;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }
        private int row;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        private int cap=9;
        private Sudoku player;
        public Sudoku Player
        {
            get { return player; }
            set { player = value; }
        }
       

        public int[,] DapAn { get; set; }

        public int[,] De { get; set; }

        public int[,] Continues
        {
            get
            {
                return continues;
            }

            set
            {
                continues = value;
            }
        }
        public FormPlay( Sudoku player1)
        {

            InitializeComponent();
            player = player1;
            de = player.Sdk;
            insertTextBox();
            pn1.Enabled = false;
            string pattern = @"[1-9]";
            re = new Regex(pattern);
        }





        /// <summary>
        /// Thêm các textBox vào panel
        /// </summary>
        public void insertTextBox()
        {

            for (int i = 0; i < cap; i++)
            {
                for (int j = 0; j < cap; j++)
                {
                    TextBox tb = new TextBox() { Height = 38, Width = 38 };
                    tb.Multiline = true;
                    tb.BackColor = Color.GhostWhite;
                    tb.TextAlign = HorizontalAlignment.Center;
                    tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb.MaxLength = 1;
                    tb.Click += ShowHints;
                    this.pn1.Controls.Add(tb, i, j);
                }
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void textchange(object sender, EventArgs e)
        {
           
            int i = 0;
            foreach (TextBox item in pn1.Controls)
            {
                if (item.Enabled==true&&item.Text=="")
                {
                    i++;
                }
            }
            TextBox tb = sender as TextBox;
            Match m = re.Match(tb.Text);
            if (!m.Success&&tb.Text!="")
            {
                tb.Focus();
                tb.Text = "";
                return;
            }
     
            txt2.Text = i.ToString();
        }

        private void An(object sender, EventArgs e)
        {
            btnhin.Enabled = false;
        }

        private void ShowHints(object sender, EventArgs e)
        {
            btnhin.Enabled = true;
            column = pn1.GetColumn((Control)sender);
            row = pn1.GetRow((Control)sender);
        }

        /// <summary>
        /// Vẽ các đường viền panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pn1_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 0;
            int r = pn1.GetControlFromPosition(0, 3).Top - pn1.GetControlFromPosition(0, 2).Bottom;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, pn1.Width, r);
            y = pn1.GetControlFromPosition(0, 2).Bottom;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, pn1.Width, r);
            y = pn1.GetControlFromPosition(0, 5).Bottom;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, pn1.Width, r);
            y = pn1.GetControlFromPosition(0, 8).Bottom;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, pn1.Width, r);

            x = 0;
            y = 0;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, r, pn1.Width);
            x = pn1.GetControlFromPosition(2, 0).Right;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, r, pn1.Width);
            x = pn1.GetControlFromPosition(5, 0).Right;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, r, pn1.Width);
            x = pn1.GetControlFromPosition(8, 0).Right;
            e.Graphics.FillRectangle(Brushes.CadetBlue, x, y, r, pn1.Width);
            x = 0;
            y = 0;
        
        }
        /// <summary>
        /// Đưa giá trị từ trong mảng sang các textBox
        /// </summary>
        /// <param name="M">Mảng cần đưa lên</param>
        private void insertvalue(int[,] M, Color a, int kt)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    TextBox textbox = (TextBox)pn1.GetControlFromPosition(j, i);
                    textbox.ForeColor = a;
                    if (kt == 1 && textbox.Enabled == true)
                    {
                        textbox.BackColor = Color.Lime;
                    }
                    if (kt == 0 && M[i, j] == 0)
                    {
                        textbox.TextChanged += textchange;
                    }
                    if (textbox.Enabled == true && textbox.Text != "" && int.Parse(textbox.Text) == M[i, j])
                    {
                        pn1.GetControlFromPosition(j, i).BackColor = Color.Yellow;
                    }
                    if (M[i, j] != 0)
                    {
                        textbox.Text = M[i, j].ToString();
                        if (kt == 0)
                            textbox.Enabled = false;
                    }

                }
            }
        }


        private void btnsolution_Click(object sender, EventArgs e)
        {
            insertvalue(dapAn, Color.Red, 1);
        }
        private void btnhin_Click(object sender, EventArgs e)
        {
            TextBox tb = pn1.GetControlFromPosition(column, row) as TextBox;

            if (string.Compare(tb.Text, dapAn[row, column].ToString()) == 0)
            {
                tb.BackColor = Color.Yellow;
            }
            else
            {
                tb.BackColor = Color.Lime;
                tb.Text = dapAn[row, column].ToString();
            }
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            btnsolution.Enabled = true;
            btnRemove.Enabled = true;
            btnhin.Enabled = true;
            player.DemSoLuong();
            if (btnhin.Enabled == true)
            {
                txt2.Text = player.Dem.ToString();
            }
            if (continues != null) Inputctn(continues);
            btnStar.Enabled = false;
            insertvalue(de, Color.DarkBlue, 0);
            player.Solution();
            dapAn = player.Sdk;
            pn1.Enabled = true;
            timer1.Start();
        }

        int x = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
            if (int.Parse(txt2.Text)==0)
            {
               
                x++;
                if (x==5)
                {
                    pt1.Visible = false;
                    timer1.Stop();
                }
            }
            int a = Int32.Parse(lb1.Text);
            int b = Int32.Parse(lb3.Text);
            b++;
            if (b > 59)
            {
                b = 0;
                a++;
            }
            if (b < 10) lb3.Text = "0" + b;
            else lb3.Text = b + "";
            if (a < 10) lb1.Text = "0" + a;
            else lb1.Text = a + "";
        }
        private void Inputctn(int[,] M)
        {
            int k = Int32.Parse(txt2.Text);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox textbox = (TextBox)pn1.GetControlFromPosition(i, j);
                    if (M[i, j * 2] != 0 && M[i, j * 2 + 1] == 1)
                    {
                        textbox.Text = M[i, j * 2] + "";
                        k--;
                    }
                }
            }
            lb1.Text = 99 - (M[9, 0] * 10 + M[9, 1]) + "";
            if (Int32.Parse(lb1.Text) < 10) lb1.Text = "0" + lb1.Text;
            lb3.Text = 60 - (M[9, 2] * 10 + M[9, 3]) + "";
            if (Int32.Parse(lb3.Text) < 10) lb3.Text = "0" + lb3.Text;
            txt2.Text = k + "";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lb5.Text = "";
            foreach (TextBox item in pn1.Controls)
            {
                if (item.Enabled == true)
                {
                    item.BackColor = Color.GhostWhite;
                    item.Text = "";
                }
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (btnStar.Enabled==true)
            {
                return;
            }
            TextBox tb = sender as TextBox;
            int kq = 1;
            int k = int.Parse(tb.Text);
            if (k==0)
            {
                for (int i = 0; i < cap; i++)
                {
                    for (int j = 0; j < cap; j++)
                    {
                        TextBox tb1 = pn1.GetControlFromPosition(j,i) as TextBox;
                        if (int.Parse(tb1.Text)!=dapAn[i,j])
                        {
                            kq = 0;
                            lb5.ForeColor = Color.Red;
                            lb5.Text = "Sai";
                            break;
                        }
                    }
                }
                if (kq == 1)
                {
                    lb5.Text = "Hoàn Thành";
                    lb5.ForeColor = Color.Lime;
                    timer1.Stop();
                    timer1.Start();
                    pt1.Visible = true;
      
                }
            }

            
            

        }
        private void ctn()
        {
            continues = new int[10, 18];
            int i = 0, j = 0;
            foreach (TextBox item in pn1.Controls)
            {
                if (j == 18)
                {
                    j = 0;
                    i++;
                }
                if (i < 9)
                {
                    if (item.Text == "") continues[i, j++] = 0;
                    else continues[i, j++] = Int32.Parse(item.Text);
                    if (item.Enabled == true) continues[i, j++] = 1;
                    else continues[i, j++] = 0;
                }
            }
            continues[9, 0] = 99 - Int32.Parse(lb1.Text);
            continues[9, 1] = 60 - Int32.Parse(lb3.Text);
        }
        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (txt2.Text != 0.ToString())
            {
                pn1.Visible = false;
                DialogResult result = MessageBox.Show("Save Game ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //ghifile      
                    ctn();
                    BO.Ghimang("continutes.txt", continues);
                    Environment.Exit(1);
                }


            }
            else
            {

                FormInfo f4 = new FormInfo();
                f4.Location = new Point(this.Location.X + (this.Width - f4.Width), this.Location.Y + (this.Height - f4.Height));
                int time = int.Parse(lb1.Text) * 60 + int.Parse(lb3.Text);
                f4.Time = time;
                f4.ShowDialog();

            }
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {

        }
    }
}
