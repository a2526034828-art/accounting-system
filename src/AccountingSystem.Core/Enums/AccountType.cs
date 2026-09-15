namespace AccountingSystem.Core.Enums
{
    /// <summary>
    /// أنواع الحسابات
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// أصول
        /// </summary>
        Asset = 1,

        /// <summary>
        /// التزامات
        /// </summary>
        Liability = 2,

        /// <summary>
        /// رأس المال
        /// </summary>
        Equity = 3,

        /// <summary>
        /// إيرادات
        /// </summary>
        Revenue = 4,

        /// <summary>
        /// مصروفات
        /// </summary>
        Expense = 5
    }
}
