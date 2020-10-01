using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_Final_Project
{
    public partial class SuvForm : Form
    {
        public SuvForm()
        {
            InitializeComponent();
        }
        //add button to add suv
        private void btnSuvAdd_Click(object sender, EventArgs e)
        {
            //validates for atleast one character has been entered
            bool validated = true;
            if (txtSuvMake.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles make.");
                validated = false;
            }
            if (txtSuvModel.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles model.");
                validated = false;
            }
            if (txtSuvDrive.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles drivetrain.");
                validated = false;
            }
            if (txtSuvEngine.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles engine.");
                validated = false;
            }
            if (txtSuvStyle.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles Bodystyle.");
                validated = false;
            }
            if (txtSuvSeats.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles seat count.");
                validated = false;
            }
            //closes if vlaidated
            if (validated)
            {
                this.Close();
            }
        }
    }
}
