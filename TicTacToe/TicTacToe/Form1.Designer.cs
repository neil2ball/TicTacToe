namespace TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tic00RadioButton = new System.Windows.Forms.RadioButton();
            this.tic01RadioButton = new System.Windows.Forms.RadioButton();
            this.tic02RadioButton = new System.Windows.Forms.RadioButton();
            this.tic10RadioButton = new System.Windows.Forms.RadioButton();
            this.tic11RadioButton = new System.Windows.Forms.RadioButton();
            this.tic12RadioButton = new System.Windows.Forms.RadioButton();
            this.tic20RadioButton = new System.Windows.Forms.RadioButton();
            this.tic21RadioButton = new System.Windows.Forms.RadioButton();
            this.tic22RadioButton = new System.Windows.Forms.RadioButton();
            this.winsLabel = new System.Windows.Forms.Label();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.lossesTextBox = new System.Windows.Forms.TextBox();
            this.drawsLabel = new System.Windows.Forms.Label();
            this.drawsTextBox = new System.Windows.Forms.TextBox();
            this.xoComboBox = new System.Windows.Forms.ComboBox();
            this.xoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.newGameToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(104, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(397, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Noughts and Crosses!";
            // 
            // tic00RadioButton
            // 
            this.tic00RadioButton.AutoSize = true;
            this.tic00RadioButton.Enabled = false;
            this.tic00RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic00RadioButton.Location = new System.Drawing.Point(172, 354);
            this.tic00RadioButton.Name = "tic00RadioButton";
            this.tic00RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic00RadioButton.TabIndex = 2;
            this.tic00RadioButton.TabStop = true;
            this.tic00RadioButton.UseVisualStyleBackColor = true;
            this.tic00RadioButton.CheckedChanged += new System.EventHandler(this.tic00RadioButton_CheckedChanged);
            // 
            // tic01RadioButton
            // 
            this.tic01RadioButton.AutoSize = true;
            this.tic01RadioButton.Enabled = false;
            this.tic01RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic01RadioButton.Location = new System.Drawing.Point(247, 354);
            this.tic01RadioButton.Name = "tic01RadioButton";
            this.tic01RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic01RadioButton.TabIndex = 3;
            this.tic01RadioButton.TabStop = true;
            this.tic01RadioButton.UseVisualStyleBackColor = true;
            this.tic01RadioButton.CheckedChanged += new System.EventHandler(this.tic01RadioButton_CheckedChanged);
            // 
            // tic02RadioButton
            // 
            this.tic02RadioButton.AutoSize = true;
            this.tic02RadioButton.Enabled = false;
            this.tic02RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic02RadioButton.Location = new System.Drawing.Point(346, 354);
            this.tic02RadioButton.Name = "tic02RadioButton";
            this.tic02RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic02RadioButton.TabIndex = 4;
            this.tic02RadioButton.TabStop = true;
            this.tic02RadioButton.UseVisualStyleBackColor = true;
            this.tic02RadioButton.CheckedChanged += new System.EventHandler(this.tic02RadioButton_CheckedChanged);
            // 
            // tic10RadioButton
            // 
            this.tic10RadioButton.AutoSize = true;
            this.tic10RadioButton.Enabled = false;
            this.tic10RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic10RadioButton.Location = new System.Drawing.Point(172, 262);
            this.tic10RadioButton.Name = "tic10RadioButton";
            this.tic10RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic10RadioButton.TabIndex = 5;
            this.tic10RadioButton.TabStop = true;
            this.tic10RadioButton.UseVisualStyleBackColor = true;
            this.tic10RadioButton.CheckedChanged += new System.EventHandler(this.tic10RadioButton_CheckedChanged);
            // 
            // tic11RadioButton
            // 
            this.tic11RadioButton.AutoSize = true;
            this.tic11RadioButton.Enabled = false;
            this.tic11RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic11RadioButton.Location = new System.Drawing.Point(247, 262);
            this.tic11RadioButton.Name = "tic11RadioButton";
            this.tic11RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic11RadioButton.TabIndex = 6;
            this.tic11RadioButton.TabStop = true;
            this.tic11RadioButton.UseVisualStyleBackColor = true;
            this.tic11RadioButton.CheckedChanged += new System.EventHandler(this.tic11RadioButton_CheckedChanged);
            // 
            // tic12RadioButton
            // 
            this.tic12RadioButton.AutoSize = true;
            this.tic12RadioButton.Enabled = false;
            this.tic12RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic12RadioButton.Location = new System.Drawing.Point(346, 264);
            this.tic12RadioButton.Name = "tic12RadioButton";
            this.tic12RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic12RadioButton.TabIndex = 7;
            this.tic12RadioButton.TabStop = true;
            this.tic12RadioButton.UseVisualStyleBackColor = true;
            this.tic12RadioButton.CheckedChanged += new System.EventHandler(this.tic12RadioButton_CheckedChanged);
            // 
            // tic20RadioButton
            // 
            this.tic20RadioButton.AutoSize = true;
            this.tic20RadioButton.Enabled = false;
            this.tic20RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic20RadioButton.Location = new System.Drawing.Point(172, 188);
            this.tic20RadioButton.Name = "tic20RadioButton";
            this.tic20RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic20RadioButton.TabIndex = 8;
            this.tic20RadioButton.TabStop = true;
            this.tic20RadioButton.UseVisualStyleBackColor = true;
            this.tic20RadioButton.CheckedChanged += new System.EventHandler(this.tic20RadioButton_CheckedChanged);
            // 
            // tic21RadioButton
            // 
            this.tic21RadioButton.AutoSize = true;
            this.tic21RadioButton.Enabled = false;
            this.tic21RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic21RadioButton.Location = new System.Drawing.Point(247, 188);
            this.tic21RadioButton.Name = "tic21RadioButton";
            this.tic21RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic21RadioButton.TabIndex = 9;
            this.tic21RadioButton.TabStop = true;
            this.tic21RadioButton.UseVisualStyleBackColor = true;
            this.tic21RadioButton.CheckedChanged += new System.EventHandler(this.tic21RadioButton_CheckedChanged);
            // 
            // tic22RadioButton
            // 
            this.tic22RadioButton.AutoSize = true;
            this.tic22RadioButton.Enabled = false;
            this.tic22RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic22RadioButton.Location = new System.Drawing.Point(346, 188);
            this.tic22RadioButton.Name = "tic22RadioButton";
            this.tic22RadioButton.Size = new System.Drawing.Size(14, 13);
            this.tic22RadioButton.TabIndex = 10;
            this.tic22RadioButton.TabStop = true;
            this.tic22RadioButton.UseVisualStyleBackColor = true;
            this.tic22RadioButton.CheckedChanged += new System.EventHandler(this.tic22RadioButton_CheckedChanged);
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(514, 130);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(31, 13);
            this.winsLabel.TabIndex = 14;
            this.winsLabel.Text = "Wins";
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(484, 146);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.ReadOnly = true;
            this.winsTextBox.Size = new System.Drawing.Size(100, 20);
            this.winsTextBox.TabIndex = 15;
            this.winsTextBox.Text = "0";
            this.winsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(514, 202);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(40, 13);
            this.lossesLabel.TabIndex = 16;
            this.lossesLabel.Text = "Losses";
            // 
            // lossesTextBox
            // 
            this.lossesTextBox.Location = new System.Drawing.Point(484, 218);
            this.lossesTextBox.Name = "lossesTextBox";
            this.lossesTextBox.ReadOnly = true;
            this.lossesTextBox.Size = new System.Drawing.Size(100, 20);
            this.lossesTextBox.TabIndex = 17;
            this.lossesTextBox.Text = "0";
            this.lossesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawsLabel
            // 
            this.drawsLabel.AutoSize = true;
            this.drawsLabel.Location = new System.Drawing.Point(517, 273);
            this.drawsLabel.Name = "drawsLabel";
            this.drawsLabel.Size = new System.Drawing.Size(37, 13);
            this.drawsLabel.TabIndex = 18;
            this.drawsLabel.Text = "Draws";
            // 
            // drawsTextBox
            // 
            this.drawsTextBox.Location = new System.Drawing.Point(484, 289);
            this.drawsTextBox.Name = "drawsTextBox";
            this.drawsTextBox.ReadOnly = true;
            this.drawsTextBox.Size = new System.Drawing.Size(100, 20);
            this.drawsTextBox.TabIndex = 19;
            this.drawsTextBox.Text = "0";
            this.drawsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xoComboBox
            // 
            this.xoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xoComboBox.FormattingEnabled = true;
            this.xoComboBox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.xoComboBox.Location = new System.Drawing.Point(15, 203);
            this.xoComboBox.Name = "xoComboBox";
            this.xoComboBox.Size = new System.Drawing.Size(121, 21);
            this.xoComboBox.TabIndex = 22;
            this.xoComboBox.SelectedIndexChanged += new System.EventHandler(this.xoComboBox_SelectedIndexChanged);
            // 
            // xoLabel
            // 
            this.xoLabel.AutoSize = true;
            this.xoLabel.Location = new System.Drawing.Point(12, 187);
            this.xoLabel.Name = "xoLabel";
            this.xoLabel.Size = new System.Drawing.Size(125, 13);
            this.xoLabel.TabIndex = 23;
            this.xoLabel.Text = "Pick \"X\" or \"O\" to begin.";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.xoLabel);
            this.Controls.Add(this.xoComboBox);
            this.Controls.Add(this.drawsTextBox);
            this.Controls.Add(this.drawsLabel);
            this.Controls.Add(this.lossesTextBox);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.winsTextBox);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.tic22RadioButton);
            this.Controls.Add(this.tic21RadioButton);
            this.Controls.Add(this.tic20RadioButton);
            this.Controls.Add(this.tic12RadioButton);
            this.Controls.Add(this.tic11RadioButton);
            this.Controls.Add(this.tic10RadioButton);
            this.Controls.Add(this.tic02RadioButton);
            this.Controls.Add(this.tic01RadioButton);
            this.Controls.Add(this.tic00RadioButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe!";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton tic00RadioButton;
        private System.Windows.Forms.RadioButton tic01RadioButton;
        private System.Windows.Forms.RadioButton tic02RadioButton;
        private System.Windows.Forms.RadioButton tic10RadioButton;
        private System.Windows.Forms.RadioButton tic11RadioButton;
        private System.Windows.Forms.RadioButton tic12RadioButton;
        private System.Windows.Forms.RadioButton tic20RadioButton;
        private System.Windows.Forms.RadioButton tic21RadioButton;
        private System.Windows.Forms.RadioButton tic22RadioButton;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.TextBox lossesTextBox;
        private System.Windows.Forms.Label drawsLabel;
        private System.Windows.Forms.TextBox drawsTextBox;
        private System.Windows.Forms.ComboBox xoComboBox;
        private System.Windows.Forms.Label xoLabel;
    }
}

