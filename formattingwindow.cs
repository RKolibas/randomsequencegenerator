using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RandomSequenceGenerator {
    public partial class FormattingWindow: Form {

        public FormattingWindow formatting;
        public bool showDateTime = true;
        public bool showSettings = true;
        public string separationString = ", ";

        public FormattingWindow() {
            InitializeComponent();
            formatting = this;
            SeparationField.Text = separationString;
        }

        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void ApplyButton_Click(object sender, EventArgs e) {
            separationString = SeparationField.Text;
            showDateTime = this.DateTimeCheckBox.Checked;
            showSettings = this.SettingsCheckBox.Checked;
            this.Hide();
        }
    }
}
