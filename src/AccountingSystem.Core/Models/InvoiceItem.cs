namespace AccountingSystem.Core.Models
{
    /// <summary>
    /// نموذج تفاصيل الفاتورة
    /// </summary>
    public class InvoiceItem
    {
        /// <summary>
        /// معرف تفصيل الفاتورة الفريد
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// معرف الفاتورة
        /// </summary>
        public int InvoiceId { get; set; }

        /// <summary>
        /// وصف الصنف
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// الكمية
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// سعر الوحدة
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// الإجمالي (الكمية × السعر)
        /// </summary>
        public decimal LineTotal { get; set; }

        /// <summary>
        /// نسبة الخصم للسطر
        /// </summary>
        public decimal DiscountPercent { get; set; } = 0;

        /// <summary>
        /// رقم الصنف في الفاتورة
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// الفاتورة المرتبطة
        /// </summary>
        public virtual Invoice Invoice { get; set; }
    }
}
