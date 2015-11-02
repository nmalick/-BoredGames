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
    public partial class frmCheckers : Form
    {
        bool check;
        Point temp1 = new Point(0, 0);
        Point temp2 = new Point(0, 0);
        Button firstBtn;
        
        public frmCheckers()
        {
            InitializeComponent();
            check = false;
        }

        private void btn_SudokuGenerate_Click(object sender, EventArgs e)
        {
            btnCheckers2_2.Visible = true;
            btnCheckers2_4.Visible = true;
            btnCheckers4_2.Visible = true;
            btnCheckers4_4.Visible = true;
        }


        private void btnCheckers2_4_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                btnCheckers2_4.BackColor = System.Drawing.Color.Gray;
                firstBtn = btnCheckers2_4;
                temp1 = btnCheckers2_4.Location;
                return;
            }
                
            if (check == true)
            {
                btnCheckers2_4.BackColor = System.Drawing.Color.DarkRed;
                temp2 = btnCheckers2_4.Location;
                btnCheckers2_4.Location = temp1;
                firstBtn.Location = temp2;
                firstBtn.BackColor = System.Drawing.Color.DarkRed;
                check = false;
            }
        }

        private void btnCheckers2_2_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                btnCheckers2_2.BackColor = System.Drawing.Color.Gray;
                temp1 = btnCheckers2_2.Location;
                firstBtn = btnCheckers2_2;
                return;
            }

            if (check == true)
            {
                btnCheckers2_2.BackColor = System.Drawing.Color.DarkRed; 
                temp2 = btnCheckers2_2.Location;
                btnCheckers2_2.Location = temp1;
                firstBtn.Location = temp2;
                firstBtn.BackColor = System.Drawing.Color.DarkRed;
                check = false;

            }
        }

        private void btnCheckers4_2_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                btnCheckers4_2.BackColor = System.Drawing.Color.Gray;
                temp1 = btnCheckers4_2.Location;
                firstBtn = btnCheckers4_2;
                return;
            }

            if (check == true)
            {
                btnCheckers4_2.BackColor = System.Drawing.Color.DarkRed; 
                temp2 = btnCheckers4_2.Location;
                btnCheckers4_2.Location = temp1;
                firstBtn.Location = temp2;
                firstBtn.BackColor = System.Drawing.Color.DarkRed;
                check = false;

            }
        }

        private void btnCheckers4_4_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                check = true;
                btnCheckers4_4.BackColor = System.Drawing.Color.Gray;
                temp1 = btnCheckers4_4.Location;
                firstBtn = btnCheckers4_4;
                return;
            }

            if (check == true)
            {
                btnCheckers4_4.BackColor = System.Drawing.Color.DarkRed;
                temp2 = btnCheckers4_4.Location;
                btnCheckers4_4.Location = temp1;
                firstBtn.Location = temp2;
                firstBtn.BackColor = System.Drawing.Color.DarkRed;
                check = false;

            }
        }

        private void btnCheckersExit_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Do you want to save first?", "Exit", MessageBoxButtons.YesNoCancel);

            if (save == DialogResult.No)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();

            }
            else if (save == DialogResult.Yes)
            {
                //Save everything();
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
        }

        private void btnCheckersClear_Click(object sender, EventArgs e)
        {
            btnCheckers2_2.Visible = false;
            btnCheckers2_4.Visible = false;
            btnCheckers4_2.Visible = false;
            btnCheckers4_4.Visible = false;
        }
    }
}
