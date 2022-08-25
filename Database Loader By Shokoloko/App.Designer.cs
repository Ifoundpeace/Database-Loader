namespace Database_Loader_By_Shokoloko
{
    partial class DatabaseLoader
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
            this.ResultsTxtBox = new System.Windows.Forms.TextBox();
            this.KeywordsTxtBox = new System.Windows.Forms.TextBox();
            this.KeywordsLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StopSearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LoadDatabaseBtn = new System.Windows.Forms.Button();
            this.DatabaseSelectMenu = new System.Windows.Forms.ComboBox();
            this.CreditsLbl = new System.Windows.Forms.Label();
            this.SeperatorLbl = new System.Windows.Forms.Label();
            this.SeperatorTxtBox = new System.Windows.Forms.TextBox();
            this.ExactResultsCheckBox = new System.Windows.Forms.CheckBox();
            this.ReloadDatabasesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsTxtBox
            // 
            this.ResultsTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultsTxtBox.Location = new System.Drawing.Point(18, 236);
            this.ResultsTxtBox.MaxLength = 999999999;
            this.ResultsTxtBox.Multiline = true;
            this.ResultsTxtBox.Name = "ResultsTxtBox";
            this.ResultsTxtBox.ReadOnly = true;
            this.ResultsTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTxtBox.Size = new System.Drawing.Size(770, 202);
            this.ResultsTxtBox.TabIndex = 1;
            this.ResultsTxtBox.TextChanged += new System.EventHandler(this.ResultsTxtBox_TextChanged);
            // 
            // KeywordsTxtBox
            // 
            this.KeywordsTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeywordsTxtBox.Location = new System.Drawing.Point(18, 41);
            this.KeywordsTxtBox.Multiline = true;
            this.KeywordsTxtBox.Name = "KeywordsTxtBox";
            this.KeywordsTxtBox.Size = new System.Drawing.Size(371, 189);
            this.KeywordsTxtBox.TabIndex = 5;
            this.KeywordsTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeywordsTxtBox_KeyDown);
            // 
            // KeywordsLbl
            // 
            this.KeywordsLbl.AutoSize = true;
            this.KeywordsLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.KeywordsLbl.Location = new System.Drawing.Point(14, 18);
            this.KeywordsLbl.Name = "KeywordsLbl";
            this.KeywordsLbl.Size = new System.Drawing.Size(73, 20);
            this.KeywordsLbl.TabIndex = 4;
            this.KeywordsLbl.Text = "Keywords";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.SearchBtn.Location = new System.Drawing.Point(395, 41);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(125, 54);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StopSearchBtn
            // 
            this.StopSearchBtn.Enabled = false;
            this.StopSearchBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.StopSearchBtn.Location = new System.Drawing.Point(529, 41);
            this.StopSearchBtn.Name = "StopSearchBtn";
            this.StopSearchBtn.Size = new System.Drawing.Size(125, 54);
            this.StopSearchBtn.TabIndex = 8;
            this.StopSearchBtn.Text = "Stop Search";
            this.StopSearchBtn.UseVisualStyleBackColor = true;
            this.StopSearchBtn.Click += new System.EventHandler(this.StopSearchBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Enabled = false;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.ClearBtn.Location = new System.Drawing.Point(663, 41);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(125, 54);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoadDatabaseBtn
            // 
            this.LoadDatabaseBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.LoadDatabaseBtn.Location = new System.Drawing.Point(395, 112);
            this.LoadDatabaseBtn.Name = "LoadDatabaseBtn";
            this.LoadDatabaseBtn.Size = new System.Drawing.Size(125, 63);
            this.LoadDatabaseBtn.TabIndex = 11;
            this.LoadDatabaseBtn.Text = "Load Database";
            this.LoadDatabaseBtn.UseVisualStyleBackColor = true;
            this.LoadDatabaseBtn.Click += new System.EventHandler(this.LoadDatabaseBtn_Click);
            // 
            // DatabaseSelectMenu
            // 
            this.DatabaseSelectMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseSelectMenu.DropDownWidth = 125;
            this.DatabaseSelectMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatabaseSelectMenu.FormattingEnabled = true;
            this.DatabaseSelectMenu.Location = new System.Drawing.Point(529, 152);
            this.DatabaseSelectMenu.Name = "DatabaseSelectMenu";
            this.DatabaseSelectMenu.Size = new System.Drawing.Size(125, 23);
            this.DatabaseSelectMenu.TabIndex = 10;
            // 
            // CreditsLbl
            // 
            this.CreditsLbl.AutoSize = true;
            this.CreditsLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreditsLbl.Location = new System.Drawing.Point(656, 112);
            this.CreditsLbl.Name = "CreditsLbl";
            this.CreditsLbl.Size = new System.Drawing.Size(142, 57);
            this.CreditsLbl.TabIndex = 17;
            this.CreditsLbl.Text = "Credits:\r\nCracked: shokoloko\r\nTelegram: shokoloko1";
            // 
            // SeperatorLbl
            // 
            this.SeperatorLbl.AutoSize = true;
            this.SeperatorLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SeperatorLbl.Location = new System.Drawing.Point(398, 182);
            this.SeperatorLbl.Name = "SeperatorLbl";
            this.SeperatorLbl.Size = new System.Drawing.Size(77, 20);
            this.SeperatorLbl.TabIndex = 14;
            this.SeperatorLbl.Text = "Seperator:";
            // 
            // SeperatorTxtBox
            // 
            this.SeperatorTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SeperatorTxtBox.Location = new System.Drawing.Point(481, 183);
            this.SeperatorTxtBox.MaxLength = 1;
            this.SeperatorTxtBox.Name = "SeperatorTxtBox";
            this.SeperatorTxtBox.Size = new System.Drawing.Size(39, 23);
            this.SeperatorTxtBox.TabIndex = 13;
            this.SeperatorTxtBox.Text = ":";
            // 
            // ExactResultsCheckBox
            // 
            this.ExactResultsCheckBox.AutoSize = true;
            this.ExactResultsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExactResultsCheckBox.Checked = true;
            this.ExactResultsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExactResultsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExactResultsCheckBox.Location = new System.Drawing.Point(398, 211);
            this.ExactResultsCheckBox.Name = "ExactResultsCheckBox";
            this.ExactResultsCheckBox.Size = new System.Drawing.Size(94, 19);
            this.ExactResultsCheckBox.TabIndex = 16;
            this.ExactResultsCheckBox.Text = "Exact Results";
            this.ExactResultsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReloadDatabasesBtn
            // 
            this.ReloadDatabasesBtn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ReloadDatabasesBtn.Location = new System.Drawing.Point(529, 112);
            this.ReloadDatabasesBtn.Name = "ReloadDatabasesBtn";
            this.ReloadDatabasesBtn.Size = new System.Drawing.Size(125, 34);
            this.ReloadDatabasesBtn.TabIndex = 12;
            this.ReloadDatabasesBtn.Text = "Reload Databases";
            this.ReloadDatabasesBtn.UseVisualStyleBackColor = true;
            this.ReloadDatabasesBtn.Click += new System.EventHandler(this.ReloadDatabasesBtn_Click);
            // 
            // DatabaseLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExactResultsCheckBox);
            this.Controls.Add(this.SeperatorTxtBox);
            this.Controls.Add(this.SeperatorLbl);
            this.Controls.Add(this.CreditsLbl);
            this.Controls.Add(this.DatabaseSelectMenu);
            this.Controls.Add(this.ReloadDatabasesBtn);
            this.Controls.Add(this.LoadDatabaseBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.StopSearchBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.KeywordsLbl);
            this.Controls.Add(this.KeywordsTxtBox);
            this.Controls.Add(this.ResultsTxtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseLoader";
            this.Text = "Database Loader By Shokoloko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultsTxtBox;
        private System.Windows.Forms.TextBox KeywordsTxtBox;
        private System.Windows.Forms.Label KeywordsLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button StopSearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button LoadDatabaseBtn;
        private System.Windows.Forms.ComboBox DatabaseSelectMenu;
        private System.Windows.Forms.Label CreditsLbl;
        private System.Windows.Forms.Label SeperatorLbl;
        private System.Windows.Forms.TextBox SeperatorTxtBox;
        private System.Windows.Forms.CheckBox ExactResultsCheckBox;
        private System.Windows.Forms.Button ReloadDatabasesBtn;
    }
}

