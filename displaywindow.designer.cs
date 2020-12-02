namespace RandomSequenceGenerator {
    partial class DisplayWindow {
    
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayWindow));
            this.DisplayText = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.BackColor = System.Drawing.SystemColors.Window;
            this.DisplayText.Location = new System.Drawing.Point(10, 10);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.ReadOnly = true;
            this.DisplayText.Size = new System.Drawing.Size(760, 516);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(10, 532);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DisplayText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(249, 0);
            this.Name = "DisplayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Random Sequence Generator Display";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox DisplayText;
        private System.Windows.Forms.Button SaveButton;
    }
}
