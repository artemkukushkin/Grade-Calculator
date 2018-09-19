using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmLetterGrade : Form
    {
        public frmLetterGrade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLetterGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text); //the text entered into the textbox gets converted to a number
            string letterGrade = ""; //this acts as a text (string) dimension, I could place an F in these quotations and eliminate the last ELSE

            if (numberGrade >= 88) //the following statements generate different outputs (stored in letterGrade) for different inputs
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "C";
            }
            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade; //preloaded lettergrade is displayed in the Read-Only textbox
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //one thing to note is that there is a runtime error if the input field left blank
        }
    }
}