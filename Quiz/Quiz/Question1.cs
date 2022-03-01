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
    /// <summary>
    /// quiz game that has functioning buttons
    /// </summary>



    public partial class Question1 : Form
    {
        //Declare Variable
        int CorrectAnswer;   // Calculated here
        int qnumber = 1;    // Questions
        int score;         // The score totaling up
        int totalQuestion;// The total amount of question
        string userName; // Storing user's name to go to results


        public Question1(int results, string user)
        {
            InitializeComponent();
            Questions_asked(qnumber);
            totalQuestion = 5;

            userName = user;
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            //Check Answers
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == CorrectAnswer)
            {
                score++;
            }
            //Open the results for the total
            if (qnumber == totalQuestion)
            {


                DialogResult Next;
                Next = MessageBox.Show("Confirm you want to Submit", "Submit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Next == DialogResult.Yes)
                {
                    int results = score;
                    Results openForm = new Results(results, userName);
                    openForm.Show();
                    Visible = false;
                }

                //Calculate score

                score = 0;
                qnumber = 0;
                Questions_asked(qnumber);
            }
            qnumber++;
            Questions_asked(qnumber);
        }

            private void Questions_asked(int qnum)
            {
                //Quiz with pictures and answers 
                
                switch (qnum)
                {
                    //First Question
                    case 1:
                        pictureBox1.Image = Properties.Resources.Question_1;
                        lblQuestion1.Text = "Which data type stores only whole numbers?";
                        btn1.Text = "string";
                        btn2.Text = "int";
                        btn3.Text = "double";
                        btn4.Text = "char";
                        CorrectAnswer = 2;
                        break;

                    //Second Question
                    case 2:
                        pictureBox1.Image = Properties.Resources.Question_2;
                        lblQuestion1.Text = "What is the correct way to create an object called myObj of MyClass?";
                        btn1.Text = "class MyClass = new myObj();";
                        btn2.Text = "new myObj = MyClass();";
                        btn3.Text = "class myObj = new MyClass();";
                        btn4.Text = "MyClass my Obj = new MyClass();";
                        CorrectAnswer = 4;
                        break;

                    //Third Question
                    case 3:
                        pictureBox1.Image = Properties.Resources.Question_3;
                        lblQuestion1.Text = "What is a correct syntax to output “Hello World” in C#?";
                        btn1.Text = "cout << \"Hello World\";";
                        btn2.Text = "When the programmer assigns the value if not an error will occur";
                        btn3.Text = "System.out.printIn(\"Hello World\");";
                        btn4.Text = "Console.WriteLine (\"Hello World\");";
                        CorrectAnswer = 4;
                        break;

                    //Fourth Question
                    case 4:
                        pictureBox1.Image = Properties.Resources.Question_4;
                        lblQuestion1.Text = "Array indexes start with: ";
                        btn1.Text = "1";
                        btn2.Text = "0";
                        btn3.Text = "3";
                        btn4.Text = "2";
                        CorrectAnswer = 2;
                        break;

                    //Fifth Question
                    case 5:
                        pictureBox1.Image = Properties.Resources.Question_5;
                        lblQuestion1.Text = "How do you start writing a while loop in C#?";
                        btn1.Text = "x > y while {";
                        btn2.Text = "white x >y {";
                        btn3.Text = "while (x > y)";
                        btn4.Text = "while x > y: ";
                        CorrectAnswer = 3;
                        break;
                }
            }

        private void btnReturnS_Click(object sender, EventArgs e)
        {
            Welcome openForm = new Welcome();
            openForm.Show();
            Visible = false;
        }
    }
}