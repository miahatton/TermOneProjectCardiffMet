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
    public partial class EnterPinForm : Form
    {
        public EnterPinForm()
        {
            InitializeComponent();
        }
        
        // When form closes, KidsToolBox will check if this value is true before granting access to parental controls.
        public bool unlocked = false;

        // if correct pin is entered, set unlocked to true, clear the text in the PIN text box and close the form.
        private void Unlock()
        {
            this.unlocked = true;
            textBoxPIN.Clear();
            this.Hide();
        }

        private void BtnPINOK_Click(object sender, EventArgs e)
        {
            // If text in box matches PIN property (in settings), unlock parent settings.
            if(textBoxPIN.Text == Properties.Settings.Default.pin)
            {
                Unlock();
            } else
            {
                MessageBox.Show("PIN incorrect");
            }
        }

        private void TextBoxPIN_KeyDown(object sender, KeyEventArgs e)
        {
            // keyboard shortcut for OK button is return key
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnPINOK.PerformClick();
            }
        }
    }
}
