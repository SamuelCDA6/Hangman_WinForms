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
    public partial class FormMenu : Form
    {
        readonly FormHighscores formHighscores = new();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain FormGame = new FormMain();
            Opacity = 0;
            DialogResult result = FormGame.ShowDialog();
            Opacity = 1;
            if (result == DialogResult.Cancel)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btHighscores_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            DialogResult result = formHighscores.ShowDialog();
            Opacity = 1;
        }
    }
}
