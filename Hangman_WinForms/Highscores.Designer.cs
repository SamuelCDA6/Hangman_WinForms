namespace Hangman_WinForms
{
    partial class FormHighscores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btDate = new System.Windows.Forms.Button();
            this.btName = new System.Windows.Forms.Button();
            this.btScore = new System.Windows.Forms.Button();
            this.btTime = new System.Windows.Forms.Button();
            this.tLPTopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tLPBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btReturn = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.btBefore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tLPTopButtons.SuspendLayout();
            this.tLPBottomButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btDate
            // 
            this.btDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDate.Location = new System.Drawing.Point(3, 3);
            this.btDate.Name = "btDate";
            this.btDate.Size = new System.Drawing.Size(131, 43);
            this.btDate.TabIndex = 7;
            this.btDate.Text = "Date";
            this.btDate.UseVisualStyleBackColor = false;
            this.btDate.Click += new System.EventHandler(this.BtDate_Click);
            // 
            // btName
            // 
            this.btName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btName.Location = new System.Drawing.Point(140, 3);
            this.btName.Name = "btName";
            this.btName.Size = new System.Drawing.Size(131, 43);
            this.btName.TabIndex = 6;
            this.btName.Text = "Name";
            this.btName.UseVisualStyleBackColor = false;
            this.btName.Click += new System.EventHandler(this.BtName_Click);
            // 
            // btScore
            // 
            this.btScore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btScore.Location = new System.Drawing.Point(277, 3);
            this.btScore.Name = "btScore";
            this.btScore.Size = new System.Drawing.Size(131, 43);
            this.btScore.TabIndex = 5;
            this.btScore.Text = "Score";
            this.btScore.UseVisualStyleBackColor = false;
            this.btScore.Click += new System.EventHandler(this.BtScore_Click);
            // 
            // btTime
            // 
            this.btTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTime.Location = new System.Drawing.Point(414, 3);
            this.btTime.Name = "btTime";
            this.btTime.Size = new System.Drawing.Size(132, 43);
            this.btTime.TabIndex = 4;
            this.btTime.Text = "Time";
            this.btTime.UseVisualStyleBackColor = false;
            this.btTime.Click += new System.EventHandler(this.BtTime_Click);
            // 
            // tLPTopButtons
            // 
            this.tLPTopButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tLPTopButtons.ColumnCount = 4;
            this.tLPTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPTopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPTopButtons.Controls.Add(this.btTime, 3, 0);
            this.tLPTopButtons.Controls.Add(this.btScore, 2, 0);
            this.tLPTopButtons.Controls.Add(this.btName, 1, 0);
            this.tLPTopButtons.Controls.Add(this.btDate, 0, 0);
            this.tLPTopButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tLPTopButtons.Location = new System.Drawing.Point(0, 0);
            this.tLPTopButtons.Name = "tLPTopButtons";
            this.tLPTopButtons.RowCount = 1;
            this.tLPTopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPTopButtons.Size = new System.Drawing.Size(549, 49);
            this.tLPTopButtons.TabIndex = 8;
            // 
            // tLPBottomButtons
            // 
            this.tLPBottomButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tLPBottomButtons.ColumnCount = 3;
            this.tLPBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPBottomButtons.Controls.Add(this.btReturn, 2, 0);
            this.tLPBottomButtons.Controls.Add(this.btAfter, 1, 0);
            this.tLPBottomButtons.Controls.Add(this.btBefore, 0, 0);
            this.tLPBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tLPBottomButtons.Location = new System.Drawing.Point(0, 406);
            this.tLPBottomButtons.Name = "tLPBottomButtons";
            this.tLPBottomButtons.RowCount = 1;
            this.tLPBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPBottomButtons.Size = new System.Drawing.Size(549, 49);
            this.tLPBottomButtons.TabIndex = 9;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btReturn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReturn.Location = new System.Drawing.Point(369, 3);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(177, 43);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.BtReturn_Click);
            // 
            // btAfter
            // 
            this.btAfter.BackColor = System.Drawing.Color.DarkGray;
            this.btAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAfter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAfter.Location = new System.Drawing.Point(186, 3);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(177, 43);
            this.btAfter.TabIndex = 6;
            this.btAfter.Text = "+10";
            this.btAfter.UseVisualStyleBackColor = false;
            this.btAfter.Click += new System.EventHandler(this.BtAfter_Click);
            // 
            // btBefore
            // 
            this.btBefore.BackColor = System.Drawing.Color.LightGray;
            this.btBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBefore.Enabled = false;
            this.btBefore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBefore.Location = new System.Drawing.Point(3, 3);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(177, 43);
            this.btBefore.TabIndex = 7;
            this.btBefore.Text = "-10";
            this.btBefore.UseVisualStyleBackColor = false;
            this.btBefore.Click += new System.EventHandler(this.BtBefore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(549, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tLPBottomButtons);
            this.Controls.Add(this.tLPTopButtons);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHighscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.tLPTopButtons.ResumeLayout(false);
            this.tLPBottomButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btTime;
        private Button btDate;
        private Button btName;
        private Button btScore;
        private TableLayoutPanel tLPTopButtons;
        private TableLayoutPanel tLPBottomButtons;
        private Button btReturn;
        private Button btAfter;
        private Button btBefore;
        private DataGridView dataGridView1;
    }
}