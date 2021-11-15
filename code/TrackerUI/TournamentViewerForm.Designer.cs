namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnluCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamOneTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(100, 78);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(314, 70);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Torunament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TournamentName.Location = new System.Drawing.Point(451, 98);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(113, 54);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "none";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(100, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundDropDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(307, 192);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(299, 62);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnluCheckBox
            // 
            this.unplayedOnluCheckBox.AutoSize = true;
            this.unplayedOnluCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnluCheckBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnluCheckBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.unplayedOnluCheckBox.Location = new System.Drawing.Point(307, 300);
            this.unplayedOnluCheckBox.Name = "unplayedOnluCheckBox";
            this.unplayedOnluCheckBox.Size = new System.Drawing.Size(305, 58);
            this.unplayedOnluCheckBox.TabIndex = 4;
            this.unplayedOnluCheckBox.Text = "Unplayed Only";
            this.unplayedOnluCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 45;
            this.MatchupListBox.Location = new System.Drawing.Point(110, 426);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(496, 272);
            this.MatchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneName.Location = new System.Drawing.Point(804, 304);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(244, 54);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneScore.Location = new System.Drawing.Point(804, 393);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(120, 54);
            this.teamOneScore.TabIndex = 7;
            this.teamOneScore.Text = "Score";
            // 
            // teamOneTextBox
            // 
            this.teamOneTextBox.Location = new System.Drawing.Point(973, 393);
            this.teamOneTextBox.Name = "teamOneTextBox";
            this.teamOneTextBox.Size = new System.Drawing.Size(150, 50);
            this.teamOneTextBox.TabIndex = 8;
            // 
            // teamTwoTextBox
            // 
            this.teamTwoTextBox.Location = new System.Drawing.Point(973, 634);
            this.teamTwoTextBox.Name = "teamTwoTextBox";
            this.teamTwoTextBox.Size = new System.Drawing.Size(150, 50);
            this.teamTwoTextBox.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(804, 634);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(120, 54);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamTwoLabel.Location = new System.Drawing.Point(804, 545);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(243, 54);
            this.teamTwoLabel.TabIndex = 9;
            this.teamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.versusLabel.Location = new System.Drawing.Point(924, 477);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(91, 54);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-vs-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreButton.Location = new System.Drawing.Point(1178, 497);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(164, 57);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.teamOneTextBox);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.unplayedOnluCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label label1;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnluCheckBox;
        private ListBox MatchupListBox;
        private Label teamOneName;
        private Label teamOneScore;
        private TextBox teamOneTextBox;
        private TextBox teamTwoTextBox;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}