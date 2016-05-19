using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPGenarator
{
    public partial class ScriptForm : Form
    {
        public ScriptForm(string script)
        {
            InitializeComponent();
            rtbScript.Text = script;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbScript.Text);
            MessageBox.Show("Saved to clipBoard");
        }
    }
}
