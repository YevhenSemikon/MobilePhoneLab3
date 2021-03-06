﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone;

namespace UnitTestMobilePhone {
    [TestClass]
    public class FormattingTest {
        [TestMethod]
        public void NoneFormatMessage() {
            var expected = "None Changes";
            var actual = SMSProvider.NoneFormat(expected);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EndWithDateFormatMessage() {
            var message = "]";
            var expected = true;
            var actual = SMSProvider.EndWithDate(message).EndsWith(message);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StartWithDateFormatMessage() {
            var message = "[";
            var expected = true;
            var actual = SMSProvider.StartWithDate(message).StartsWith(message);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UpperCaseFormatMessage() {
            var message = "Check message";
            var expected = "CHECK MESSAGE";
            var actual = SMSProvider.UpperFormat(message);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LowerCaseFormatMessage() {
            var message = "Check message";
            var expected = "check message";
            var actual = SMSProvider.LowerFormat(message);
            Assert.AreEqual(expected, actual);
        }
    }
}
