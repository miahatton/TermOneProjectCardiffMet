using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;


namespace TermOneProjectCardiffMet
{
    public partial class KidsToolBox : Form
    {
        // Instantiate random number generator (used in calculator and text editor idea prompts)
        Random rand = new Random();

        public KidsToolBox()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The window maximises when web browser is selected for optimal view.
            if (tabControl1.SelectedIndex == 1)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        // WELCOME SCREEN

        // clicking one of the buttons changes the selected tab on the TabControl
        private void btnBrowseWeb_Click(object sender, EventArgs e)
        {
            // Select webBrowser tab
            tabControl1.SelectTab(1);
        }

        private void btnPlayNumbers_Click(object sender, EventArgs e)
        {
            // Select calculator tab
            tabControl1.SelectTab(2);
        }

        private void btnWriteStory_Click(object sender, EventArgs e)
        {
            // Select textEditor tab
            tabControl1.SelectTab(3);
        }

        // WEB BROWSER

        private void btnGo_Click(object sender, EventArgs e)
        {
            //Navigate to page on GO click 

            // Get text from web address box and trim
            string url = webAddressBox.Text.Trim();

            // if there is a space in the address bar, do a search on Ecosia.org for the text
            if(url.Contains(" "))
            {
                // create url of ecosia search
                string ecosiaSearch = "https://www.ecosia.org/search?q=";
                // split text into separate words
                string[] searchTerms = url.Split(' ');
                // join words with + and add to end of url
                url = ecosiaSearch + string.Join("+", searchTerms);
            }

            webBrowser1.Navigate(url);
        }

        private void webAddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            // add return key shortcut to address bar so that user doesn't have to click Go button

            // if user presses return key in address bar, perform go button click action.
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Clicking back button - web browser goes back if there is a page to go to
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            // Clicking forward button - web browser goes forward if there is a page to go to
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // add keyboard shortcut to go back on pressing backspace
            if (e.KeyCode == Keys.Back)
            {
                btnBack.PerformClick();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //clicking refresh button - webpage refreshes
            webBrowser1.Refresh();
        }

        // Broswer history

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // toggle the browser history
            if (!browserHistory.Visible)
            {
                browserHistory.Visible = true;
                btnCloseBrowserHistory.Visible = true;
            } else
            {
                browserHistory.Visible = false;
                btnCloseBrowserHistory.Visible = false;
            }
        }
        private void btnCloseBrowserHistory_Click(object sender, EventArgs e)
        {
            // Add an extra, more obvious button to close browser history.
            browserHistory.Visible = false;
            btnCloseBrowserHistory.Visible = false;
        }

        private void browserHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // navigate to item in browser history on click

            // get address from broswerHistory list
            string url = browserHistory.GetItemText(browserHistory.SelectedItem);
            // navigate to address
            webBrowser1.Navigate(url);
            // close broswer history so that page is clearly visible
            browserHistory.Visible = false;
            btnCloseBrowserHistory.Visible = false;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // when the web broswer navigates to a page, add the address to the broswer history and to the address bar.
            webAddressBox.Text = webBrowser1.Url.ToString();
            browserHistory.Items.Add(webBrowser1.Url.ToString());
        }

        // Broswer help panel
        private void btnHelpBrowser_Click(object sender, EventArgs e)
        {
            // If the user doesn't understand the controls they can click the help icon to show the help panel with instructions.
            if (helpPanelBrowser.Visible == false)
            {
                helpPanelBrowser.Visible = true;
            } else
            {
                // if the help panel is already visible, clicking the icon hides it
                helpPanelBrowser.Visible = false;
            }
        }

        private void btnCloseHelpBrowser_Click(object sender, EventArgs e)
        {
            // Clicking the 'close help' button hides the help panel.
            helpPanelBrowser.Visible = false;
        }

        //CALCULATOR COMPONENTS


        // all number buttons add that number to the calcDisplay text box
        private void calcBtn1_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 1;
        }

        private void calcBtn2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 2;
        }

        private void calcBtn3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 3;
        }

        private void calcBtn4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 4;
        }

        private void calcBtn5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 5;
        }

        private void calcBtn6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 6;
        }

        private void calcBtn7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 7;
        }

        private void calcBtn8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 8;
        }

        private void calcBtn9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 9;
        }

        private void calcBtn0_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += 0;
        }

        // Clicking operator buttons will set value of currentOperator to one of +,-,/ or *
        char currentOperator;

        // btnClicked tracks whether an operator has already been used
        bool btnClicked = false;
        // divError tracks whether an attempt to divide by zero has been made
        bool divError = false;

        // assign variable to store first number - value is updated if multiple operators are used
        int total;

        private bool dontDivideByZero(int num1, int num2)
        {
            //Check that we are not dividing by zero every time 'num1/num2' is attempted. if so, provide simple explanation.
            if (num2 == 0)
            {
                // explain why you can't divide by zero
                string message = $"You can't divide by zero. Imagine trying to share {num1} apples between zero people. How many apples would each person get? There is no answer!";
                MessageBox.Show(message);
                // set divError to true on return
                return false;
            } else {
                // set divError to false on return
                return true;
                    } // end if/else statement
        }

        private void resetCalculator()
        {
            // reset all values to use calculator again.
            btnClicked = false;
            total = 0;
            calcDisplay.Clear();
            // add new line to calculator history
            calcHistory.Text += System.Environment.NewLine;
        }

        private void setTotal()
        {
            // Set up try/catch statement to be called whenever operator is clicked for the first time, to check that a number has been entered
            try
            {
                // update the value of total to be the value in the calcDisplay box
                total = int.Parse(calcDisplay.Text);
                btnClicked = true;
            } catch
            {
                // if there is no value in the calcDisplay box, ask user to enter a number
                MessageBox.Show("You need to enter a number first.");
            }
        }

        private int multiOpCalculate(int num, char Operator)
        {
            // if multiple operators are used in a single calculation, total will be updated each time a new operator is pressed.
            switch (Operator)
            {
                // perform addition, subtraction, multiplication or division
                case '+':
                    return num + int.Parse(calcDisplay.Text);
                case '-':
                    return num - int.Parse(calcDisplay.Text);
                case '*':
                    return num * int.Parse(calcDisplay.Text);
                case '/':
                    if (dontDivideByZero(num, int.Parse(calcDisplay.Text)))
                    {
                        return num / int.Parse(calcDisplay.Text);

                    }
                    else
                    {
                        divError = true;
                        return 0;
                    }
                default:
                    // No paths should lead here! If we get here something has gone very wrong.
                    MessageBox.Show("Something surprising has happened!");
                    return 0;
            } // end switch statement
        }

        private void calcBtnPlus_Click(object sender, EventArgs e)
        {
            // add the number and "+" to calculator history
            calcHistory.Text += calcDisplay.Text + " + ";
            if (!btnClicked)
            {
                // if this is the first time an operator has been used in the current calculation, set the value of total to be the number on the screen
                setTotal();
            } else
            {
                // otherwise, perform the PREVIOUS operation on the current number to give the new value of total
                total = multiOpCalculate(total, currentOperator);
            }
            //check for division errors
            if (!divError)
            {
                // clear display
                calcDisplay.Clear();
                // set current operator
                currentOperator = '+';
            } else
            {
                // if there was a divison error update calculator history and reset calculator
                calcHistory.Text += " = error ";
                resetCalculator();
            }
            
        }
        private void calcBtnMinus_Click(object sender, EventArgs e)
        {
            // add the number and "-" to calculator history
            calcHistory.Text += calcDisplay.Text + " - ";
            if (!btnClicked)
            {
                // if this is the first time an operator has been used in the current calculation, set the value of total to be the number on the screen
                setTotal();
            }
            else
            {
                // otherwise, perform the PREVIOUS operation on the current number to give the new value of total
                total = multiOpCalculate(total, currentOperator);
            }
            //check for division errors
            if (!divError)
            {
                // clear display and set current operator
                calcDisplay.Clear();
                currentOperator = '-';
            } else
            {
                // if there was a divison error update calculator history and reset calculator
                calcHistory.Text += " = error ";
                resetCalculator();
            }
            
        }

        private void calcBtnMultiply_Click(object sender, EventArgs e)
        {
            // add the number from the screen and "x" to the calculator history
            calcHistory.Text += calcDisplay.Text + " x ";
            if (!btnClicked)
            {
                // if this is the first time an operator has been used in the current calculation, set the value of total to be the number on the screen
                setTotal();
            }
            else
            {
                // otherwise, perform the PREVIOUS operation on the current number to give the new value of total
                total = multiOpCalculate(total, currentOperator);
            }
            // check for division errors
            if (!divError)
            {
                // clear display and set current operator
                calcDisplay.Clear();
                currentOperator = '*';
            } else
            {
                // if there was a divison error update calculator history and reset calculator
                calcHistory.Text += " = error ";
                resetCalculator();
            }
            
        }
        private void calcBtnDivide_Click(object sender, EventArgs e)
        {
            calcHistory.Text += calcDisplay.Text + " ÷ ";
            if (!btnClicked)
            {
                // if this is the first time an operator has been used in the current calculation, set the value of total to be the number on the screen
                setTotal();
            }
            else
            {
                // otherwise, perform the PREVIOUS operation on the current number to give the new value of total
                total = multiOpCalculate(total, currentOperator);
            }
            // check for division errors
            if (!divError)
            {
                // clear calculator display and set current operator
                calcDisplay.Clear();
                currentOperator = '/';
            } else
            {
                // if there was a divison error update calculator history and reset calculator
                calcHistory.Text += " = error ";
                resetCalculator();
            }
            
        }

        private void calcBtnEquals_Click(object sender, EventArgs e)
        {
            /* EQUALS BUTTON
             * Calculation is placed within a try/catch in case a user 
             * tries to enter " num x = " 
             * This will throw a format error because there will 
             * be no text on the screen for int.Parse() 
             */

            try
            {
                // is there a number on the screen?
                int.Parse(calcDisplay.Text);

                // add number and " = " to calculator history
                calcHistory.Text += calcDisplay.Text + " = ";

                // perform operation based on most recent operator button clicked.
                // for each operation, the answer is displayed in the calculator history box.
                switch (currentOperator)
                {
                    case '+':
                        // add numbers together
                        calcHistory.Text += (total + int.Parse(calcDisplay.Text));
                        break;
                    case '-':
                        // subtract number on screen from saved total
                        calcHistory.Text += (total - int.Parse(calcDisplay.Text));
                        break;
                    case '*':
                        // multiply numbers together
                        calcHistory.Text += (total * int.Parse(calcDisplay.Text));
                        break;
                    case '/':
                        // check for possible division errors
                        if (dontDivideByZero(total, int.Parse(calcDisplay.Text)))
                        {
                            // divide saved number total by number on screen.
                            calcHistory.Text += (total / int.Parse(calcDisplay.Text));
                            if (total % int.Parse(calcDisplay.Text) != 0)
                            {
                                // if this is the final calculation, add the remainder of the division to the screen. Decimals are not introduced until KS2
                                calcHistory.Text += (" r. " + total % int.Parse(calcDisplay.Text));
                            }
                        }
                        else
                        {
                            // if there is a division error, clear display and update history.
                            calcDisplay.Clear();
                            calcHistory.Text += " error ";
                        }
                        break;
                    default:
                        // If no operation has been selected, the total is simply the number on the screen.
                        calcHistory.Text += int.Parse(calcDisplay.Text);
                        break;

                } // end switch statement

                //reset calculator for next operation.
                resetCalculator();

            } catch
            {
                // a format exception indicates that there is no number on the screen. Show user message.
                MessageBox.Show("You need to enter another number.");
            }

            
        }

        private void calcBtnClear_Click(object sender, EventArgs e)
        {
            // clear button resets calculator
            resetCalculator();
        }

        private void calcBtnClearHistory(object sender, EventArgs e)
        {
            // clicking 'clear sums' removes all text from calculator history.
            calcHistory.Clear();
        }

        //Just for fun - a random sum generator
        private void btnIdeaGenerator_Click(object sender, EventArgs e)
        {
            // array of operators
            string[] operators = new string[4] {" + ", " - ", " x ", " ÷ "};
            // select two random numbers and random index of operator list to ask user a question.
            ideaBox.Text = "What is " + rand.Next(100).ToString() + operators[rand.Next(4)] + rand.Next(100).ToString() + '?';
            // reset calculator ready for user to enter question.
            if (total != 0 && btnClicked == false)
            {
                resetCalculator();
            }
        }

      

        // Calculator help panel
        private void btnHelpCalculator_Click(object sender, EventArgs e)
        {
            // clicking ? button makes panel visible
            helpPanelCalculator.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clicking 'Close Help' makes panel invisible
            helpPanelCalculator.Visible = false;
        }


        // TEXT EDITOR

        // declare bool variable to track whether user has made changes. If true, prompt to save work before replacing with writing idea
        bool userChanges = false;

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            // whenever user makes changes to text, set userChanges to true.
            userChanges = true;
        }

        // Change font family.
        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get text of selected item in fontList
            string fontName = fontList.GetItemText(fontList.SelectedItem);
            // set font of text box to be text from list and existing size.
            richTextBox.Font = new Font(fontName, richTextBox.Font.Size);
        }

        // Change background colour - clicking any colour button sets background colour of text box to be colour of button clicked.
        private void backColor1_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor1.BackColor;
        }

        private void backColor2_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor2.BackColor;
        }

        private void backColor3_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor3.BackColor;
        }

        private void backColor4_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor4.BackColor;
        }

        private void backColor5_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor5.BackColor;
        }

        private void backColor6_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = backColor6.BackColor;
        }
        // Change text colour - clicking any colour button sets foreground colour of text box to be colour of button clicked.
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

        // change font size using trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // set font of richtextbox to existing font family and value of trackbar.
            richTextBox.Font = new Font(richTextBox.Font.FontFamily, trackBar1.Value);
        }

        // declare filename string variable for saving/loading text.
        string filename;

        // Save file
        private void btnSave_Click(object sender, EventArgs e)
        {
            // background colour does not save so if text is white (button 1), change it to black (button 6) when saving.
            if (richTextBox.ForeColor == backColor1.BackColor)
            {
                richTextBox.ForeColor = backColor6.BackColor;

                // if the background in the application is black the text won't show up any more. Change background to white to avoid confusion.
                if (richTextBox.BackColor == backColor6.BackColor)
                {
                    richTextBox.BackColor = backColor1.BackColor;
                }
            }
            // initialise savepath string -> this will store the initial directory for the save file dialog
            string savePath;

            // If My Documents path exists, create a folder in which to save files
            try
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My writing\\";
                Directory.CreateDirectory(savePath);
            } catch
            {
                // If My Documents does not exist, leave initital directory blank and let user choose/create save location.
                savePath = "";
            }
            // open save file dialogue at save path
            saveFileDialog.InitialDirectory = savePath;
            saveFileDialog.Title = "Save your writing";
            saveFileDialog.FileName = "";
            // Allow user to save file with (rtf) or without (txt) formatting.
            saveFileDialog.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|All Files|*.*";

            // As long as user does not click Cancel, save the contents of the rich text box at the chosen location.
            if(saveFileDialog.ShowDialog() != DialogResult.Cancel) {
                filename = saveFileDialog.FileName;
                richTextBox.SaveFile(filename, RichTextBoxStreamType.RichText);
            }

            //There are no unsaved changes so set userChanges equal to false
            userChanges = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Declare loadPath variable -> this will store initial directory for open file dialog
            string loadPath;

            try
            {
                // Set the initial 'open file dialog' directory to My Documents
                loadPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // If the 'My Writing' folder has been created by the btnSave_Click method then add to path
                if (Directory.Exists(loadPath + "\\My writing\\"))
                {
                    loadPath += "\\My writing\\";
                }
            }
            catch
            {
                // If My Documents does not exist, leave initital directory blank
                loadPath = "";
            }
            // Open file dialog with loadPath as initial directory.
            openFileDialog.InitialDirectory = loadPath;
            openFileDialog.Title = "Open a file";
            openFileDialog.FileName = "";
            // Show only .rtf and .txt files
            openFileDialog.Filter = "Rich Text Files|*.rtf|Plain text files|*.txt";
            // If user does not cancel action, load selected file into rich text box.
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        //This button randomises the style of the text - just for fun!
        private void btnRandomStyle_Click(object sender, EventArgs e)
        {
            // Set trackbar to random value
            trackBar1.Value = rand.Next(trackBar1.Minimum,trackBar1.Maximum);
            // Select random index of font list and get text
            fontList.SelectedIndex = rand.Next(0, fontList.Items.Count);
            string randFont = fontList.GetItemText(fontList.SelectedItem);
            //set font to new typeface and size
            richTextBox.Font = new Font(randFont, trackBar1.Value);
            // list colour names
            string[] colors = { "White", "Blue", "Yellow", "Green", "Black" };
            // change font color to random index of list
            richTextBox.ForeColor = Color.FromName(colors[rand.Next(0, colors.Length)]);
            // change background to random index of colour list until background colour and font colour are different.
            do
            {
                richTextBox.BackColor = Color.FromName(colors[rand.Next(0, colors.Length)]);
            } while (richTextBox.ForeColor == richTextBox.BackColor);
        }


        private void btnWritingPrompt_Click(object sender, EventArgs e)
        {
            // declare & initialise array of writing prompts
            string[] writingPrompts =
            {
                "Once upon a time, there was an elf who lived in a tower. ",
                "Once upon a time, there was a naughty dragon ",
                "Once upon a time, there was a cobbler who made magic shoes. ",
                "My favourite foods are ",
                "My name is ",
                "My best friend is ",
                "My favourite animal is ",
                "When I went to the zoo I saw ",
                "My favourite holiday was ",
                "The best day of my life was ",
                "Pip the dog was happy because "
            };

            // if the user has changed the text in the box, prompt them to let them know that clicking 'get idea' will replace their work.
            // The dialog box has a 'don't show again dialog', which changes dontShow to false when selected
            if (userChanges == true && Properties.Settings.Default.dontShow == true)
            {
                // create dialog box with yes/no/save option
                MessageForm MessageForm = new MessageForm();
                DialogResult result = MessageForm.ShowDialog();
                if(result == DialogResult.Yes)
                {
                    // if yes, replace text box text with random writing prompt
                    richTextBox.Text = writingPrompts[rand.Next(writingPrompts.Length)];
                }
                else if (result == DialogResult.OK)
                {
                    // if save, launch save dialog before replacing text.
                    btnSave.PerformClick();
                    richTextBox.Text = writingPrompts[rand.Next(writingPrompts.Length)];
                }

            } 
            {
                // if they have not changed the text, or if 'don't show again' has been checked on the dialog, replace the text with a random prompt.
                richTextBox.Text = writingPrompts[rand.Next(writingPrompts.Length)];
            }

            // once text is replaced, user has not yet made any changes so userChanges is false
            userChanges = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // If undo is possible, undo last edit in rich text box.
            if(richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            // If redo is possible, redo most recent undo action.
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.Z)
            {
                btnUndo.PerformClick();
            } else if (e.KeyCode == Keys.Control && e.KeyCode == Keys.Y)
            {
                btnRedo.PerformClick();
            }
        }

        private void imgLinkPlus_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            webBrowser1.Navigate("https://www.bbc.co.uk/bitesize/topics/zwv39j6/articles/z8hyfrd");
        }

        private void imgLinkMinus_Click(object sender, EventArgs e)
        {

        }

        private void imgLinkTimes_Click(object sender, EventArgs e)
        {

        }

        private void imgLinkDivide_Click(object sender, EventArgs e)
        {

        }

        private void helpBtnTextEditor_Click(object sender, EventArgs e)
        {
            if(helpPanelTexteditor.Visible == false)
            {
                helpPanelTexteditor.Visible = true;
            } else
            {
                helpPanelTexteditor.Visible = false;
            }
        }

        private void btnCloseHelpText_Click(object sender, EventArgs e)
        {
            helpPanelTexteditor.Visible = false;
        }
    }
}
