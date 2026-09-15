namespace AccountingSystem.Common.Extensions
{
    /// <summary>
    /// امتدادات للأرقام العشرية
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// تقريب الرقم إلى منزلتين عشريتين
        /// </summary>
        public static decimal RoundTwoDecimals(this decimal value)
        {
            return decimal.Round(value, 2);
        }

        /// <summary>
        /// التحقق من أن الرقم موجب
        /// </summary>
        public static bool IsPositive(this decimal value)
        {
            return value > 0;
        }

        /// <summary>
        /// التحقق من أن الرقم سالب
        /// </summary>
        public static bool IsNegative(this decimal value)
        {
            return value < 0;
        }

        /// <summary>
        /// التحقق من أن الرقم يساوي صفر
        /// </summary>
        public static bool IsZero(this decimal value)
        {
            return value == 0;
        }

        /// <summary>
        /// تنسيق الرقم كعملة
        /// </summary>
        public static string FormatAsCurrency(this decimal value, string currencySymbol = "ر.س")
        {
            return $"{value:N2} {currencySymbol}";
        }
    }
}
