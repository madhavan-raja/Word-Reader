namespace WordReader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.BrowseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileStatus = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PrevWord = new System.Windows.Forms.Button();
            this.NextWord = new System.Windows.Forms.Button();
            this.RateLabel = new System.Windows.Forms.Label();
            this.WPM = new System.Windows.Forms.NumericUpDown();
            this.WPMLabel = new System.Windows.Forms.Label();
            this.WordStatus = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ThemeToggleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WPM)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(13, 9);
            this.FileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(48, 18);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File:";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Location = new System.Drawing.Point(68, 6);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(98, 25);
            this.FilePath.TabIndex = 1;
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseFileButton.Location = new System.Drawing.Point(172, 6);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(49, 25);
            this.BrowseFileButton.TabIndex = 2;
            this.BrowseFileButton.Text = "...";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(227, 6);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 25);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileStatus
            // 
            this.FileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileStatus.Location = new System.Drawing.Point(12, 34);
            this.FileStatus.Name = "FileStatus";
            this.FileStatus.Size = new System.Drawing.Size(290, 18);
            this.FileStatus.TabIndex = 4;
            this.FileStatus.Text = "File Not Loaded";
            this.FileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(43, 55);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(228, 25);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Start";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PrevWord
            // 
            this.PrevWord.Enabled = false;
            this.PrevWord.Location = new System.Drawing.Point(12, 55);
            this.PrevWord.Name = "PrevWord";
            this.PrevWord.Size = new System.Drawing.Size(25, 25);
            this.PrevWord.TabIndex = 6;
            this.PrevWord.Text = "<";
            this.PrevWord.UseVisualStyleBackColor = true;
            this.PrevWord.Click += new System.EventHandler(this.PrevWord_Click);
            // 
            // NextWord
            // 
            this.NextWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextWord.Enabled = false;
            this.NextWord.Location = new System.Drawing.Point(277, 55);
            this.NextWord.Name = "NextWord";
            this.NextWord.Size = new System.Drawing.Size(25, 25);
            this.NextWord.TabIndex = 7;
            this.NextWord.Text = ">";
            this.NextWord.UseVisualStyleBackColor = true;
            this.NextWord.Click += new System.EventHandler(this.NextWord_Click);
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(12, 88);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(48, 18);
            this.RateLabel.TabIndex = 8;
            this.RateLabel.Text = "Rate:";
            this.RateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WPM
            // 
            this.WPM.Location = new System.Drawing.Point(66, 86);
            this.WPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WPM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WPM.Name = "WPM";
            this.WPM.Size = new System.Drawing.Size(90, 25);
            this.WPM.TabIndex = 9;
            this.WPM.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.WPM.ValueChanged += new System.EventHandler(this.WPM_ValueChanged);
            // 
            // WPMLabel
            // 
            this.WPMLabel.AutoSize = true;
            this.WPMLabel.Location = new System.Drawing.Point(162, 88);
            this.WPMLabel.Name = "WPMLabel";
            this.WPMLabel.Size = new System.Drawing.Size(32, 18);
            this.WPMLabel.TabIndex = 10;
            this.WPMLabel.Text = "WPM";
            this.WPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WordStatus
            // 
            this.WordStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WordStatus.Location = new System.Drawing.Point(200, 88);
            this.WordStatus.Name = "WordStatus";
            this.WordStatus.Size = new System.Drawing.Size(102, 18);
            this.WordStatus.TabIndex = 11;
            this.WordStatus.Text = "0 / 0";
            this.WordStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 114);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(290, 120);
            this.Output.TabIndex = 12;
            this.Output.Text = "Word";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ThemeToggleButton
            // 
            this.ThemeToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeToggleButton.Location = new System.Drawing.Point(12, 237);
            this.ThemeToggleButton.Name = "ThemeToggleButton";
            this.ThemeToggleButton.Size = new System.Drawing.Size(290, 25);
            this.ThemeToggleButton.TabIndex = 13;
            this.ThemeToggleButton.Text = "Switch to Dark Mode";
            this.ThemeToggleButton.UseVisualStyleBackColor = true;
            this.ThemeToggleButton.Click += new System.EventHandler(this.ThemeToggleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 274);
            this.Controls.Add(this.ThemeToggleButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.WordStatus);
            this.Controls.Add(this.WPMLabel);
            this.Controls.Add(this.WPM);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.NextWord);
            this.Controls.Add(this.PrevWord);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.FileStatus);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FileLabel);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(330, 280);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Word Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.OpenFileDialog BrowseFileDialog;
        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label FileStatus;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PrevWord;
        private System.Windows.Forms.Button NextWord;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.NumericUpDown WPM;
        private System.Windows.Forms.Label WPMLabel;
        private System.Windows.Forms.Label WordStatus;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button ThemeToggleButton;
    }
}

