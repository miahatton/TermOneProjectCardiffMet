using System;
using System.Windows.Forms;

namespace TermOneProjectCardiffMet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // WEB BROWSER COMPONENTS

        //TODO set up web browsing history.

        private void btnGo_Click(object sender, EventArgs e)
        {
            string WebPage = webAddressBox.Text.Trim();

            webBrowser1.Navigate(WebPage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clicking back button - web browser goes back if there is a page to go to
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clicking forward button - web browser goes back if there is a page to go to
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //clicking refresh button - webpage refreshes
            webBrowser1.Refresh();
        }

        //CALCULATOR COMPONENTS

        private void calcBtn1_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 1;
        }

        private void calcBtn2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 2;
        }

        private void calcBtn3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 3;
        }

        private void calcBtn4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 4;
        }

        private void calcBtn5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 5;
        }

        private void calcBtn6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 6;
        }

        private void calcBtn7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 7;
        }

        private void calcBtn8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 8;
        }

        private void calcBtn9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 9;
        }

        private void calcBtn0_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += 0;
        }

        private void calcBtnPoint_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += '.';
        }

        // Clicking operator buttons will set value of currentOperator to one of +,-,/ or *

        char currentOperator = 'n';

        // assign variables to store numbers
        int total1 = 0;
        int total2;

        private void calcBtnPlus_Click(object sender, EventArgs e)
        {
            currentOperator = '+';
            calcHistory.Text += CalcDisplay.Text + " + ";
            total1 += int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }
        private void calcBtnMinus_Click(object sender, EventArgs e)
        {
            currentOperator = '-';
            calcHistory.Text += CalcDisplay.Text + " - ";
            total1 += int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void calcBtnMultiply_Click(object sender, EventArgs e)
        {
            currentOperator = '*';
            calcHistory.Text += CalcDisplay.Text + " x ";
            total1 += int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }
        private void calcBtnDivide_Click(object sender, EventArgs e)
        {
            currentOperator = '/';
            calcHistory.Text += CalcDisplay.Text + " ÷ ";
            total1 += int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void calcBtnEquals_Click(object sender, EventArgs e)
        {
            calcHistory.Text += CalcDisplay.Text + " = ";
            switch (currentOperator)
            {
                case '+':
                    total2 = total1 + int.Parse(CalcDisplay.Text);
                    CalcDisplay.Text = total2.ToString();
                    calcHistory.Text += CalcDisplay.Text + "\n";
                    break;
                case '-':
                    total2 = total1 - int.Parse(CalcDisplay.Text);
                    CalcDisplay.Text = total2.ToString();
                    calcHistory.Text += CalcDisplay.Text + "\n";
                    break;
                case '*':
                    total2 = total1 * int.Parse(CalcDisplay.Text);
                    CalcDisplay.Text = total2.ToString();
                    calcHistory.Text += CalcDisplay.Text + "\n";
                    break;
                case '/':
                    total2 = total1 / int.Parse(CalcDisplay.Text);
                    CalcDisplay.Text = total2.ToString();
                    calcHistory.Text += CalcDisplay.Text + "\n";
                    break;
                default:
                    total2 = int.Parse(CalcDisplay.Text);
                    CalcDisplay.Text = total2.ToString();
                    calcHistory.Text += CalcDisplay.Text + "\n";
                    break;
            } // end switch statement

            total1 = 0;
            calcHistory.Text += System.Environment.NewLine;
        }

        private void calcBtnClear_Click(object sender, EventArgs e)
        {
            total1 = 0;
            CalcDisplay.Clear();
        }
    }
}
