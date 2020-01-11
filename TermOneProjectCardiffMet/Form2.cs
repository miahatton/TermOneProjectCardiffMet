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
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void chckBoxDontAsk_CheckedChanged(object sender, EventArgs e)
        {
            // when user checks 'don't show again', the dontShow property is set to true.
            Properties.Settings.Default.dontShow = this.chckBoxDontAsk.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
