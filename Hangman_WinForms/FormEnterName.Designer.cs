namespace Hangman_WinForms
{
    partial class FormEnterName
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
            this.lblText = new System.Windows.Forms.Label();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(120, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(176, 28);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Entrez votre nom :";
            // 
            // tBNom
            // 
            this.tBNom.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBNom.Location = new System.Drawing.Point(52, 93);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(290, 36);
            this.tBNom.TabIndex = 0;
            this.tBNom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LightGreen;
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btValider.Location = new System.Drawing.Point(52, 176);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(118, 45);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.BtValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.IndianRed;
            this.btAnnuler.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAnnuler.Location = new System.Drawing.Point(241, 176);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(118, 45);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.BtAnnuler_Click);
            // 
            // FormEnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 249);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tBNom);
            this.Controls.Add(this.lblText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrez Votre Nom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblText;
        private TextBox tBNom;
        private Button btValider;
        private Button btAnnuler;
    }
}