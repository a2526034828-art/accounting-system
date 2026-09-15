namespace AccountingSystem.Core.Enums
{
    /// <summary>
    /// حالات المعاملات
    /// </summary>
    public enum TransactionStatus
    {
        /// <summary>
        /// مسودة
        /// </summary>
        Draft,

        /// <summary>
        /// معتمدة
        /// </summary>
        Approved,

        /// <summary>
        /// ملغاة
        /// </summary>
        Cancelled,

        /// <summary>
        /// قيد الانتظار
        /// </summary>
        Pending,

        /// <summary>
        /// مرفوضة
        /// </summary>
        Rejected
    }
}
