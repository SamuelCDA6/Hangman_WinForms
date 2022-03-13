namespace Hangman_WinForms
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btHighscores = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(447, 83);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hangman by Samuel Chapel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btStart.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btStart.Location = new System.Drawing.Point(121, 177);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(117, 40);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btHighscores
            // 
            this.btHighscores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btHighscores.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHighscores.Location = new System.Drawing.Point(12, 401);
            this.btHighscores.Name = "btHighscores";
            this.btHighscores.Size = new System.Drawing.Size(144, 40);
            this.btHighscores.TabIndex = 2;
            this.btHighscores.Text = "HIGHSCORES";
            this.btHighscores.UseVisualStyleBackColor = false;
            this.btHighscores.Click += new System.EventHandler(this.btHighscores_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btExit.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.Location = new System.Drawing.Point(304, 401);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(131, 40);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Hangman_WinForms.Properties.Resources._99;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(447, 463);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btHighscores);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Button btStart;
        private Button btHighscores;
        private Button btExit;
    }
}