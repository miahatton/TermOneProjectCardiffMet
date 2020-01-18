using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermOneProjectCardiffMet
{
    public partial class ParentalControlForm : Form
    {
        public ParentalControlForm()
        {
            InitializeComponent();

            // display the filteredWords settings property in the listbox.
            listBoxFilters.DataSource = Properties.Settings.Default.filteredWords.Cast<string>().ToArray();
        }

        private void BtnApplySettings_Click(object sender, EventArgs e)
        {
            // save application settings when user clicks APply
            Properties.Settings.Default.Save();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // save settings and close when user clicks OK
            Properties.Settings.Default.Save();
        }


        private void BtnViewPIN_Click(object sender, EventArgs e)
        {
            // toggle visibility of PIN when user clicks 'view pin'/'hide pin' button
            if(btnViewPIN.Text == "View PIN")
            {
                textBoxViewPIN.Text = Properties.Settings.Default.pin;
                btnViewPIN.Text = "Hide PIN";
            } else
            {
                textBoxViewPIN.Text = "####";
                btnViewPIN.Text = "View PIN";
            }
            
        }

        private void BtnRemoveFilter_Click(object sender, EventArgs e)
        {
            // remove selected filter from settings.
            Properties.Settings.Default.filteredWords.Remove(listBoxFilters.SelectedItem.ToString());
            // refresh listbox
            listBoxFilters.DataSource = null;
            listBoxFilters.DataSource = Properties.Settings.Default.filteredWords.Cast<string>().ToArray();
        }

        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            // add new filter to settings.
            Properties.Settings.Default.filteredWords.Add(textBoxAddFilter.Text);
            // refresh listbox
            listBoxFilters.DataSource = null;
            listBoxFilters.DataSource = Properties.Settings.Default.filteredWords.Cast<string>().ToArray();
        }

        private void BtnChangePIN_Click(object sender, EventArgs e)
        {
            // check that new PIN is the same in each box.
            if(textBoxNewPIN1.Text == textBoxNewPIN2.Text)
            {
                try
                {
                    // check that both boxes contain only numbers
                    int.Parse(textBoxNewPIN1.Text);
                    int.Parse(textBoxNewPIN2.Text);

                    // Check that PIN is four digits
                    if (textBoxNewPIN1.Text.Length == 4)
                    {
                        // update pin setting to match text entered
                        Properties.Settings.Default.pin = textBoxNewPIN1.Text;
                        Properties.Settings.Default.Save();

                        // Let user know that PIN was changed and clear text boxes.
                        labelPINChanged.Text = "PIN changed";
                        labelPINChanged.Visible = true;
                        textBoxNewPIN1.Clear();
                        textBoxNewPIN2.Clear();
                    } else
                    {
                        // warn user that PIN must be four digits
                        labelPINChanged.Text = "Must be four digits.";
                        labelPINChanged.Visible = true;
                    }

                } catch
                {
                    // Warn user that PIN must be numerical
                    labelPINChanged.Text = "Must be digits";
                    labelPINChanged.Visible = true;
                }
            } else
            {
                // Let user know that PINs don't match.
                labelPINChanged.Text = "PINs don't match.";
                labelPINChanged.Visible = true;
            }
        }

        private void TextBoxNewPIN2_KeyDown(object sender, KeyEventArgs e)
        {
            // keyboard shortcut to Change PIN button
            if(e.KeyCode == Keys.Return)
            {
                btnChangePIN.PerformClick();
            }
            
        }

        private void TextBoxAddFilter_KeyDown(object sender, KeyEventArgs e)
        {
            // keyboard shortcut to Add filter button
            if (e.KeyCode == Keys.Return)
            {
               btnAddFilter.PerformClick();
            }
        }

        private void TextBoxNewPIN2_TextChanged(object sender, EventArgs e)
        {
            // let user know that PINs don't match if both text boxes contain four characters but they differ between the two boxes.
            if (textBoxNewPIN2.Text != textBoxNewPIN1.Text && textBoxNewPIN1.Text.Length == textBoxNewPIN2.Text.Length)
            {
                labelPINChanged.Text = "PINs don't match.";
                labelPINChanged.Visible = true;
            } else
            {
                labelPINChanged.Visible = false;
            }
        }

        private void TextBoxNewPIN1_TextChanged(object sender, EventArgs e)
        {
            // clear warnings when user makes changes to text box.
            labelPINChanged.Visible = false;
        }

    }
}
