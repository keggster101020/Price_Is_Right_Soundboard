namespace The_Price_Is_Wrong
{
    partial class The_Price_is_Right
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
            this.Table = new MetroFramework.Controls.MetroTabControl();
            this.Sounds = new MetroFramework.Controls.MetroTabPage();
            this.Loser = new MetroFramework.Controls.MetroButton();
            this.Winner = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.CoinFlip = new MetroFramework.Controls.MetroTabPage();
            this.OutcomeResult = new MetroFramework.Controls.MetroLabel();
            this.Outcome = new MetroFramework.Controls.MetroLabel();
            this.Flip = new MetroFramework.Controls.MetroButton();
            this.Tails = new MetroFramework.Controls.MetroRadioButton();
            this.Heads = new MetroFramework.Controls.MetroRadioButton();
            this.Guess = new MetroFramework.Controls.MetroLabel();
            this.Admin = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ForceTails = new MetroFramework.Controls.MetroToggle();
            this.ForceHeads = new MetroFramework.Controls.MetroToggle();
            this.Table.SuspendLayout();
            this.Sounds.SuspendLayout();
            this.CoinFlip.SuspendLayout();
            this.Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.Controls.Add(this.Sounds);
            this.Table.Controls.Add(this.CoinFlip);
            this.Table.Controls.Add(this.Admin);
            this.Table.CustomBackground = false;
            this.Table.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.Table.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.Table.Location = new System.Drawing.Point(23, 63);
            this.Table.Name = "Table";
            this.Table.SelectedIndex = 0;
            this.Table.Size = new System.Drawing.Size(552, 274);
            this.Table.Style = MetroFramework.MetroColorStyle.Blue;
            this.Table.StyleManager = null;
            this.Table.TabIndex = 1;
            this.Table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Table.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Table.UseStyleColors = false;
            // 
            // Sounds
            // 
            this.Sounds.Controls.Add(this.Loser);
            this.Sounds.Controls.Add(this.Winner);
            this.Sounds.Controls.Add(this.metroButton1);
            this.Sounds.CustomBackground = false;
            this.Sounds.HorizontalScrollbar = false;
            this.Sounds.HorizontalScrollbarBarColor = true;
            this.Sounds.HorizontalScrollbarHighlightOnWheel = false;
            this.Sounds.HorizontalScrollbarSize = 10;
            this.Sounds.Location = new System.Drawing.Point(4, 35);
            this.Sounds.Name = "Sounds";
            this.Sounds.Size = new System.Drawing.Size(544, 235);
            this.Sounds.Style = MetroFramework.MetroColorStyle.Purple;
            this.Sounds.StyleManager = null;
            this.Sounds.TabIndex = 0;
            this.Sounds.Text = "Sounds";
            this.Sounds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Sounds.VerticalScrollbar = false;
            this.Sounds.VerticalScrollbarBarColor = true;
            this.Sounds.VerticalScrollbarHighlightOnWheel = false;
            this.Sounds.VerticalScrollbarSize = 10;
            // 
            // Loser
            // 
            this.Loser.Highlight = false;
            this.Loser.Location = new System.Drawing.Point(416, 34);
            this.Loser.Name = "Loser";
            this.Loser.Size = new System.Drawing.Size(84, 52);
            this.Loser.Style = MetroFramework.MetroColorStyle.Blue;
            this.Loser.StyleManager = null;
            this.Loser.TabIndex = 4;
            this.Loser.Text = "Loser";
            this.Loser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Loser.Click += new System.EventHandler(this.Loser_Click);
            // 
            // Winner
            // 
            this.Winner.Highlight = false;
            this.Winner.Location = new System.Drawing.Point(232, 34);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(84, 52);
            this.Winner.Style = MetroFramework.MetroColorStyle.Blue;
            this.Winner.StyleManager = null;
            this.Winner.TabIndex = 3;
            this.Winner.Text = "Winner";
            this.Winner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Winner.Click += new System.EventHandler(this.Winner_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(55, 34);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Theme Song";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CoinFlip
            // 
            this.CoinFlip.Controls.Add(this.OutcomeResult);
            this.CoinFlip.Controls.Add(this.Outcome);
            this.CoinFlip.Controls.Add(this.Flip);
            this.CoinFlip.Controls.Add(this.Tails);
            this.CoinFlip.Controls.Add(this.Heads);
            this.CoinFlip.Controls.Add(this.Guess);
            this.CoinFlip.CustomBackground = false;
            this.CoinFlip.HorizontalScrollbar = false;
            this.CoinFlip.HorizontalScrollbarBarColor = true;
            this.CoinFlip.HorizontalScrollbarHighlightOnWheel = false;
            this.CoinFlip.HorizontalScrollbarSize = 10;
            this.CoinFlip.Location = new System.Drawing.Point(4, 35);
            this.CoinFlip.Name = "CoinFlip";
            this.CoinFlip.Size = new System.Drawing.Size(544, 235);
            this.CoinFlip.Style = MetroFramework.MetroColorStyle.Teal;
            this.CoinFlip.StyleManager = null;
            this.CoinFlip.TabIndex = 1;
            this.CoinFlip.Text = "Coin Flip";
            this.CoinFlip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CoinFlip.VerticalScrollbar = false;
            this.CoinFlip.VerticalScrollbarBarColor = true;
            this.CoinFlip.VerticalScrollbarHighlightOnWheel = false;
            this.CoinFlip.VerticalScrollbarSize = 10;
            // 
            // OutcomeResult
            // 
            this.OutcomeResult.AutoSize = true;
            this.OutcomeResult.CustomBackground = false;
            this.OutcomeResult.CustomForeColor = false;
            this.OutcomeResult.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.OutcomeResult.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.OutcomeResult.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.OutcomeResult.Location = new System.Drawing.Point(119, 87);
            this.OutcomeResult.Name = "OutcomeResult";
            this.OutcomeResult.Size = new System.Drawing.Size(81, 19);
            this.OutcomeResult.Style = MetroFramework.MetroColorStyle.Blue;
            this.OutcomeResult.StyleManager = null;
            this.OutcomeResult.TabIndex = 7;
            this.OutcomeResult.Text = "metroLabel1";
            this.OutcomeResult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OutcomeResult.UseStyleColors = false;
            this.OutcomeResult.Visible = false;
            // 
            // Outcome
            // 
            this.Outcome.AutoSize = true;
            this.Outcome.CustomBackground = false;
            this.Outcome.CustomForeColor = false;
            this.Outcome.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Outcome.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Outcome.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Outcome.Location = new System.Drawing.Point(46, 87);
            this.Outcome.Name = "Outcome";
            this.Outcome.Size = new System.Drawing.Size(67, 19);
            this.Outcome.Style = MetroFramework.MetroColorStyle.Blue;
            this.Outcome.StyleManager = null;
            this.Outcome.TabIndex = 6;
            this.Outcome.Text = "Outcome:";
            this.Outcome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Outcome.UseStyleColors = false;
            // 
            // Flip
            // 
            this.Flip.Highlight = false;
            this.Flip.Location = new System.Drawing.Point(254, 33);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(75, 23);
            this.Flip.Style = MetroFramework.MetroColorStyle.Blue;
            this.Flip.StyleManager = null;
            this.Flip.TabIndex = 5;
            this.Flip.Text = "Flip";
            this.Flip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Tails
            // 
            this.Tails.AutoSize = true;
            this.Tails.CustomBackground = false;
            this.Tails.CustomForeColor = false;
            this.Tails.FontSize = MetroFramework.MetroLinkSize.Small;
            this.Tails.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.Tails.Location = new System.Drawing.Point(172, 37);
            this.Tails.Name = "Tails";
            this.Tails.Size = new System.Drawing.Size(47, 15);
            this.Tails.Style = MetroFramework.MetroColorStyle.Blue;
            this.Tails.StyleManager = null;
            this.Tails.TabIndex = 4;
            this.Tails.TabStop = true;
            this.Tails.Text = "Tails";
            this.Tails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tails.UseStyleColors = false;
            this.Tails.UseVisualStyleBackColor = true;
            // 
            // Heads
            // 
            this.Heads.AutoSize = true;
            this.Heads.CustomBackground = false;
            this.Heads.CustomForeColor = false;
            this.Heads.FontSize = MetroFramework.MetroLinkSize.Small;
            this.Heads.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.Heads.Location = new System.Drawing.Point(97, 37);
            this.Heads.Name = "Heads";
            this.Heads.Size = new System.Drawing.Size(56, 15);
            this.Heads.Style = MetroFramework.MetroColorStyle.Blue;
            this.Heads.StyleManager = null;
            this.Heads.TabIndex = 3;
            this.Heads.TabStop = true;
            this.Heads.Text = "Heads";
            this.Heads.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Heads.UseStyleColors = false;
            this.Heads.UseVisualStyleBackColor = true;
            // 
            // Guess
            // 
            this.Guess.AutoSize = true;
            this.Guess.CustomBackground = false;
            this.Guess.CustomForeColor = false;
            this.Guess.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.Guess.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.Guess.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.Guess.Location = new System.Drawing.Point(46, 33);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(45, 19);
            this.Guess.Style = MetroFramework.MetroColorStyle.Blue;
            this.Guess.StyleManager = null;
            this.Guess.TabIndex = 2;
            this.Guess.Text = "Guess:";
            this.Guess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Guess.UseStyleColors = false;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.metroLabel2);
            this.Admin.Controls.Add(this.metroLabel1);
            this.Admin.Controls.Add(this.ForceTails);
            this.Admin.Controls.Add(this.ForceHeads);
            this.Admin.CustomBackground = false;
            this.Admin.HorizontalScrollbar = false;
            this.Admin.HorizontalScrollbarBarColor = true;
            this.Admin.HorizontalScrollbarHighlightOnWheel = false;
            this.Admin.HorizontalScrollbarSize = 10;
            this.Admin.Location = new System.Drawing.Point(4, 35);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(544, 235);
            this.Admin.Style = MetroFramework.MetroColorStyle.Teal;
            this.Admin.StyleManager = null;
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Admin.VerticalScrollbar = false;
            this.Admin.VerticalScrollbarBarColor = true;
            this.Admin.VerticalScrollbarHighlightOnWheel = false;
            this.Admin.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(135, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Force Tails";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(122, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Force Heads";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = false;
            // 
            // ForceTails
            // 
            this.ForceTails.AutoSize = true;
            this.ForceTails.CustomBackground = false;
            this.ForceTails.DisplayStatus = true;
            this.ForceTails.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ForceTails.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ForceTails.Location = new System.Drawing.Point(224, 82);
            this.ForceTails.Name = "ForceTails";
            this.ForceTails.Size = new System.Drawing.Size(80, 17);
            this.ForceTails.Style = MetroFramework.MetroColorStyle.Teal;
            this.ForceTails.StyleManager = null;
            this.ForceTails.TabIndex = 2;
            this.ForceTails.Text = "Off";
            this.ForceTails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ForceTails.UseStyleColors = false;
            this.ForceTails.UseVisualStyleBackColor = true;
            // 
            // ForceHeads
            // 
            this.ForceHeads.AutoSize = true;
            this.ForceHeads.CustomBackground = false;
            this.ForceHeads.DisplayStatus = true;
            this.ForceHeads.FontSize = MetroFramework.MetroLinkSize.Small;
            this.ForceHeads.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.ForceHeads.Location = new System.Drawing.Point(224, 41);
            this.ForceHeads.Name = "ForceHeads";
            this.ForceHeads.Size = new System.Drawing.Size(80, 17);
            this.ForceHeads.Style = MetroFramework.MetroColorStyle.Teal;
            this.ForceHeads.StyleManager = null;
            this.ForceHeads.TabIndex = 3;
            this.ForceHeads.Text = "Off";
            this.ForceHeads.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ForceHeads.UseStyleColors = false;
            this.ForceHeads.UseVisualStyleBackColor = true;
            // 
            // The_Price_is_Right
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 376);
            this.Controls.Add(this.Table);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "The_Price_is_Right";
            this.Text = "The Price is Right";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Table.ResumeLayout(false);
            this.Sounds.ResumeLayout(false);
            this.CoinFlip.ResumeLayout(false);
            this.CoinFlip.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Table;
        private MetroFramework.Controls.MetroTabPage Sounds;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage CoinFlip;
        private MetroFramework.Controls.MetroButton Winner;
        private MetroFramework.Controls.MetroButton Loser;
        private MetroFramework.Controls.MetroLabel OutcomeResult;
        private MetroFramework.Controls.MetroLabel Outcome;
        private MetroFramework.Controls.MetroButton Flip;
        private MetroFramework.Controls.MetroRadioButton Tails;
        private MetroFramework.Controls.MetroRadioButton Heads;
        private MetroFramework.Controls.MetroLabel Guess;
        private MetroFramework.Controls.MetroTabPage Admin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle ForceTails;
        private MetroFramework.Controls.MetroToggle ForceHeads;
    }
}

