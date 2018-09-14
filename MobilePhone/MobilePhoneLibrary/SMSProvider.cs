using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class SMSProvider {
        public delegate void SMSReceivedDelegate(string message);
        public delegate void SMSStartSendingDelegate(int messageNumber);
        public delegate string FormatDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;
        public void ReceiveMessage(int messageNumber) {
            for (int i = 0; i < messageNumber; i++) {
                System.Threading.Thread.Sleep(1000);
                RaiseSMSReceivedEvent($"Message #{i} received!");
            }
        }
        public void RaiseSMSReceivedEvent(string message) { SMSReceived?.Invoke(message); }
        public static string NoneFormat(string message) { return message; }
        public static string LowerFormat(string message) { return message.ToLower(); }
        public static string StartWithDate(string message) { return $"[{DateTime.Now}] {message}"; }
        public static string EndWithDate(string message) { return $"{message} [{DateTime.Now}]"; }
        public static string UpperFormat(string message) { return message.ToUpper(); }
    }
}
