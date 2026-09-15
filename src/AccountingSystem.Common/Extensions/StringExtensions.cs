using System;

namespace AccountingSystem.Common.Extensions
{
    /// <summary>
    /// امتدادات للنصوص (Strings)
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// التحقق من أن النص فارغ أو لا يحتوي على أحرف
        /// </summary>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// التحقق من أن النص فارغ، لا يحتوي على أحرف، أو يحتوي على فراغات فقط
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// قص النص للحد الأقصى من الأحرف
        /// </summary>
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        /// <summary>
        /// تحويل النص إلى حروف كبيرة
        /// </summary>
        public static string ToUpperArabic(this string value)
        {
            return value?.ToUpper() ?? string.Empty;
        }

        /// <summary>
        /// تحويل النص إلى حروف صغيرة
        /// </summary>
        public static string ToLowerArabic(this string value)
        {
            return value?.ToLower() ?? string.Empty;
        }
    }
}
