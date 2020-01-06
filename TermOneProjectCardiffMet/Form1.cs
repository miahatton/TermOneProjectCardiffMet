using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;

namespace TermOneProjectCardiffMet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // WEB BROWSER COMPONENTS
        //Navigate to page on GO click 
        private void btnGo_Click(object sender, EventArgs e)
        {
            string WebPage = webAddressBox.Text.Trim();

            //TODO troubleshoot browser with different urls
            //TODO add google search when a space is present

            if(WebPage.Contains(" "))
            {
                string GoogleSearch = "https://www.ecosia.org/search?q=";
                string[] searchTerms = WebPage.Split(' ');
                WebPage = GoogleSearch + string.Join("+", searchTerms);
            }


            webBrowser1.Navigate(WebPage);
            browserHistory.Items.Add(WebPage);

        }
        private void webAddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
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
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (!browserHistory.Visible)
            {
                browserHistory.Visible = true;
            } else
            {
                browserHistory.Visible = false;
            }
            
        }

        private void browserHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string url = browserHistory.GetItemText(browserHistory.SelectedItem);
            webAddressBox.Text = url;
            webBrowser1.Navigate(url);
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

        char currentOperator;

        // btnClicked tracks whether an operator has already been used
        bool btnClicked = false;
        bool divError = false;

        // assign variables to store numbers
        int total1;
        int total2;

        //Check that we are not dividing by zero every time / is used. if so, provide simple explanation.
        private bool dontDivideByZero(int num1, int num2)
        {
            if (num2 == 0)
            {
                string message = $"You can't divide by zero. Imagine trying to share {num1} apples between zero people. How many apples would each person get? There is no answer!";
                MessageBox.Show(message);
                return false;
            } else {
                return true;
                    }
        }

        private void resetCalculator()
        {
            // reset all values to use calculator again.
            btnClicked = false;
            total1 = 0;
            total2 = 0;
            calcHistory.Text += System.Environment.NewLine;
            CalcDisplay.Clear();
        }

        private int multiOpCalculate(int num, char Operator)
        {
            switch (Operator)
            {
                case '+':
                    return num + int.Parse(CalcDisplay.Text);
                case '-':
                    return num - int.Parse(CalcDisplay.Text);
                case '*':
                    return num * int.Parse(CalcDisplay.Text);
                case '/':
                    if (dontDivideByZero(num, int.Parse(CalcDisplay.Text)))
                    {
                        return num / int.Parse(CalcDisplay.Text);
                    }
                    else
                    {
                        divError = true;
                        return 0;
                    }
                default:
                    // No paths should lead here! If we get here something has gone very wrong.
                    return 0;
            } // end switch statement
        }

        private void calcBtnPlus_Click(object sender, EventArgs e)
        {
            calcHistory.Text += CalcDisplay.Text + " + ";
            if (!btnClicked)
            {
                total1 += int.Parse(CalcDisplay.Text);
            } else
            {
                total1 = multiOpCalculate(total1, currentOperator);
            }
            if (!divError)
            {
                CalcDisplay.Clear();
                btnClicked = true;
                currentOperator = '+';
            } else
            {
                calcHistory.Text += "= error ";
                resetCalculator();
            }
            
        }
        private void calcBtnMinus_Click(object sender, EventArgs e)
        {
            calcHistory.Text += CalcDisplay.Text + " - ";
            if (!btnClicked)
            {
                total1 += int.Parse(CalcDisplay.Text);
            }
            else
            {
                total1 = multiOpCalculate(total1, currentOperator);
            }
            if (!divError)
            {
                CalcDisplay.Clear();
                btnClicked = true;
                currentOperator = '-';
            } else
            {
                calcHistory.Text += "= error ";
                resetCalculator();
            }
            
        }

        private void calcBtnMultiply_Click(object sender, EventArgs e)
        {
            calcHistory.Text += CalcDisplay.Text + " x ";
            if (!btnClicked)
            {
                total1 += int.Parse(CalcDisplay.Text);
            }
            else
            {
                total1 = multiOpCalculate(total1, currentOperator);
            }
            if (!divError)
            {
                CalcDisplay.Clear();
                btnClicked = true;
                currentOperator = '*';
            } else
            {
                calcHistory.Text += "= error ";
                resetCalculator();
            }
            
        }
        private void calcBtnDivide_Click(object sender, EventArgs e)
        {
            calcHistory.Text += CalcDisplay.Text + " ÷ ";
            if (!btnClicked)
            {
                total1 += int.Parse(CalcDisplay.Text);
            }
            else
            {
                total1 = multiOpCalculate(total1, currentOperator);
            }
            if (!divError)
            {
                CalcDisplay.Clear();
                btnClicked = true;
                currentOperator = '/';
            } else
            {
                calcHistory.Text += "= error ";
                resetCalculator();
            }
            
        }

        private void calcBtnEquals_Click(object sender, EventArgs e)
        {
            // TODO
            // When exception is thrown calculator doesn't seem to work anymore.
            try
            {
                int.Parse(CalcDisplay.Text);

                calcHistory.Text += CalcDisplay.Text + " = ";
                switch (currentOperator)
                {

                    case '+':
                        total2 = total1 + int.Parse(CalcDisplay.Text);
                        calcHistory.Text += CalcDisplay.Text;
                        break;
                    case '-':
                        total2 = total1 - int.Parse(CalcDisplay.Text);
                        calcHistory.Text += CalcDisplay.Text;
                        break;
                    case '*':
                        total2 = total1 * int.Parse(CalcDisplay.Text);
                        calcHistory.Text += CalcDisplay.Text;
                        break;
                    case '/':
                        if (dontDivideByZero(total1, int.Parse(CalcDisplay.Text)))
                        {
                            total2 = total1 / int.Parse(CalcDisplay.Text);
                            calcHistory.Text += CalcDisplay.Text;
                        }
                        else
                        {
                            CalcDisplay.Clear();
                            calcHistory.Text += " error ";
                        }
                        break;
                    default:
                        total2 = int.Parse(CalcDisplay.Text);
                        calcHistory.Text += CalcDisplay.Text;
                        break;

                } // end switch statement

                resetCalculator();
            } catch (FormatException ex)
            {
                MessageBox.Show("You need to enter another number");
            }

            
        }

        private void calcBtnClear_Click(object sender, EventArgs e)
        {
            resetCalculator();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calcHistory.Clear();
        }

        //Just for fun - a random sum generator
        private void btnIdeaGenerator_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] operators = new string[4] {" + ", " - ", " x ", " ÷ "};
            ideaBox.Text = "What is " + rand.Next(100).ToString() + operators[rand.Next(4)] + rand.Next(100).ToString() + '?';
            CalcDisplay.Clear();
        }


        // TEXT EDITOR
        // Change font family.
        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = fontList.GetItemText(fontList.SelectedItem);
            richTextBox.Font = new Font(fontName, richTextBox.Font.Size);
        }
        //change colour

        private void backColor1_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor1.BackColor;
        }

        private void backColor2_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor2.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor3.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor4.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor5.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor6.BackColor;
        }

        private void textColor1_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor1.BackColor;
        }

        private void textColor2_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor2.BackColor;
        }

        private void textColor3_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor3.BackColor;
        }

        private void textColor4_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor4.BackColor;
        }

        private void textColor5_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor5.BackColor;
        }

        private void textColor6_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = textColor6.BackColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox.Font = new Font(richTextBox.Font.FontFamily, trackBar1.Value);
        }

        string filename;

        private void Button17_Click(object sender, EventArgs e)
        {
            // background colour does not save so if text is white (button 1), change it to black (button 6) when saving.
            if (richTextBox.ForeColor == backColor1.BackColor)
            {
                richTextBox.ForeColor = backColor6.BackColor;
                // if the background is black the text won't show up any more. Change bg to white to avoid confusion.
                if (richTextBox.BackColor == backColor6.BackColor)
                {
                    richTextBox.BackColor = backColor1.BackColor;
                }
            }
            
            // Consider a try/except in case my documents does not exist.
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "Save your writing";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|All Files|*.*";

            if(saveFileDialog.ShowDialog() != DialogResult.Cancel) {
                filename = saveFileDialog.FileName;
                richTextBox.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Open a file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Rich Text Files|*.rtf";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnRandomStyle_Click(object sender, EventArgs e)
        {
            //TODO randomise style 
        }

        private void btnWritingPrompt_Click(object sender, EventArgs e)
        {
            //TODO add writing prompts
        }
    }
}
