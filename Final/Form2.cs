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
    public partial class FormLevel : Form
    {
        FormPlay f3 = null;
        private Sudoku player;

        public FormLevel(Sudoku players)
        {
            InitializeComponent();
            player = players;
        }
   
        public Sudoku Player
        {
            get { return player; }
            set { player = value; }
        }
        private void click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            int level = 0;
            switch (a.Text)
            {
                case "Easy":
                    level = 1;
                    break;
                case "Medium":
                    level = 2;
                    break;
                case "Difficult":
                    level = 3;
                    break;
                case "Hard":
                    level = 3;
                    break;
                case "Evil":
                    level = 5;
                    break;
                default:
                    level = 1;
                    break;

            }
            this.Hide();
            player.Level = level;
            f3 = new FormPlay(player);
            f3.Player.Remove();
            f3.ShowDialog();
            this.Show();
            player = new Sudoku();

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            Custom cs = new Custom();
            cs.ShowDialog();
            int level = 80 - cs.Level;
            this.Hide();
            player.Level = level;
            f3 = new FormPlay(player);
            f3.Player.Remove();
            f3.ShowDialog();
            this.Show();
            player = new Sudoku();
        }
    }
}
