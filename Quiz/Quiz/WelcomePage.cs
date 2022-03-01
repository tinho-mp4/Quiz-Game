using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Welcome : Form
    {
        /// <summary>
        /// A welcome page with a start button and an exit button
        /// </summary>
        /// 
        string userName; //The user's name


        public Welcome()
        {
            InitializeComponent();
            userName = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exiting the program
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name","Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Taking the user's name to the question form
                string user = txtName.Text;
                new Results(0, user);

                Question1 openForm = new Question1(0, user);
                openForm.Show();
                Visible = false;


            }
        }


    }
}
