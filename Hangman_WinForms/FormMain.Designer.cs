namespace Hangman_WinForms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelAlphabet = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.pBHangman = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btRetry = new System.Windows.Forms.Button();
            this.btContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltextHighscore = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelAlphabet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBHangman)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAlphabet
            // 
            this.tableLayoutPanelAlphabet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelAlphabet.AutoSize = true;
            this.tableLayoutPanelAlphabet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelAlphabet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanelAlphabet.ColumnCount = 13;
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonZ, 12, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonY, 11, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonX, 10, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonW, 9, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonV, 8, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonU, 7, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonT, 6, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonS, 5, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonR, 4, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonQ, 3, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonP, 2, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonO, 1, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonN, 0, 1);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonM, 12, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonL, 11, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonK, 10, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonJ, 9, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonI, 8, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonH, 7, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonG, 6, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonF, 5, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonE, 4, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonD, 3, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonC, 2, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonB, 1, 0);
            this.tableLayoutPanelAlphabet.Controls.Add(this.buttonA, 0, 0);
            this.tableLayoutPanelAlphabet.Location = new System.Drawing.Point(2, 386);
            this.tableLayoutPanelAlphabet.Name = "tableLayoutPanelAlphabet";
            this.tableLayoutPanelAlphabet.RowCount = 2;
            this.tableLayoutPanelAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlphabet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAlphabet.Size = new System.Drawing.Size(559, 64);
            this.tableLayoutPanelAlphabet.TabIndex = 0;
            // 
            // buttonZ
            // 
            this.buttonZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZ.Enabled = false;
            this.buttonZ.Location = new System.Drawing.Point(519, 35);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(37, 26);
            this.buttonZ.TabIndex = 25;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonY
            // 
            this.buttonY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonY.Enabled = false;
            this.buttonY.Location = new System.Drawing.Point(476, 35);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(37, 26);
            this.buttonY.TabIndex = 24;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonX
            // 
            this.buttonX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX.Enabled = false;
            this.buttonX.Location = new System.Drawing.Point(433, 35);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(37, 26);
            this.buttonX.TabIndex = 23;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonW
            // 
            this.buttonW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonW.Enabled = false;
            this.buttonW.Location = new System.Drawing.Point(390, 35);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(37, 26);
            this.buttonW.TabIndex = 22;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonV
            // 
            this.buttonV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonV.Enabled = false;
            this.buttonV.Location = new System.Drawing.Point(347, 35);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(37, 26);
            this.buttonV.TabIndex = 21;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonU
            // 
            this.buttonU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonU.Enabled = false;
            this.buttonU.Location = new System.Drawing.Point(304, 35);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(37, 26);
            this.buttonU.TabIndex = 20;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonT
            // 
            this.buttonT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonT.Enabled = false;
            this.buttonT.Location = new System.Drawing.Point(261, 35);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(37, 26);
            this.buttonT.TabIndex = 19;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonS
            // 
            this.buttonS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonS.Enabled = false;
            this.buttonS.Location = new System.Drawing.Point(218, 35);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(37, 26);
            this.buttonS.TabIndex = 18;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonR
            // 
            this.buttonR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonR.Enabled = false;
            this.buttonR.Location = new System.Drawing.Point(175, 35);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(37, 26);
            this.buttonR.TabIndex = 17;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQ.Enabled = false;
            this.buttonQ.Location = new System.Drawing.Point(132, 35);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(37, 26);
            this.buttonQ.TabIndex = 16;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonP
            // 
            this.buttonP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonP.Enabled = false;
            this.buttonP.Location = new System.Drawing.Point(89, 35);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(37, 26);
            this.buttonP.TabIndex = 15;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonO
            // 
            this.buttonO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonO.Enabled = false;
            this.buttonO.Location = new System.Drawing.Point(46, 35);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(37, 26);
            this.buttonO.TabIndex = 14;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonN
            // 
            this.buttonN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonN.Enabled = false;
            this.buttonN.Location = new System.Drawing.Point(3, 35);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(37, 26);
            this.buttonN.TabIndex = 13;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonM
            // 
            this.buttonM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonM.Enabled = false;
            this.buttonM.Location = new System.Drawing.Point(519, 3);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(37, 26);
            this.buttonM.TabIndex = 12;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonL
            // 
            this.buttonL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonL.Enabled = false;
            this.buttonL.Location = new System.Drawing.Point(476, 3);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(37, 26);
            this.buttonL.TabIndex = 11;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonK
            // 
            this.buttonK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonK.Enabled = false;
            this.buttonK.Location = new System.Drawing.Point(433, 3);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(37, 26);
            this.buttonK.TabIndex = 10;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonJ.Enabled = false;
            this.buttonJ.Location = new System.Drawing.Point(390, 3);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(37, 26);
            this.buttonJ.TabIndex = 9;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonI
            // 
            this.buttonI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonI.Enabled = false;
            this.buttonI.Location = new System.Drawing.Point(347, 3);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(37, 26);
            this.buttonI.TabIndex = 8;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonH
            // 
            this.buttonH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonH.Enabled = false;
            this.buttonH.Location = new System.Drawing.Point(304, 3);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(37, 26);
            this.buttonH.TabIndex = 7;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonG
            // 
            this.buttonG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonG.Enabled = false;
            this.buttonG.Location = new System.Drawing.Point(261, 3);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(37, 26);
            this.buttonG.TabIndex = 6;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonF
            // 
            this.buttonF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonF.Enabled = false;
            this.buttonF.Location = new System.Drawing.Point(218, 3);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(37, 26);
            this.buttonF.TabIndex = 5;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonE
            // 
            this.buttonE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonE.Enabled = false;
            this.buttonE.Location = new System.Drawing.Point(175, 3);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(37, 26);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonD
            // 
            this.buttonD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonD.Enabled = false;
            this.buttonD.Location = new System.Drawing.Point(132, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(37, 26);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonC
            // 
            this.buttonC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonC.Enabled = false;
            this.buttonC.Location = new System.Drawing.Point(89, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(37, 26);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonB.Enabled = false;
            this.buttonB.Location = new System.Drawing.Point(46, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(37, 26);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonA
            // 
            this.buttonA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonA.Enabled = false;
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(37, 26);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonA_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(5, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(158, 109);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBHangman
            // 
            this.pBHangman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBHangman.ErrorImage = global::Hangman_WinForms.Properties.Resources._88;
            this.pBHangman.Image = global::Hangman_WinForms.Properties.Resources._99;
            this.pBHangman.InitialImage = global::Hangman_WinForms.Properties.Resources._88;
            this.pBHangman.Location = new System.Drawing.Point(2, 2);
            this.pBHangman.Name = "pBHangman";
            this.pBHangman.Size = new System.Drawing.Size(513, 303);
            this.pBHangman.TabIndex = 2;
            this.pBHangman.TabStop = false;
            // 
            // lblWord
            // 
            this.lblWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("DejaVu Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWord.Location = new System.Drawing.Point(12, 327);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(124, 39);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "WORD";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGameOver.Location = new System.Drawing.Point(349, 320);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(205, 46);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // btRetry
            // 
            this.btRetry.BackColor = System.Drawing.Color.IndianRed;
            this.btRetry.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRetry.Location = new System.Drawing.Point(584, 405);
            this.btRetry.Name = "btRetry";
            this.btRetry.Size = new System.Drawing.Size(118, 45);
            this.btRetry.TabIndex = 5;
            this.btRetry.Text = "RETRY";
            this.btRetry.UseVisualStyleBackColor = false;
            this.btRetry.Click += new System.EventHandler(this.btRetry_Click);
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.LightGreen;
            this.btContinue.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btContinue.Location = new System.Drawing.Point(584, 354);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(118, 45);
            this.btContinue.TabIndex = 6;
            this.btContinue.Text = "CONTINUE";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltextHighscore
            // 
            this.lbltextHighscore.AutoSize = true;
            this.lbltextHighscore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltextHighscore.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltextHighscore.Location = new System.Drawing.Point(5, 113);
            this.lbltextHighscore.Name = "lbltextHighscore";
            this.lbltextHighscore.Size = new System.Drawing.Size(158, 54);
            this.lbltextHighscore.TabIndex = 9;
            this.lbltextHighscore.Text = "HighScore";
            this.lbltextHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHighscore.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighscore.Location = new System.Drawing.Point(5, 175);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(158, 30);
            this.lblHighscore.TabIndex = 8;
            this.lblHighscore.Text = "0";
            this.lblHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(5, 263);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(158, 38);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbltextHighscore, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHighscore, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblScore, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(527, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 303);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btContinue);
            this.Controls.Add(this.btRetry);
            this.Controls.Add(this.tableLayoutPanelAlphabet);
            this.Controls.Add(this.pBHangman);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblWord);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.tableLayoutPanelAlphabet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBHangman)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAlphabet;
        private Button buttonZ;
        private Button buttonY;
        private Button buttonX;
        private Button buttonW;
        private Button buttonV;
        private Button buttonU;
        private Button buttonT;
        private Button buttonS;
        private Button buttonR;
        private Button buttonQ;
        private Button buttonP;
        private Button buttonO;
        private Button buttonN;
        private Button buttonM;
        private Button buttonL;
        private Button buttonK;
        private Button buttonJ;
        private Button buttonI;
        private Button buttonH;
        private Button buttonG;
        private Button buttonF;
        private Button buttonE;
        private Button buttonD;
        private Button buttonC;
        private Button buttonB;
        private Button buttonA;
        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private PictureBox pBHangman;
        private Label lblWord;
        private Label lblGameOver;
        private Button btRetry;
        private Button btContinue;
        private Label lblHighscore;
        private Label label1;
        private Label lbltextHighscore;
        private Label lblScore;
        private TableLayoutPanel tableLayoutPanel1;
    }
}