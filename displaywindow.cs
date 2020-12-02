using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandomSequenceGenerator {
    public partial class DisplayWindow: Form {

        public DisplayWindow display;

        public DisplayWindow() {
            InitializeComponent();
            display = this;
        }

        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = true;  
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All files (*.*)|*.*|Text Files (*.txt)|*.txt";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK) {
                using(StreamWriter sw = new StreamWriter(sfd.FileName)) {
                    sw.Write(DisplayText.Text);
                }
            }
        }

        public void ScrollToEnd() {
            DisplayText.SelectionStart = DisplayText.Text.Length;
            DisplayText.SelectionLength = 0;
            DisplayText.ScrollToCaret();
        }
    }
}
