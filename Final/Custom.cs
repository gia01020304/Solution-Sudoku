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
    public partial class Custom : Form
    {
        public Regex re = null;
        private int level;
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public Custom()
        {
            InitializeComponent();
            string pattern = @"[0-9]";
            re = new Regex(pattern);
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Match m = re.Match(tb.Text);
            if (!m.Success && tb.Text != "")
            {
                tb.Focus();
                tb.Text = "";
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtNum.Text) > 80)
            {
                MessageBox.Show("0-80");
            }
            else
            {
                level = Int32.Parse(txtNum.Text);
                this.Close();
            }
        }
    }
}
