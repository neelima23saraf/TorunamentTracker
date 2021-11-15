namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.tournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamenrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(89, 25);
            this.tournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(577, 70);
            this.tournamentDashboardLabel.TabIndex = 3;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard:";
            // 
            // tournamentDropDown
            // 
            this.tournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDropDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentDropDown.FormattingEnabled = true;
            this.tournamentDropDown.Location = new System.Drawing.Point(169, 222);
            this.tournamentDropDown.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.tournamentDropDown.Name = "tournamentDropDown";
            this.tournamentDropDown.Size = new System.Drawing.Size(402, 62);
            this.tournamentDropDown.TabIndex = 24;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(131, 157);
            this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(479, 54);
            this.loadExistingTournamentLabel.TabIndex = 23;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTournamentButton.Location = new System.Drawing.Point(142, 518);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(5);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(457, 75);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamenrButton
            // 
            this.loadTournamenrButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamenrButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamenrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadTournamenrButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadTournamenrButton.Location = new System.Drawing.Point(148, 375);
            this.loadTournamenrButton.Margin = new System.Windows.Forms.Padding(5);
            this.loadTournamenrButton.Name = "loadTournamenrButton";
            this.loadTournamenrButton.Size = new System.Drawing.Size(444, 73);
            this.loadTournamenrButton.TabIndex = 25;
            this.loadTournamenrButton.Text = "Load Tournament";
            this.loadTournamenrButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 667);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamenrButton);
            this.Controls.Add(this.tournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox tournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button createTournamentButton;
        private Button loadTournamenrButton;
    }
}