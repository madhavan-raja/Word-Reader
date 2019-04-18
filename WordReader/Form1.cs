using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WordReader
{
    public partial class MainForm : Form
    {
        static string[] words;
        static int wordCount;
        static bool isRunning = false;
        static int wpm;

        static bool isDarkMode = false;

        Color darkColor = Color.Black;

        Color lightColor = Color.Gainsboro;
        Color midLightColor = Color.WhiteSmoke;
        Color lighterColor = Color.White;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            BrowseFileDialog.ShowDialog();
            FilePath.Text = BrowseFileDialog.FileName;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText(FilePath.Text).Replace(System.Environment.NewLine, " ");
                words = content.Split(' ');

                FileStatus.Text = "Loaded " + Path.GetFileName(FilePath.Text);
                ResetFlow();

                PauseButton.Enabled = true;
                PrevWord.Enabled = true;
                NextWord.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
                StopFlow();
            else
                StartFlow();
        }

        private void WPM_ValueChanged(object sender, EventArgs e)
        {
            wpm = (int)WPM.Value;
            MainTimer.Interval = 60000 / wpm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            wpm = (int)WPM.Value;
            MainTimer.Interval = 60000 / wpm;
            EnableLightMode();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (isRunning)
                StepFlow();
        }

        private void StartFlow()
        {
            MainTimer.Interval = 60000 / wpm;
            MainTimer.Start();
            PauseButton.Text = "Stop";
            isRunning = true;
        }

        private void StopFlow()
        {
            MainTimer.Stop();
            PauseButton.Text = "Start";
            isRunning = false;
        }

        private void StepFlow()
        {
            wordCount++;
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            if (wordCount >= words.Length)
                ResetFlow();
            else
            {
                words[wordCount].Replace('\n', ' ');
                Output.Text = words[wordCount];
                WordStatus.Text = (wordCount + 1) + " / " + words.Length;
            }
        }

        private void ResetFlow()
        {
            StopFlow();
            wordCount = 0;
            UpdateOutput();
        }

        private void NextWord_Click(object sender, EventArgs e)
        {
            StopFlow();

            if (wordCount >= words.Length)
                wordCount = 0;
            else
                wordCount++;

            UpdateOutput();
        }

        private void PrevWord_Click(object sender, EventArgs e)
        {
            StopFlow();

            if (wordCount <= 0)
                wordCount = words.Length - 1;
            else
                wordCount--;

            UpdateOutput();
        }

        private void ThemeToggleButton_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
                EnableLightMode();
            else
                EnableDarkMode();
        }

        private void EnableDarkMode()
        {
            isDarkMode = true;

            BackColor = darkColor;
            ForeColor = lightColor;

            FilePath.BackColor = darkColor;
            FilePath.ForeColor = lightColor;

            BrowseFileButton.BackColor = darkColor;
            BrowseFileButton.ForeColor = lightColor;

            LoadButton.BackColor = darkColor;
            LoadButton.ForeColor = lightColor;

            PauseButton.BackColor = darkColor;
            PauseButton.ForeColor = lightColor;

            PrevWord.BackColor = darkColor;
            PrevWord.ForeColor = lightColor;

            NextWord.BackColor = darkColor;
            NextWord.ForeColor = lightColor;

            WPM.BackColor = darkColor;
            WPM.ForeColor = lightColor;

            ThemeToggleButton.BackColor = darkColor;
            ThemeToggleButton.ForeColor = lightColor;

            ThemeToggleButton.Text = "Switch to Light Mode";
        }

        private void EnableLightMode()
        {
            isDarkMode = false;

            BackColor = midLightColor;
            ForeColor = darkColor;

            FilePath.BackColor = lighterColor;
            FilePath.ForeColor = darkColor;

            BrowseFileButton.BackColor = lightColor;
            BrowseFileButton.ForeColor = darkColor;

            LoadButton.BackColor = lightColor;
            LoadButton.ForeColor = darkColor;

            PauseButton.BackColor = lightColor;
            PauseButton.ForeColor = darkColor;

            PrevWord.BackColor = lightColor;
            PrevWord.ForeColor = darkColor;

            NextWord.BackColor = lightColor;
            NextWord.ForeColor = darkColor;

            WPM.BackColor = lighterColor;
            WPM.ForeColor = darkColor;

            ThemeToggleButton.BackColor = lightColor;
            ThemeToggleButton.ForeColor = darkColor;

            ThemeToggleButton.Text = "Switch to Dark Mode";
        }
    }
}
