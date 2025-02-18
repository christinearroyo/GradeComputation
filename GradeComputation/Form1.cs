using System;
using System.Windows.Forms;

namespace GradeComputation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            
            double midtermQ = Convert.ToInt32(txtMidtermQ.Text);
            double midtermExam = Convert.ToInt32(txtMidtermExam.Text);
            double midtermCS = Convert.ToInt32(txtMidtermCS.Text);

            double finalsQ = Convert.ToInt32(txtFinalsQ.Text);
            double finalsExam = Convert.ToInt32(txtFinalsExam.Text);
            double finalsCS = Convert.ToInt32(txtFinalsCS.Text);

            if (midtermQ < 50 || midtermExam < 50 || midtermCS < 50 || finalsQ < 50 || finalsExam < 50 || finalsCS < 50)
            {
                MessageBox.Show("50 is the minimum value for each text box");
                return;
            }

            double midtermGrade = (0.40 * midtermQ) + (0.40 * midtermExam) + (0.20 * midtermCS);
            double finalsGrade = (0.40 * finalsQ) + (0.40 * finalsExam) + (0.20 * finalsCS);
            double semGrade = (midtermGrade + finalsGrade) / 2;

            string letterGrade;

            if (semGrade >= 91)
            {
                letterGrade = "A";
                lblEquivGrade.Text = letterGrade;
            }
            else if (semGrade >= 86 && semGrade <= 90)
            {
                letterGrade = "B";
                lblEquivGrade.Text = letterGrade;
            }
            else if (semGrade >= 81 && semGrade <= 85)
            {
                letterGrade = "C";
                lblEquivGrade.Text = letterGrade;
            }
            else if (semGrade >= 75 && semGrade <= 80)
            {
                letterGrade = "D";
                lblEquivGrade.Text = letterGrade;
            }
            else
            {
                letterGrade = "F";
                lblEquivGrade.Text = letterGrade;
            }

            lblSemGrade.Text = semGrade.ToString();
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Hidden secret = new Hidden();
            secret.Show();
        }
    }
}
