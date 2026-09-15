using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountingSystem.Common.Utilities
{
    /// <summary>
    /// فئة مساعدة للتحقق من صحة البيانات
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// التحقق من أن المبلغ صحيح
        /// </summary>
        public static bool IsValidAmount(decimal amount)
        {
            return amount > 0 && amount <= decimal.MaxValue;
        }

        /// <summary>
        /// التحقق من أن الرقم القياسي صحيح
        /// </summary>
        public static bool IsValidAccountNumber(string accountNumber)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                return false;

            return !string.IsNullOrEmpty(accountNumber);
        }

        /// <summary>
        /// التحقق من أن رقم الفاتورة صحيح
        /// </summary>
        public static bool IsValidInvoiceNumber(string invoiceNumber)
        {
            return !string.IsNullOrWhiteSpace(invoiceNumber) && invoiceNumber.Length > 0;
        }

        /// <summary>
        /// التحقق من أن التاريخ صحيح
        /// </summary>
        public static bool IsValidDate(DateTime date)
        {
            return date != default(DateTime);
        }

        /// <summary>
        /// التحقق من أن النص ليس فارغًا
        /// </summary>
        public static bool IsValidString(string value, int minLength = 1, int maxLength = int.MaxValue)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            return value.Length >= minLength && value.Length <= maxLength;
        }

        /// <summary>
        /// التحقق من أن البريد الإلكتروني صحيح
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
