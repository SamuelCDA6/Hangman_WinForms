using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_WinForms
{
    public partial class FormEnterName : Form
    {
        public new string Name = String.Empty;

        public FormEnterName()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !String.IsNullOrEmpty(tBNom.Text);
        }

        private void BtAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtValider_Click(object sender, EventArgs e)
        {
            Name = tBNom.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
