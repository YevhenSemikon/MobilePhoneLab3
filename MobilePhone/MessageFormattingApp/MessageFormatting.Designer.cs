namespace MessageFormattingApp {
    partial class MessageFormatting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.FormattingListComboBox = new System.Windows.Forms.ComboBox();
            this.OutputMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AutoScrollCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FormattingListComboBox
            // 
            this.FormattingListComboBox.Items.AddRange(new object[] {
            "None",
            "Start with Date",
            "End with Date",
            "UpperCase",
            "LowerCase"});
            this.FormattingListComboBox.Location = new System.Drawing.Point(12, 22);
            this.FormattingListComboBox.Name = "FormattingListComboBox";
            this.FormattingListComboBox.Size = new System.Drawing.Size(134, 21);
            this.FormattingListComboBox.TabIndex = 0;
            this.FormattingListComboBox.Text = "Select Formatting";
            this.FormattingListComboBox.SelectedIndexChanged += new System.EventHandler(this.FormattingListComboBox_SelectedIndexChanged);
            // 
            // OutputMessageRichTextBox
            // 
            this.OutputMessageRichTextBox.Location = new System.Drawing.Point(12, 49);
            this.OutputMessageRichTextBox.Name = "OutputMessageRichTextBox";
            this.OutputMessageRichTextBox.ReadOnly = true;
            this.OutputMessageRichTextBox.Size = new System.Drawing.Size(260, 200);
            this.OutputMessageRichTextBox.TabIndex = 1;
            this.OutputMessageRichTextBox.Text = "";
            // 
            // AutoScrollCheckBox
            // 
            this.AutoScrollCheckBox.AutoSize = true;
            this.AutoScrollCheckBox.Location = new System.Drawing.Point(192, 26);
            this.AutoScrollCheckBox.Name = "AutoScrollCheckBox";
            this.AutoScrollCheckBox.Size = new System.Drawing.Size(77, 17);
            this.AutoScrollCheckBox.TabIndex = 2;
            this.AutoScrollCheckBox.Text = "Auto Scroll";
            this.AutoScrollCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AutoScrollCheckBox);
            this.Controls.Add(this.OutputMessageRichTextBox);
            this.Controls.Add(this.FormattingListComboBox);
            this.MaximizeBox = false;
            this.Name = "MessageFormatting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageFormatting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FormattingListComboBox;
        private System.Windows.Forms.RichTextBox OutputMessageRichTextBox;
        private System.Windows.Forms.CheckBox AutoScrollCheckBox;
    }
}

