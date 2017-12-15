using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FormScore : Form
    {
        List<player> pl = null;
        public FormScore()
        {
            InitializeComponent();
            pl = new List<player>();
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BO.ReadPlayers("player.txt", pl);
            int k = 0;
            int j = 0;

            while (j < pl.Count * 2)
            {
                Label lb = new Label();
                lb.Width = 100;
                lb.Height = 50;
                lb.AutoSize = false;
                if (j % 2 == 0)
                {
                    lb.Text = pl[k].Name;

                }
                else
                {
                    lb.TextAlign = ContentAlignment.TopRight;
                    lb.Text = pl[k].Time.ToString() + " s";
                    k++;
                }
                fpn1.Controls.Add(lb);
                j++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            fpn1.Controls.Add(bt);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.Width = 150;
            lb.Height = 50;
            lb.AutoSize = false;
            lb.BackColor = Color.DarkBlue;
            fpn1.Controls.Add(lb);
        }
    }
}
