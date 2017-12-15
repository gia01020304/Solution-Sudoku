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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }
        private int time;
        public int Time
        {
            get { return time; }
            set { time = value;
                txttime.Text = value.ToString();
                }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            BO.WriterPlayers("player.txt", txtname.Text, txttime.Text);
            MessageBox.Show("Lưu thành công", "Save");
            this.Close();
        }
    }
}
