using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class btnSubtract : Form
    {
        public btnSubtract()
        {
            InitializeComponent();
        }
        //Button Clicks that are sent to text box for display
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonCLicked = false;

            txtDisplay.Clear();
        }

        //Global Scope
        double total1 = 0;

        double total2 = 0;

        String theOperator;
        
        //Add Button
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "+";
            txtDisplay.Clear();     
        }
        //Equals button boolean to check to see what button was clicked//
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;

            num2 = double.Parse(txtDisplay.Text);

            switch (theOperator)
            {
                case "+" :
                    answer = total1 + num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-" :
                    answer = total1 - num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "*" :
                    answer = total1 * num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "/" :
                    answer = total1 / num2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                default :
                    answer = 0;
                    break;
            }
        }
        //Period Button
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPeriod.Text;
        }

        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonCLicked = false;
        bool divideButtonClicked = false;

        //Subtract Button
        private void button1_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "-";
            txtDisplay.Clear();        
            
        }
        //Multiply Button
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "*";
            txtDisplay.Clear();

        }
        //Divide Button
        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "/";
            txtDisplay.Clear();
           
        }
    }
}
