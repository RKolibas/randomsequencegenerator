using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSequenceGenerator {

    public partial class MainWindow: Form {

        private int minimum = 0;
        private int maximum = 0;
        private int sequenceLength = 0;
        private int counterLimit = 5000;
        private float generationProgress = 0;
        private float repeatCheckProgress = 0;
        private float printProgress = 0;
        private bool noRepeats = false;
        private bool isLocked = true;
        private bool isGenerationProgressing = false;
        private bool isRepeatCheckProgressing = false;
        private bool isPrintProgressing = false;
        private string printedSequence = "";
        private List<int> randList = new List<int>();
        private List<int> uniqueList = new List<int>();
        private Random rand = new Random();
        private BackgroundWorker bgWorker = new BackgroundWorker();
        private DisplayWindow display = new DisplayWindow();
        private FormattingWindow formatting = new FormattingWindow();

        public MainWindow() {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            ReadInputFields();
        }

        private void ReadInputFields() {
            if(!string.IsNullOrWhiteSpace(MinimumField.Text) && !string.IsNullOrWhiteSpace(MaximumField.Text) && !string.IsNullOrWhiteSpace(SequenceField.Text)) {
                minimum = Int32.Parse(MinimumField.Text);
                maximum = Int32.Parse(MaximumField.Text);
                sequenceLength = Int32.Parse(SequenceField.Text);
                GenerateRandomSequence();
            }
            else {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Please complete each field.", "Warning");
            }
        }

        private async void GenerateRandomSequence() {
            await SequenceGenerationAsync();
            generationProgress = 0;
            if(noRepeats) {
                await RepeatCheckAsync();
                repeatCheckProgress = 0;
            }
            PrintRandomSequenceAsync(randList);
        }

        private async Task SequenceGenerationAsync() {
            ProgressBarFront.Show();
            ProgressBarBack.Show();
            ProgressBarLabel.Text = "Generating...";
            isGenerationProgressing = true;
            await Task.Run(() => {
                for(int i = 0; i < sequenceLength; i++) {
                    randList.Add(rand.Next(minimum, maximum + 1));
                    generationProgress = i;
                    if((i % counterLimit) == 0) {
                        Thread.Sleep(1);
                    }
                }
            });
            isGenerationProgressing = false;
        }

        private async Task RepeatCheckAsync() {
            ProgressBarLabel.Text = "Replacing...";
            isRepeatCheckProgressing = true;
            await Task.Run(() => {
                for(int x = 0; x < randList.Count; x++) {
                    if(uniqueList.Contains(randList[x])) {
                        randList[x] = rand.Next(minimum, maximum + 1);
                        x--;
                    }
                    else {
                        uniqueList.Add(randList[x]);
                        repeatCheckProgress = x;
                        if((x % counterLimit) == 0) {
                            Thread.Sleep(1);
                        }
                    }
                }
                uniqueList.Clear();
            });
            isRepeatCheckProgressing = false;
        }

        private async void PrintRandomSequenceAsync(List<int> randList) {
            int x = 0;
            ProgressBarLabel.Text = "Converting...";
            isPrintProgressing = true;
            await Task.Run(() => {
                foreach(int i in randList) {
                    if(x == randList.Count - 1) {
                        printedSequence += i;
                    }
                    else {
                        printedSequence += i + formatting.separationString;
                    }
                    x++;
                    printProgress = x;
                    if((x % counterLimit) == 0) {
                        Thread.Sleep(1);
                    }
                }
            });
            ApplyFormatting();
            ResetValues();
        }

        private void ApplyFormatting() {
            if(display.Visible == false) {
                display.Location = new Point(this.Location.X + 275, this.Location.Y);
                display.Show();
            }
            if(formatting.showDateTime) {
                display.DisplayText.Text += DateTime.Now + " ";
            }
            if(formatting.showSettings) {
                display.DisplayText.Text += "Minimum Value: " + minimum + " Maximum Value: " + maximum + " Sequence Length: " + sequenceLength + " No Repeats: " + noRepeats + "\n" + "\n";
            }
            display.DisplayText.Text += printedSequence + "\n" + "\n";
            if(formatting.showDateTime && formatting.showSettings) {
                display.DisplayText.Text += "\n";
            }
        }

        private void ResetValues() {
            display.ScrollToEnd();
            randList.Clear();
            printProgress = 0;
            printedSequence = "";
            ProgressBarLabel.Text = "";
            isPrintProgressing = false;
            ProgressBarBack.Hide();
            ProgressBarFront.Hide();
        }

        private void NoRepeatsCheckBox_CheckedChanged(object sender, EventArgs e) {
            if(NoRepeatsCheckBox.Checked) {
                noRepeats = true;
                if(!string.IsNullOrWhiteSpace(SequenceField.Text) && Int32.Parse(SequenceField.Text) > Int32.Parse(MaximumField.Text)) {
                    SequenceField.Text = MaximumField.Text;
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Sequence Length cannot be greater than the Maximum Value without repeat values.", "Warning");
                }
            }
            else if(!NoRepeatsCheckBox.Checked) {
                noRepeats = false;
            }
        }

        private void MinimumField_FocusLeave(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(MinimumField.Text) && !String.IsNullOrWhiteSpace(MaximumField.Text) && Int32.Parse(MinimumField.Text) > Int32.Parse(MaximumField.Text)) {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Minimum Value cannot be greater than the Maximum Value.", "Warning");
                MinimumField.Text = "";
            }
        }

        private void MaximumField_FocusLeave(object sender, EventArgs e) {
            if(MaximumField.Text == "0") {
                MaximumField.Text = ZeroWarning(MaximumField.Text);
            }
            if(!String.IsNullOrWhiteSpace(MinimumField.Text) && !String.IsNullOrWhiteSpace(MaximumField.Text) && Int32.Parse(MinimumField.Text) > Int32.Parse(MaximumField.Text)) {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Minimum Value cannot be greater than the Maximum Value.", "Warning");
                MaximumField.Text = "";
            }
            if(!String.IsNullOrWhiteSpace(MaximumField.Text) && !String.IsNullOrWhiteSpace(SequenceField.Text) && noRepeats && Int32.Parse(SequenceField.Text) > Int32.Parse(MaximumField.Text)) {
                SequenceField.Text = MaximumField.Text;
            }
        }

        private string ZeroWarning(string field) {
            System.Media.SystemSounds.Hand.Play();
            MessageBox.Show("Total value must be a non-zero integer.", "Warning");
            return field = "";
        }

        private void SequenceField_FocusLeave(object sender, EventArgs e) {
            if(SequenceField.Text == "0") {
                SequenceField.Text = ZeroWarning(MaximumField.Text);
            }
            if(noRepeats && !String.IsNullOrWhiteSpace(MaximumField.Text) && !String.IsNullOrWhiteSpace(SequenceField.Text) && Int32.Parse(SequenceField.Text) > Int32.Parse(MaximumField.Text)) {
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Sequence Length cannot be greater than the Maximum Value without repeat values.", "Warning");
                SequenceField.Text = MaximumField.Text;
            }
        }

        private void MinimumField_TextChanged(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(MinimumField.Text)) {
                if(MinimumField.Text != DigitCheck(MinimumField.Text)) {
                    MinimumField.Text = DigitCheck(MinimumField.Text);
                }
            }
        }

        private void MaximumField_TextChanged(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(MaximumField.Text)) {
                if(MaximumField.Text != DigitCheck(MaximumField.Text)) {
                    MaximumField.Text = DigitCheck(MaximumField.Text);
                }
            }
        }

        private void SequenceField_TextChanged(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(SequenceField.Text)) {
                if(SequenceField.Text != DigitCheck(SequenceField.Text)) {
                    SequenceField.Text = DigitCheck(SequenceField.Text);
                }
            }
        }

        private string DigitCheck(string text) {
            bool isTextNumerical = true;
            List<char> charList = text.ToList<char>();
            List<char> newList = new List<char>();
            foreach(char c in charList) {
                if(!Char.IsDigit(c)) {
                    isTextNumerical = false;
                }
                else {
                    newList.Add(c);
                }
            }
            if(!isTextNumerical) {
                StringBuilder builder = new StringBuilder();
                foreach(char c in newList) {
                    builder.Append(c);
                }
                System.Media.SystemSounds.Hand.Play();
                return builder.ToString();
            }
            else {
                return text;
            }
        }

        private void FormattingToolStripMenuItem_Click(object sender, EventArgs e) {
            if(formatting.Visible == false) {
                formatting.Location = new Point(this.Location.X + 35, this.Location.Y + 35);
                formatting.Show();
            }
        }

        private void UnlockWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            if(isLocked) {
                UnlockWindowToolStripMenuItem.Text = "Lock Window";
                this.FormBorderStyle = FormBorderStyle.Sizable;
                isLocked = false;
            }
            else if (!isLocked) {
                UnlockWindowToolStripMenuItem.Text = "Unlock Window";
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                isLocked = true;
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e) {
            UpdateProgressBar();
        }

        private void UpdateProgressBar() {
            if(isGenerationProgressing) {
                ProgressBarFront.Width = (int)Math.Round(generationProgress / sequenceLength * 94);
            }
            if(isRepeatCheckProgressing) {
                ProgressBarFront.Width = (int)Math.Round(repeatCheckProgress / randList.Count * 94);
            }
            if(isPrintProgressing) {
                ProgressBarFront.Width = (int)Math.Round(printProgress / randList.Count * 94);
            }
        }
    }
}
