using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoredGames
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            frmSudoku sudoku = new frmSudoku();
            sudoku.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnChess_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckers_Click(object sender, EventArgs e)
        {
            frmCheckers checkers = new frmCheckers();
            checkers.Show();
            this.Hide();
        }
    }
}
