using System.Text;

namespace Hangman_WinForms
{
    enum State { Enable, Disable, Inverse }

    public partial class FormMain : Form
    {
        TableLayoutControlCollection alphabetControls;

        private Random random = new();
        private List<string> wordsHangman = new();
        private string currentWord = String.Empty;

        private string[] hangmanImages = { "88", "89", "90", "91",
                                           "92", "93", "94", "95",
                                           "96", "97", "98", "99" };
        private int nextHangmanImage = 1;

        private bool[] lettersFound = new bool[1];
        private int minutes = 0;
        private int secondes = 0;
        public int lives = 0;
        public int score = 0;
        private bool gameOver = false;
        private string name = String.Empty;

        public FormMain()
        {
            InitializeComponent();
            alphabetControls = tableLayoutPanelAlphabet.Controls;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            wordsHangman = File.ReadAllLines(@"C:\Users\cda06chap\Documents\motsPendu.txt").ToList();
            NewGame();
        }

        private void NewGame()
        {
            NewWord();
            secondes = 0;
            minutes = 0;
            gameOver = false;
            lblGameOver.Visible = false;
            lblHighscore.Text = FormHighscores.GetHighScore().ToString();
        }

        private void NewWord()
        {
            nextHangmanImage = 1;
            DisplayNextHangmanImage();
            btContinue.Enabled = false;
            SelectWord();
            DisplayWord();
            EnableAlphabetButtons();
            timer1.Start();
        }

        private void EnableAlphabetButtons()
        {
            foreach (Control c in alphabetControls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }
        }

        private void DisableAlphabetButtons()
        {

            foreach (Control c in alphabetControls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (secondes == 59)
                {
                    secondes = 0;
                    minutes++;
                }
                else
                {
                    secondes++;
                }
                lblTime.Text = String.Format("{0:00}:{1:00}", minutes, secondes);
            }
            else
            {
                lblGameOver.Enabled = true;
                lblGameOver.ForeColor = lblGameOver.ForeColor == Color.Red ? Color.DarkSeaGreen : Color.Red;
            }
        }

        private void SelectWord()
        {
            currentWord = wordsHangman[random.Next(wordsHangman.Count)];
            lettersFound = new bool[currentWord.Length];
        }

        private void DisplayWord()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < currentWord.Length; i++)
            {
                stringBuilder.Append(lettersFound[i] ? currentWord[i] : "_");
            }

            lblWord.Text = String.Join(" ", stringBuilder.ToString().ToCharArray());
        }

        private bool CheckLetter(char letter)
        {
            bool found = currentWord.Contains(letter);

            if (found)
            {
                int index = currentWord.IndexOf(letter, 0);
                while (index != -1)
                {
                    lettersFound[index] = true;
                    index = currentWord.IndexOf(letter, index + 1);
                }
            }
            else
            {
                DisplayNextHangmanImage();
            }
            return found;
        }

        private void DisplayNextHangmanImage()
        {
            if (Properties.Resources.ResourceManager.GetObject(hangmanImages[nextHangmanImage]) is Image i)
            {
                pBHangman.Image = i;
            }

            if (nextHangmanImage == hangmanImages.Length - 1)
            {
                gameOver = true;
                GameOver();
            }
            else
            {
                nextHangmanImage++;
            }
        }

        private void GameOver()
        {
            DisableAlphabetButtons();
            lblGameOver.Visible = true;
            lblWord.Text = String.Join(" ", currentWord);
            FormEnterName form = new FormEnterName();
            if (form.ShowDialog() == DialogResult.OK)
            {
                name = form.Name;
                FormHighscores.SaveScore(name, score, lblTime.Text);
            }            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) BtAlphabet_Click(buttonA);
            else if (e.KeyCode == Keys.B) BtAlphabet_Click(buttonB);
            else if (e.KeyCode == Keys.C) BtAlphabet_Click(buttonC);
            else if (e.KeyCode == Keys.D) BtAlphabet_Click(buttonD);
            else if (e.KeyCode == Keys.E) BtAlphabet_Click(buttonE);
            else if (e.KeyCode == Keys.F) BtAlphabet_Click(buttonF);
            else if (e.KeyCode == Keys.G) BtAlphabet_Click(buttonG);
            else if (e.KeyCode == Keys.H) BtAlphabet_Click(buttonH);
            else if (e.KeyCode == Keys.I) BtAlphabet_Click(buttonI);
            else if (e.KeyCode == Keys.J) BtAlphabet_Click(buttonJ);
            else if (e.KeyCode == Keys.K) BtAlphabet_Click(buttonK);
            else if (e.KeyCode == Keys.L) BtAlphabet_Click(buttonL);
            else if (e.KeyCode == Keys.M) BtAlphabet_Click(buttonM);
            else if (e.KeyCode == Keys.N) BtAlphabet_Click(buttonN);
            else if (e.KeyCode == Keys.O) BtAlphabet_Click(buttonO);
            else if (e.KeyCode == Keys.P) BtAlphabet_Click(buttonP);
            else if (e.KeyCode == Keys.Q) BtAlphabet_Click(buttonQ);
            else if (e.KeyCode == Keys.R) BtAlphabet_Click(buttonR);
            else if (e.KeyCode == Keys.S) BtAlphabet_Click(buttonS);
            else if (e.KeyCode == Keys.T) BtAlphabet_Click(buttonT);
            else if (e.KeyCode == Keys.U) BtAlphabet_Click(buttonU);
            else if (e.KeyCode == Keys.V) BtAlphabet_Click(buttonV);
            else if (e.KeyCode == Keys.W) BtAlphabet_Click(buttonW);
            else if (e.KeyCode == Keys.X) BtAlphabet_Click(buttonX);
            else if (e.KeyCode == Keys.Y) BtAlphabet_Click(buttonY);
            else if (e.KeyCode == Keys.Z) BtAlphabet_Click(buttonZ);

            e.Handled = true;
        }

        private void BtAlphabet_Click(Button bt)
        {
            if (bt.Enabled)
            {
                bt.Enabled = false;
                if (CheckLetter(bt.Text[0]))
                {
                    DisplayWord();

                    if (AllLettersFound())
                    {
                        DisableAlphabetButtons();
                        score ++;
                        lblScore.Text = $"{score}";
                        btContinue.Text = "CONTINUE";
                        btContinue.Enabled = true;
                        timer1.Stop();
                    }
                }
            }
        }

        private bool AllLettersFound()
        {
            for (int i = 0; i < lettersFound.Length; i++)
            {
                if (lettersFound[i] == false)
                {
                    return false;
                }
            }

            return true;
        }

        #region Buttons Alphabet Click
        private void buttonA_MouseClick(object sender, MouseEventArgs e)
        {
            BtAlphabet_Click(buttonA);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonB);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonC);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonD);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonE);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonF);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonG);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonH);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonI);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonJ);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonK);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonL);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonM);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonN);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonO);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonP);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonQ);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonR);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonS);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonT);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonU);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonV);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonW);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonX);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonY);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            BtAlphabet_Click(buttonZ);
        }
        #endregion

        private void btRetry_Click(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                if (MessageBox.Show("Voulez-vous vraiment recommencer?", "Recommencer", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            NewGame();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            NewWord();
        }
    }
}