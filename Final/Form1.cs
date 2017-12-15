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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Sudoku sdk;
        private int[,] continues;

        public Sudoku Sdk
        {
            get
            {
                return sdk;
            }

            set
            {
                sdk = value;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BO.Delete("continutes.txt");
            this.Hide();
            sdk = new Sudoku();
            FormLevel f2 = new FormLevel(sdk);
            f2.ShowDialog();
            this.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            FormScore f5 = new FormScore();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void btnConti_Click(object sender, EventArgs e)
        {
            sdk = new Sudoku(continues);
            FormPlay f3 = new FormPlay(sdk);
            f3.Continues = continues;
            this.Hide();
            f3.ShowDialog();
            this.Show();
            this.Refresh();


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            continues = new int[10, 18];
            if (BO.DocMang("continutes.txt", continues) == 0) btnConti.Enabled = false;
        }
    }
}
