using MobilePhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageFormattingApp {

    public partial class MessageFormatting : Form {
        private int disabledItemIndex = -1;
        Font myFont = new Font("Aerial", 10, FontStyle.Regular | FontStyle.Underline);

        SimCorpMobilePhone mobile = new SimCorpMobilePhone();
        SMSProvider.FormatDelegate Formatter = SMSProvider.NoneFormat;

        public MessageFormatting() {
            InitializeComponent();
            this.FormattingListComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.FormattingListComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.FormattingListComboBox_DrawItem);
            mobile.SMSProvider.SMSReceived += ShowMessage;
            SMSProvider.SMSStartSendingDelegate startDel = mobile.SMSProvider.ReceiveMessage;
            startDel.BeginInvoke(100, null, null);
        }
        public void ShowMessage(string message) {
            if (OutputMessageRichTextBox.InvokeRequired) { Invoke(new SMSProvider.SMSReceivedDelegate(ShowMessage), message); }
            else {
                string formattedMessage = Formatter(message);
                OutputMessageRichTextBox.AppendText($"{formattedMessage}{ Environment.NewLine}");
                if (AutoScrollCheckBox.Checked) {
                    OutputMessageRichTextBox.ScrollToCaret();
                }
            }
        }
        private void FormattingListComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            disabledItemIndex = FormattingListComboBox.SelectedIndex;
            string itemName = FormattingListComboBox.SelectedItem.ToString();
            if (itemName == "None") { Formatter = SMSProvider.NoneFormat; }
            else if (itemName == "Start with Date") { Formatter = SMSProvider.StartWithDate; }
            else if (itemName == "End with Date") { Formatter = SMSProvider.EndWithDate; }
            else if (itemName == "UpperCase") { Formatter = SMSProvider.UpperFormat; }
            else if (itemName == "LowerCase") { Formatter = SMSProvider.LowerFormat; }
        }
        private void FormattingListComboBox_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index == disabledItemIndex) {
                e.Graphics.DrawString(FormattingListComboBox.Items[e.Index].ToString(), myFont, Brushes.Gray, e.Bounds);
            }
            else {
                e.DrawBackground();
                e.Graphics.DrawString(FormattingListComboBox.Items[e.Index].ToString(), myFont, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }
    }
}


