using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


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

        // declare & initialise colors used to programmatically update appearance.
        readonly Color boldGreen = Color.FromArgb(144, 192, 72);
        readonly Color paleGreen = Color.FromArgb(192, 255, 192);
        readonly Color dark = Color.FromArgb(0, 48, 96);
        readonly Color light = Color.FromArgb(255, 255, 128);


        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
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
            if (tabControl1.SelectedIndex == 4)
            {
                /*
                 * If settings are opened, check the value of dontShow, difficulty and parentalControlOn and update the buttons to 
                 * reflect whether or not the settings are on/off or easy/hard.
                 */

                if(Properties.Settings.Default.dontShow == true)
                {
                    btnWarningNo.BackColor = boldGreen;
                    btnWarningYes.BackColor = paleGreen;
                } else
                {
                    btnWarningNo.BackColor = paleGreen;
                    btnWarningYes.BackColor = boldGreen;
                }
                
                if (Properties.Settings.Default.difficulty == "easy")
                {
                    btnEasy.BackColor = boldGreen;
                    btnHard.BackColor = paleGreen;
                }
                else
                {
                    btnEasy.BackColor = paleGreen;
                    btnHard.BackColor = boldGreen;
                }

                if (Properties.Settings.Default.parentalControlOn)
                {
                    btnParentalControlOn.BackColor = boldGreen;
                    btnParentalControlOff.BackColor = paleGreen;
                }
                else
                {
                    btnParentalControlOn.BackColor = paleGreen;
                    btnParentalControlOff.BackColor = boldGreen;
                }
            }
        }

        // WELCOME SCREEN

        // clicking one of the buttons changes the selected tab on the TabControl
        private void BtnBrowseWeb_Click(object sender, EventArgs e)
        {
            // Select webBrowser tab
            tabControl1.SelectTab(1);
        }

        private void BtnPlayNumbers_Click(object sender, EventArgs e)
        {
            // Select calculator tab
            tabControl1.SelectTab(2);
        }

        private void BtnWriteStory_Click(object sender, EventArgs e)
        {
            // Select textEditor tab
            tabControl1.SelectTab(3);
        }
        private void BtnHelpWelcome_Click(object sender, EventArgs e)
        {
            // clicking the ? icon toggles the visibility of the speech bubbles and text explaining what to do.
            picoSpeech1.Visible = !picoSpeech1.Visible;
            megSpeech1.Visible = !megSpeech1.Visible;
            megBubble1.Visible = !megBubble1.Visible;
            picoBubble1.Visible = !picoBubble1.Visible;
        }

        // WEB BROWSER

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //Navigate to page on GO click 

            // Get text from web address box and trim
            string url = webAddressBox.Text.Trim().ToLower();

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
            
            // declare & initialise allowedUrl variable to track whether navigation to url is allowed by parental controls.
            bool allowedUrl = true;
            
            // If parental controls are switched on, check that url does not contain filter words
            if (Properties.Settings.Default.parentalControlOn)
            {
                // loop through list of filter words. If one is found in url, set allowedUrl to false.
                foreach (string filteredWord in Properties.Settings.Default.filteredWords)
                {
                    if (url.Contains(filteredWord.ToLower()))
                    {
                        allowedUrl = false;
                        break;
                    }
                }
            }
            // if parental controls are off or no filtered words are found, navigate to the url.
            if (allowedUrl)
            {
                webBrowser1.Navigate(url);
            } else
            {
                // if navigation is not allowed, let the user know.
                panelNotAllowed.Visible = true;
            }
            
        }

        private void WebAddressBox_TextChanged(object sender, EventArgs e)
        {
            // hide the "address not allowed" box when user starts typing (if it is visible)
            if (panelNotAllowed.Visible)
            {
                panelNotAllowed.Visible = false;
            }
        }

        private void WebAddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            // add return key shortcut to address bar so that user doesn't have to click Go button

            // if user presses return key in address bar, perform go button click action.
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }

        }

        private void PanelNotAllowed_Click(object sender, EventArgs e)
        {
            // if user clicks on the "Web address not allowed" message, hide it so they can enter a new address.
            panelNotAllowed.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Clicking back button - web browser goes back if there is a page to go to
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            // Clicking forward button - web browser goes forward if there is a page to go to
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void WebBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // add keyboard shortcut to go back on pressing backspace
            if (e.KeyCode == Keys.Back)
            {
                btnBack.PerformClick();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //clicking refresh button - webpage refreshes
            webBrowser1.Refresh();
        }

        // Broswer history

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            // toggle the browser history
            browserHistory.Visible = !browserHistory.Visible;
            btnCloseBrowserHistory.Visible = !btnCloseBrowserHistory.Visible;
        }

        private void BtnCloseBrowserHistory_Click(object sender, EventArgs e)
        {
            // Add an extra, more obvious button to close browser history.
            browserHistory.Visible = false;
            btnCloseBrowserHistory.Visible = false;
        }

        private void BrowserHistory_SelectedIndexChanged(object sender, EventArgs e)
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

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // when the web broswer navigates to a page, update the address in the address box to show the eventual destination
            webAddressBox.Text = webBrowser1.Url.ToString();

            // add web address to history
            browserHistory.Items.Add(webBrowser1.Url.ToString());
        }

        // Broswer help panel
        private void BtnHelpBrowser_Click(object sender, EventArgs e)
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

        private void BtnCloseHelpBrowser_Click(object sender, EventArgs e)
        {
            // Clicking the 'close help' button hides the help panel.
            helpPanelBrowser.Visible = false;
        }

        //CALCULATOR COMPONENTS

        // Declare & initiliaze variables for calculator

        // Clicking operator buttons will set value of currentOperator to one of +,-,/ or *
        char currentOperator;

        // btnClicked tracks whether an operator has already been used
        bool btnClicked = false;
        // divError tracks whether an attempt to divide by zero has been made
        bool divError = false;

        // total is the stored number and is updated if multiple operators are used
        int total;
        // answer is the number produced on clicking the = button -> stored as a string for display
        int answer;

        /*
         * all number buttons either replace or add that number to the calcDisplay text box
         * whether they replace or add depends on the value of calculated - if true, there 
         * is a number on the screen that was displayed following the previous calculation.
         */

        bool calculated = false;

        private void CalcNumberBtn_Click(object sender, EventArgs e)
        {
            // when a number button is clicked, get the number from the button's Text property as num

            Button numBtn = sender as Button;
            string num = numBtn.Text;
            
            if (calculated)
            {
                // If a number is on the screen from a previous calculation, replace it with num
                calcDisplay.Text = num;
                calculated = false;
            }
            else
            {
                // If not, add num to the end of the number on the screen.
                calcDisplay.Text += num;
            }
        }

        private bool DontDivideByZero(int num1, int num2)
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

        private void ResetCalculator()
        {
            // reset all values to use calculator again.
            btnClicked = false;
            total = 0;
            calculated = true;
        }

        private void SetTotal()
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
                calcHistory.Text += System.Environment.NewLine;
            }
        }

        private char DisplayOperator(char operatorToDisplay)
        {
            // Internally the operators are referred to as +,-,*,/. For display they sometimes need to be changed to +,-,+,÷.
            switch (operatorToDisplay)
            {
                case '/':
                    return '÷';
                case '*':
                    return 'x';
                default:
                    return operatorToDisplay;
            }
        }

        private int MultiOpCalculate(int num, char nextOperator)
        {
            // if multiple operators are used in a single calculation, total will be updated each time a new operator is pressed.
                try
            {
                switch (nextOperator) { 
                    // perform addition, subtraction, multiplication or division
                    case '+':
                        return num + int.Parse(calcDisplay.Text);
                    case '-':
                        return num - int.Parse(calcDisplay.Text);
                    case '*':
                        return num * int.Parse(calcDisplay.Text);
                    case '/':
                        if (DontDivideByZero(num, int.Parse(calcDisplay.Text)))
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
            } catch
            {
                // Exception raised when user enters two operators in a row

                // If current operator or nextOperator are / or *, change them to a readable format.
                char displayCurrentOperator = DisplayOperator(currentOperator);
                char displayNextOperator = DisplayOperator(nextOperator);
                
                MessageBox.Show($"You entered: {displayCurrentOperator} {displayNextOperator}. \nYou should enter a number in between the operators. \nFor example: {displayCurrentOperator} 6 {displayNextOperator}.");
                
                // erase operator from calculator history
                calcHistory.Text = calcHistory.Text.Substring(0, calcHistory.Text.Length - 2);
                return num;
            }
                
        }

        
        private void CalcBtnOperator_Click(object sender, EventArgs e)
        {
            Button opBtn = sender as Button;
            
            char clickedOperator;

            switch (opBtn.Text)
            {
                case "+":
                    clickedOperator = '+';
                    break;
                case "-":
                    clickedOperator = '-';
                    break;
                case "x":
                    clickedOperator = '*';
                    break;
                case "÷":
                    clickedOperator = '/';
                    break;
                default:
                    MessageBox.Show("Something rather surprising has happened.");
                    clickedOperator = '*';
                    break;
            }

            // add the number and "operator" to calculator history
            calcHistory.Text +=  $"{calcDisplay.Text} {opBtn.Text} ";
            if (!btnClicked)
            {
                /*
                 * If this is the first time an operator has been used in the current calculation, 
                 * check that a number has been entered and update the 'total' variable.
                 */

                SetTotal();
            }
            else
            {
                // otherwise, perform the PREVIOUS operation on the current number to give the new value of total
                total = MultiOpCalculate(total, currentOperator);
            }
            //check for division errors
            if (!divError)
            {
                // clear display
                calcDisplay.Clear();
                // set current operator
                currentOperator = clickedOperator;
            }
            else
            {
                // if there was a divison error update calculator history and reset calculator
                calcHistory.Text += " = error ";
                ResetCalculator();
            }
        }

        private void DisplayAnswer(int num)
        {
            // when equals button click resolves, show the answer to the sum on the calculator screen and on the calculator history box.
            calcHistory.Text += num;
            calcDisplay.Text = num.ToString();
            // add new line to calculator history
            calcHistory.Text += System.Environment.NewLine;
        }

        private void CalcBtnEquals_Click(object sender, EventArgs e)
        {
            /* EQUALS BUTTON
             * Calculation is placed within a try/catch in case a user 
             * tries to enter " num x = " 
             * This will throw a format error because there will 
             * be no text on the screen for int.Parse() 
             */

            try
            {
                // is there a number on the screen? If not this will return an error and we will move to catch statement.
                int.Parse(calcDisplay.Text);

                // add number and " = " to calculator history
                calcHistory.Text += calcDisplay.Text + " = ";

                // perform operation based on most recent operator button clicked.
                // for each operation, the answer is displayed in the calculator history box and display.
                switch (currentOperator)
                {
                    case '+':
                        // add numbers together
                        answer = (total + int.Parse(calcDisplay.Text));
                        DisplayAnswer(answer);
                        break;
                    case '-':
                        // subtract number on screen from saved total
                        answer = (total - int.Parse(calcDisplay.Text));
                        DisplayAnswer(answer);
                        break;
                    case '*':
                        // multiply numbers together
                        answer = (total * int.Parse(calcDisplay.Text));
                        DisplayAnswer(answer);
                        break;
                    case '/':
                        // check for possible division errors
                        if (DontDivideByZero(total, int.Parse(calcDisplay.Text)))
                        {
                            // divide saved number total by number on screen.
                            answer = (total / int.Parse(calcDisplay.Text));
                            
                            if (total % int.Parse(calcDisplay.Text) != 0)
                            {
                                // Display answer on calculator history
                                calcHistory.Text += answer.ToString();
                                // show the remainder of the division on the calculator history box. Decimals are not introduced until KS2
                                calcHistory.Text += (" r. " + total % int.Parse(calcDisplay.Text));
                                // add new line to calculator history
                                calcHistory.Text += System.Environment.NewLine;

                                // Show answer (without remainder) on calculator display
                                calcDisplay.Text = answer.ToString();
                               
                            } else
                            {
                                DisplayAnswer(answer);
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
                        answer = int.Parse(calcDisplay.Text);
                        DisplayAnswer(answer);
                        break;

                } // end switch statement

              
                //reset calculator for next operation.
                ResetCalculator();

            } catch
            {
                // a format exception indicates that there is no number on the screen. Show user message.
                MessageBox.Show("You need to enter another number.");
            }

        }

        private void CalcBtnClear_Click(object sender, EventArgs e)
        {
            // clicking 'Clear' button removes numbers from calculator screen and resets calculator
            calcDisplay.Clear();
            ResetCalculator();
        }

        private void CalcBtnClearHistory(object sender, EventArgs e)
        {
            // clicking 'clear sums' removes all text from calculator history.
            calcHistory.Clear();
        }

        //Just for fun - a random sum generator


        private void BtnIdeaGenerator_Click(object sender, EventArgs e)
        {
            // array of operators
            string[] operators = new string[4] {" + ", " - ", " x ", " ÷ "};
            // select two random numbers and random index of operator list to ask user a question.

            // Check if user has selected 'easy' or 'hard' level in Settings.
            if (Properties.Settings.Default.difficulty == "easy")
            {
                // easy calculations only use numbers 0-20, and + and - operators.
                ideaBox.Text = $"What is {rand.Next(0,21)} {operators[rand.Next(0,2)]} {rand.Next(0,21)}?";
            } else
            {
                // hard calculations use numbers 0-99 and all operators.
                ideaBox.Text = $"What is {rand.Next(0, 100)} {operators[rand.Next(0, 4)]} {rand.Next(0, 100)}?";
            }
            // reset calculator ready for user to enter question.
            if (total != 0 && btnClicked == false)
            {
                ResetCalculator();
                calcDisplay.Clear();
            }
        }
      
        // Calculator help panel
        private void BtnHelpCalculator_Click(object sender, EventArgs e)
        {
            // clicking ? button toggles visibility of help panel
            helpPanelCalculator.Visible = !helpPanelCalculator.Visible;
        }

        private void BtnCloseHelpCalc_Click(object sender, EventArgs e)
        {
            // clicking 'Close Help' makes panel invisible
            helpPanelCalculator.Visible = false;
        }


        // TEXT EDITOR

        // declare bool variable to track whether user has made changes. If true, prompt to save work before replacing with writing idea
        bool userChanges = false;

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            // whenever user makes changes to text, set userChanges to true.
            userChanges = true;
        }

        // Change font family.
        private void FontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get text of selected item in fontList
            string fontName = fontList.GetItemText(fontList.SelectedItem);
            // set font of text box to be text from list and existing size.
            richTextBox.Font = new Font(fontName, richTextBox.Font.Size);
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            // Change background colour - clicking any colour button sets background colour of text box to be colour of button clicked.
            Button backColorBtn = sender as Button;
            richTextBox.BackColor = backColorBtn.BackColor;
        }

        private void TextColorBtn_Click(object sender, EventArgs e)
        {
            // Change text colour - clicking any colour button sets foreground colour of text box to be colour of button clicked.
            Button textColorBtn = sender as Button;
            richTextBox.ForeColor = textColorBtn.BackColor;
        }

        // change font size using trackbar
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            // set font of richtextbox to existing font family and value of trackbar.
            richTextBox.Font = new Font(richTextBox.Font.FontFamily, trackBar1.Value);
        }

        // declare filename string variable for saving/loading text.
        string filename;

        // Save file
        private void BtnSave_Click(object sender, EventArgs e)
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
            // open save file dialog at save path
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

            // There are no unsaved changes so set userChanges equal to false
            userChanges = false;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
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
            try
            {
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
            } catch (Exception ex)
            {
                MessageBox.Show("Cannot oppen file due to error: " + ex.ToString(), "Oh no!");
            }
            
        }

        // This button randomises the style of the text - just for fun!
        private void BtnRandomStyle_Click(object sender, EventArgs e)
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


        private void BtnWritingPrompt_Click(object sender, EventArgs e)
        {
            // declare & initialise array of writing prompts
            string[] writingPrompts =
            {
                "Once upon a time, there was an elf who lived in a tower. ",
                "Once upon a time, there was a naughty dragon ",
                "Once upon a time, there was a cobbler who made magic shoes. ",
                "The astronaut stepped off the rocket onto Mars. ",
                "Once upon a time, there was a giant as tall as a tree. ",
                "In a castle at the top of the tallest mountain there was ",
                "Once upon a time, ",
                "The heroes were tired of fighting dragons so they ",
                "There was a knock at the door that made the wizard jump.",
                "There was a knock at the door. I opened it and saw ",
                "King Arthur asked the knights of the round table to go on a special quest. ",
                "Jack climbed to the top of the beanstalk and he saw ",
                "Goldilocks decided not to go to the three bears house. Instead, she ",
                "Sybil was scared of the dragon, but she didn't want to fight him. Instead, she ",
                "Grugnar the wizard had a magical staff that could make people fly. ",
                "Kragg the dwarf was searching the mines for lost treasure, when he saw ",
                "Kurogane was a friendly dragon who was friends with a dwarf called Tymek. ",
                "Elbi the gnome was walking through the magical forest when she saw ",
            };

            /*
             *If the user has changed the text in the box, prompt them to let them know that clicking 'get idea' will replace their work. 
             * The dialog box has a 'don't show again dialog', which changes dontShow to true when selected (dontShow can also be changed from
             * the Settings tab). 
             */

            if (userChanges == true && Properties.Settings.Default.dontShow == false)
            {
                // create dialog box with yes/no/save option
                SaveFileForm MessageForm = new SaveFileForm();
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

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            // If undo is possible, undo last edit in rich text box.
            if(richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            // If redo is possible, redo most recent undo action.
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Add keyboard shortcuts Ctrl+Z and Ctrl+Y for undo and redo in text box.

            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.Z)
            {
                btnUndo.PerformClick();
            } else if (e.KeyCode == Keys.Control && e.KeyCode == Keys.Y)
            {
                btnRedo.PerformClick();
            }
        }

        private void HelpBtnTextEditor_Click(object sender, EventArgs e)
        {
            // clicking the ? icon toggles the visibility of the help panel
            if (!helpPanelTexteditor.Visible)
            {
                // set background colour of help panel to be the background colour of the text box.
                helpPanelTexteditor.BackColor = richTextBox.BackColor;
                helpPanelTexteditor.Visible = true;
            } else
            {
                helpPanelTexteditor.Visible = false;
            }
        }

        private void BtnCloseHelpText_Click(object sender, EventArgs e)
        {
            // clicking 'close help' button hides the help panel
            helpPanelTexteditor.Visible = false;
        }

        // SETTINGS TAB


        private void DarkMode_Click(object sender, EventArgs e)
        {
            // Clicking the dark mode button toggles the colour scheme of the whole app between blue (dark) on yellow (light) and yellow on blue.
            if (darkMode.Text == "Turn on dark mode")
            {
                welcomePage.BackColor = dark;
                welcomeLabel.ForeColor = light;
                welcomeLabel2.ForeColor = light;
                welcomeLabel3.ForeColor = light;
                calculator.BackColor = dark;
                calculatorLabel.ForeColor = light;
                calculatorLabel2.ForeColor = light;
                calcHistory.BackColor = Color.FromArgb(0, 168, 240);
                calcHistory.ForeColor = dark;
                textEditPanel.BackColor = dark;
                storyLabel.ForeColor = light;
                fontLabel.ForeColor = light;
                textSizeLabel.ForeColor = light;
                textColorLabel.ForeColor = light;
                backColorLabel.ForeColor = light;
                btnRandomStyle.BackColor = light;
                btnRandomStyle.ForeColor = dark;
                settings.BackColor = dark;
                settingsLabel.ForeColor = light;
                difficultyLabel.ForeColor = light;
                WritingWarninglabel.ForeColor = light;
                parentSettingsGroupBox.ForeColor = light;
                creditsGroupBox.ForeColor = light;
                parentalControlsLabel.ForeColor = light;
                creditsLabel.ForeColor = light;
                darkMode.Text = "Turn off dark mode";

            }
            else
            {
                welcomePage.BackColor = light;
                welcomeLabel.ForeColor = dark;
                welcomeLabel2.ForeColor = dark;
                welcomeLabel3.ForeColor = dark;
                calculator.BackColor = light;
                calculatorLabel.ForeColor = dark;
                calculatorLabel2.ForeColor = dark;
                calcHistory.BackColor = dark;
                calcHistory.ForeColor = light;
                textEditPanel.BackColor = light;
                storyLabel.ForeColor = dark;
                fontLabel.ForeColor = dark;
                textSizeLabel.ForeColor = dark;
                textColorLabel.ForeColor = dark;
                backColorLabel.ForeColor = dark;
                btnRandomStyle.BackColor = dark;
                btnRandomStyle.ForeColor = light;
                settings.BackColor = light;
                settingsLabel.ForeColor = dark;
                difficultyLabel.ForeColor = dark;
                WritingWarninglabel.ForeColor = dark;
                parentSettingsGroupBox.ForeColor = dark;
                creditsGroupBox.ForeColor = dark;
                parentalControlsLabel.ForeColor = dark;
                creditsLabel.ForeColor = dark;
                darkMode.Text = "Turn on dark mode";
            }

        }

        private void BtnClearBrowser_Click(object sender, EventArgs e)
        {
            // ask user if they are sure they want to clear their browser history
            DialogResult areYouSure = MessageBox.Show("Are you sure you want to clear your browser history?", "Clear Browser History", MessageBoxButtons.YesNo);
            if (areYouSure == DialogResult.Yes)
            {
                browserHistory.Items.Clear();
            }
        }    

        

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            // On clicking 'Easy', highlight button, de-highlight 'Hard' button and set difficulty variable to 'easy'.
            btnEasy.BackColor = boldGreen;
            btnHard.BackColor = paleGreen;
            Properties.Settings.Default.difficulty = "easy";
            Properties.Settings.Default.Save();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            // On clicking 'Hard', highlight 'hard' button, de-highlight 'Easy' button and set difficulty variable to 'hard'.
            btnEasy.BackColor = paleGreen;
            btnHard.BackColor = boldGreen;
            Properties.Settings.Default.difficulty = "hard";
            Properties.Settings.Default.Save();
        }

        private void BtnWarningYes_Click(object sender, EventArgs e)
        {
            // set value of dontShow to false so that a warning appears when clicking 'Get Idea' in the text edit tab will overwrite user's work
            Properties.Settings.Default.dontShow = false;
            Properties.Settings.Default.Save();
            // De-highlight 'no' button and highlight 'yes' button
            btnWarningNo.BackColor = paleGreen;
            btnWarningYes.BackColor = boldGreen;
        }

        private void BtnWarningNo_Click(object sender, EventArgs e)
        {
            // set value of dontShow to false so that warning does not appear when clicking 'Get Idea'
            Properties.Settings.Default.dontShow = true;
            Properties.Settings.Default.Save();
            // De-highlight 'yes' button and highlight 'no' button
            btnWarningNo.BackColor = boldGreen;
            btnWarningYes.BackColor = paleGreen;
        }

        // Instantiate a pin entry form
        public EnterPinForm pinForm = new EnterPinForm();
        DialogResult PINresult;

        public bool PINUnlock()
        {
            // attempting to access parent settings opens a pin entry form as a dialog.
            PINresult = pinForm.ShowDialog();

            // if correct pin is entered, parent settings are unlocked.
            if(PINresult == DialogResult.OK && pinForm.unlocked)
            {
                // update label, padlock image and tooltip to reflect unlocked parent settings.
                pictureBoxPadlock.Image = Properties.Resources.padlock_unlocked;
                toolTip.SetToolTip(pictureBoxPadlock, "Parental settings are unlocked. Click the padlock to lock parental settings.");
                labelControlsLocked.Text = "These controls are unlocked. Click the padlock to lock.";
                return true;
            } else
            {
                return false;
            }
            
            
        }

        private void PictureBoxPadlock_Click(object sender, EventArgs e)
        {
            // when the parent settings are unlocked, clicking the padlock will lock them  again and reset the padlock image
            if (pinForm.unlocked)
            {
                pinForm.unlocked = false;
                pictureBoxPadlock.Image = Properties.Resources.locked_padlock;
                labelControlsLocked.Text = "These controls are locked.";
                toolTip.SetToolTip(pictureBoxPadlock, "Parent settings are locked.");
            } 
        }

        private void BtnSetUpParentalControl_Click(object sender, EventArgs e)
        {
            /*
             * Adjusting parental controls requires PIN verification.
             * If the pin form's 'unlocked' property has been set to true,
             * open the parental controls form.
             * Otherwise, open the PIN form to verify user as parent. 
             */
            if (pinForm.unlocked)
            {                
                ParentalControlForm pcForm = new ParentalControlForm();
                pcForm.ShowDialog();
            }
            else if ((PINUnlock()))
            {
                ParentalControlForm pcForm = new ParentalControlForm();
                pcForm.ShowDialog();
            }
        }

        private void TurnOffParentalControls()
        {
            // update settings so that parentalControl On is true.
            Properties.Settings.Default.parentalControlOn = false;
            Properties.Settings.Default.Save();
            // De-highlight 'on' button and highlight 'off' button
            btnParentalControlOff.BackColor = boldGreen;
            btnParentalControlOn.BackColor = paleGreen;
        }
        private void TurnOnParentalControls()
        {
            // update settings so that parentalControl On is true.
            Properties.Settings.Default.parentalControlOn = true;
            Properties.Settings.Default.Save();
            // De-highlight 'off' button and highlight 'on' button
            btnParentalControlOff.BackColor = paleGreen;
            btnParentalControlOn.BackColor = boldGreen;
        }

        private void BtnParentalControlOff_Click(object sender, EventArgs e)
        {
            // If user has entered PIN, set 'parentalControlOn' variable to false (affects web browser). Otherwise open PIN form and try again on success.
            if (pinForm.unlocked)
            {
                TurnOffParentalControls();
            }
            else if(PINUnlock())
            {
                
                TurnOffParentalControls();
                
            }
        }

        private void BtnParentalControlOn_Click(object sender, EventArgs e)
        {
            // If user has entered PIN, set 'parentalControlOn' variable to true (affects web browser). Otherwise open PIN form and try again on success.
            if (pinForm.unlocked)
            {
                TurnOnParentalControls();
            }
            else if (PINUnlock())
            {
                TurnOnParentalControls();
            }
        }

        
    }
}
