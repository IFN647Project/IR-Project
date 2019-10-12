namespace UniSearchSystem
{
    partial class MANTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MANTForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.WhiteSpaceAnalyzer = new System.Windows.Forms.RadioButton();
            this.StopAnalyzer = new System.Windows.Forms.RadioButton();
            this.KeywordAnalyzer = new System.Windows.Forms.RadioButton();
            this.StandardAnalyzer = new System.Windows.Forms.RadioButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AdvancedOptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(227, 56);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(407, 20);
            this.searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(641, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // WhiteSpaceAnalyzer
            // 
            this.WhiteSpaceAnalyzer.AutoSize = true;
            this.WhiteSpaceAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WhiteSpaceAnalyzer.Location = new System.Drawing.Point(26, 152);
            this.WhiteSpaceAnalyzer.Name = "WhiteSpaceAnalyzer";
            this.WhiteSpaceAnalyzer.Size = new System.Drawing.Size(133, 18);
            this.WhiteSpaceAnalyzer.TabIndex = 2;
            this.WhiteSpaceAnalyzer.TabStop = true;
            this.WhiteSpaceAnalyzer.Text = "WhiteSpace Analyzer";
            this.WhiteSpaceAnalyzer.UseVisualStyleBackColor = true;
            // 
            // StopAnalyzer
            // 
            this.StopAnalyzer.AutoSize = true;
            this.StopAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopAnalyzer.Location = new System.Drawing.Point(26, 176);
            this.StopAnalyzer.Name = "StopAnalyzer";
            this.StopAnalyzer.Size = new System.Drawing.Size(96, 18);
            this.StopAnalyzer.TabIndex = 3;
            this.StopAnalyzer.TabStop = true;
            this.StopAnalyzer.Text = "Stop Analyzer";
            this.StopAnalyzer.UseVisualStyleBackColor = true;
            // 
            // KeywordAnalyzer
            // 
            this.KeywordAnalyzer.AutoSize = true;
            this.KeywordAnalyzer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.KeywordAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.KeywordAnalyzer.Location = new System.Drawing.Point(26, 200);
            this.KeywordAnalyzer.Name = "KeywordAnalyzer";
            this.KeywordAnalyzer.Size = new System.Drawing.Size(115, 18);
            this.KeywordAnalyzer.TabIndex = 4;
            this.KeywordAnalyzer.TabStop = true;
            this.KeywordAnalyzer.Text = "Keyword Analyzer";
            this.KeywordAnalyzer.UseVisualStyleBackColor = false;
            // 
            // StandardAnalyzer
            // 
            this.StandardAnalyzer.AutoSize = true;
            this.StandardAnalyzer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StandardAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StandardAnalyzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardAnalyzer.Location = new System.Drawing.Point(26, 128);
            this.StandardAnalyzer.Name = "StandardAnalyzer";
            this.StandardAnalyzer.Size = new System.Drawing.Size(117, 18);
            this.StandardAnalyzer.TabIndex = 5;
            this.StandardAnalyzer.TabStop = true;
            this.StandardAnalyzer.Text = "Standard Analyzer";
            this.StandardAnalyzer.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Logo.BackgroundImage = global::UniSearchSystem.Properties.Resources.title;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(9, 16);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(203, 61);
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // AdvancedOptions
            // 
            this.AdvancedOptions.AutoSize = true;
            this.AdvancedOptions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AdvancedOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedOptions.Location = new System.Drawing.Point(22, 92);
            this.AdvancedOptions.Name = "AdvancedOptions";
            this.AdvancedOptions.Size = new System.Drawing.Size(155, 20);
            this.AdvancedOptions.TabIndex = 7;
            this.AdvancedOptions.Text = "Advanced Options";
            // 
            // MANTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniSearchSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.AdvancedOptions);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.StandardAnalyzer);
            this.Controls.Add(this.KeywordAnalyzer);
            this.Controls.Add(this.StopAnalyzer);
            this.Controls.Add(this.WhiteSpaceAnalyzer);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MANTForm";
            this.Text = "M.A.N.T Search";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton WhiteSpaceAnalyzer;
        private System.Windows.Forms.RadioButton StopAnalyzer;
        private System.Windows.Forms.RadioButton KeywordAnalyzer;
        private System.Windows.Forms.RadioButton StandardAnalyzer;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label AdvancedOptions;
    }
}

