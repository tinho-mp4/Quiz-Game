using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Quiz
{
    public partial class Results : Form
    {
        /// <summary>
        /// A result page with a save button, exit button, and return to start button
        /// </summary>
        string userName;

        public Results(int results, string user)
        {
            InitializeComponent();
            //Calculating the score
            int percentage = (int)Math.Round((double)(results * 100) / 5);
            
            //Displaying the score
            lblper.Text = percentage.ToString()+ " %";
            lblScore.Text = results.ToString() + " /5";

            userName = user;
            lblName.Text = userName;



        }
        private void btnSave_Click(object sender, EventArgs c)
        {
            // Storing results and name in a text file
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\results\\" + "results.txt");

            A.WriteLine(lblscr.Text + ": " + " " + lblScore.Text);
            A.WriteLine(lblpert.Text + ": " + " " + lblper.Text);
            A.WriteLine("Name: " + " " + lblName.Text);

            A.Close();

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            // The reset question
            Question1 openForm = new Question1(0, userName);
            openForm.Show();
            Visible = false;
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Welcome openForm = new Welcome();
            openForm.Show();
            Visible = false;
        }
    }
}
