namespace RandomSequenceGenerator {
    partial class MainWindow {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.MinimumField = new System.Windows.Forms.RichTextBox();
            this.MinimumText = new System.Windows.Forms.TextBox();
            this.MaximumText = new System.Windows.Forms.TextBox();
            this.MaximumField = new System.Windows.Forms.RichTextBox();
            this.SequenceText = new System.Windows.Forms.TextBox();
            this.SequenceField = new System.Windows.Forms.RichTextBox();
            this.NoRepeatsText = new System.Windows.Forms.TextBox();
            this.NoRepeatsCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnlockWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarFront = new System.Windows.Forms.PictureBox();
            this.ProgressBarBack = new System.Windows.Forms.PictureBox();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBack)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.Control;
            this.GenerateButton.Location = new System.Drawing.Point(190, 180);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(74, 23);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // MinimumField
            // 
            this.MinimumField.Location = new System.Drawing.Point(160, 34);
            this.MinimumField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumField.Multiline = false;
            this.MinimumField.Name = "MinimumField";
            this.MinimumField.Size = new System.Drawing.Size(102, 18);
            this.MinimumField.TabIndex = 1;
            this.MinimumField.Text = "";
            this.MinimumField.TextChanged += new System.EventHandler(this.MinimumField_TextChanged);
            this.MinimumField.Leave += new System.EventHandler(this.MinimumField_FocusLeave);
            // 
            // MinimumText
            // 
            this.MinimumText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinimumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinimumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumText.Location = new System.Drawing.Point(11, 36);
            this.MinimumText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumText.Name = "MinimumText";
            this.MinimumText.ReadOnly = true;
            this.MinimumText.Size = new System.Drawing.Size(110, 13);
            this.MinimumText.TabIndex = 2;
            this.MinimumText.TabStop = false;
            this.MinimumText.Text = "Minimum Value:";
            // 
            // MaximumText
            // 
            this.MaximumText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaximumText.Location = new System.Drawing.Point(11, 72);
            this.MaximumText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumText.Name = "MaximumText";
            this.MaximumText.ReadOnly = true;
            this.MaximumText.Size = new System.Drawing.Size(112, 13);
            this.MaximumText.TabIndex = 3;
            this.MaximumText.TabStop = false;
            this.MaximumText.Text = "Maximum Value:";
            // 
            // MaximumField
            // 
            this.MaximumField.Location = new System.Drawing.Point(160, 70);
            this.MaximumField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumField.Multiline = false;
            this.MaximumField.Name = "MaximumField";
            this.MaximumField.Size = new System.Drawing.Size(102, 18);
            this.MaximumField.TabIndex = 4;
            this.MaximumField.Text = "";
            this.MaximumField.TextChanged += new System.EventHandler(this.MaximumField_TextChanged);
            this.MaximumField.Leave += new System.EventHandler(this.MaximumField_FocusLeave);
            // 
            // SequenceText
            // 
            this.SequenceText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SequenceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SequenceText.Location = new System.Drawing.Point(11, 108);
            this.SequenceText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SequenceText.Name = "SequenceText";
            this.SequenceText.ReadOnly = true;
            this.SequenceText.Size = new System.Drawing.Size(87, 13);
            this.SequenceText.TabIndex = 5;
            this.SequenceText.TabStop = false;
            this.SequenceText.Text = "Sequence Length:";
            // 
            // SequenceField
            // 
            this.SequenceField.BackColor = System.Drawing.SystemColors.Window;
            this.SequenceField.Location = new System.Drawing.Point(160, 106);
            this.SequenceField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SequenceField.Multiline = false;
            this.SequenceField.Name = "SequenceField";
            this.SequenceField.Size = new System.Drawing.Size(102, 18);
            this.SequenceField.TabIndex = 6;
            this.SequenceField.Text = "";
            this.SequenceField.TextChanged += new System.EventHandler(this.SequenceField_TextChanged);
            this.SequenceField.Leave += new System.EventHandler(this.SequenceField_FocusLeave);
            // 
            // NoRepeatsText
            // 
            this.NoRepeatsText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoRepeatsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoRepeatsText.Location = new System.Drawing.Point(11, 144);
            this.NoRepeatsText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NoRepeatsText.Name = "NoRepeatsText";
            this.NoRepeatsText.ReadOnly = true;
            this.NoRepeatsText.Size = new System.Drawing.Size(74, 13);
            this.NoRepeatsText.TabIndex = 7;
            this.NoRepeatsText.TabStop = false;
            this.NoRepeatsText.Text = "No Repeats:";
            // 
            // NoRepeatsCheckBox
            // 
            this.NoRepeatsCheckBox.AutoSize = true;
            this.NoRepeatsCheckBox.Location = new System.Drawing.Point(160, 144);
            this.NoRepeatsCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NoRepeatsCheckBox.Name = "NoRepeatsCheckBox";
            this.NoRepeatsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.NoRepeatsCheckBox.TabIndex = 8;
            this.NoRepeatsCheckBox.UseVisualStyleBackColor = true;
            this.NoRepeatsCheckBox.CheckedChanged += new System.EventHandler(this.NoRepeatsCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 1);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PreferencesToolStripMenuItem
            // 
            this.PreferencesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PreferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormattingToolStripMenuItem,
            this.UnlockWindowToolStripMenuItem});
            this.PreferencesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem";
            this.PreferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.PreferencesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.PreferencesToolStripMenuItem.Text = "Preferences";
            // 
            // FormattingToolStripMenuItem
            // 
            this.FormattingToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormattingToolStripMenuItem.Name = "FormattingToolStripMenuItem";
            this.FormattingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FormattingToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.FormattingToolStripMenuItem.Text = "Formatting";
            this.FormattingToolStripMenuItem.Click += new System.EventHandler(this.FormattingToolStripMenuItem_Click);
            // 
            // UnlockWindowToolStripMenuItem
            // 
            this.UnlockWindowToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UnlockWindowToolStripMenuItem.Name = "UnlockWindowToolStripMenuItem";
            this.UnlockWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.UnlockWindowToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.UnlockWindowToolStripMenuItem.Text = "Unlock Window";
            this.UnlockWindowToolStripMenuItem.Click += new System.EventHandler(this.UnlockWindowToolStripMenuItem_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreferencesToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.MenuStrip1.Size = new System.Drawing.Size(270, 24);
            this.MenuStrip1.TabIndex = 9;
            this.MenuStrip1.Text = "menuStrip";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ProgressBarFront
            // 
            this.ProgressBarFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgressBarFront.Image = ((System.Drawing.Image)(resources.GetObject("ProgressBarFront.Image")));
            this.ProgressBarFront.Location = new System.Drawing.Point(3, 183);
            this.ProgressBarFront.Name = "ProgressBarFront";
            this.ProgressBarFront.Size = new System.Drawing.Size(94, 24);
            this.ProgressBarFront.TabIndex = 14;
            this.ProgressBarFront.TabStop = false;
            this.ProgressBarFront.Visible = false;
            // 
            // ProgressBarBack
            // 
            this.ProgressBarBack.Image = ((System.Drawing.Image)(resources.GetObject("ProgressBarBack.Image")));
            this.ProgressBarBack.Location = new System.Drawing.Point(0, 180);
            this.ProgressBarBack.Name = "ProgressBarBack";
            this.ProgressBarBack.Size = new System.Drawing.Size(100, 30);
            this.ProgressBarBack.TabIndex = 15;
            this.ProgressBarBack.TabStop = false;
            this.ProgressBarBack.Visible = false;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Location = new System.Drawing.Point(105, 188);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgressBarLabel.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 209);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.ProgressBarFront);
            this.Controls.Add(this.ProgressBarBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NoRepeatsCheckBox);
            this.Controls.Add(this.NoRepeatsText);
            this.Controls.Add(this.SequenceField);
            this.Controls.Add(this.SequenceText);
            this.Controls.Add(this.MaximumField);
            this.Controls.Add(this.MaximumText);
            this.Controls.Add(this.MinimumText);
            this.Controls.Add(this.MinimumField);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Sequence Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.RichTextBox MinimumField;
        private System.Windows.Forms.TextBox MinimumText;
        private System.Windows.Forms.TextBox MaximumText;
        private System.Windows.Forms.RichTextBox MaximumField;
        private System.Windows.Forms.TextBox SequenceText;
        private System.Windows.Forms.RichTextBox SequenceField;
        private System.Windows.Forms.TextBox NoRepeatsText;
        private System.Windows.Forms.CheckBox NoRepeatsCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem PreferencesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnlockWindowToolStripMenuItem;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox ProgressBarFront;
        private System.Windows.Forms.PictureBox ProgressBarBack;
        private System.Windows.Forms.Label ProgressBarLabel;
    }
}

