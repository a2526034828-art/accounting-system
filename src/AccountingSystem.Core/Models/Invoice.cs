using System;
using System.Collections.Generic;

namespace AccountingSystem.Core.Models
{
    /// <summary>
    /// نموذج الفاتورة - يمثل فاتورة مبيعات أو شراء
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// معرف الفاتورة الفريد
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// رقم الفاتورة
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// نوع الفاتورة (مبيعات، شراء، مردود)
        /// </summary>
        public string InvoiceType { get; set; }

        /// <summary>
        /// تاريخ الفاتورة
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// تاريخ الاستحقاق
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// معرف العميل/المورد
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// إجمالي المبلغ قبل الضريبة
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// الخصم
        /// </summary>
        public decimal Discount { get; set; } = 0;

        /// <summary>
        /// الضريبة
        /// </summary>
        public decimal Tax { get; set; } = 0;

        /// <summary>
        /// إجمالي المبلغ
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// المبلغ المدفوع
        /// </summary>
        public decimal PaidAmount { get; set; } = 0;

        /// <summary>
        /// حالة الفاتورة (مسودة، مرسلة، مدفوعة، معلقة)
        /// </summary>
        public string Status { get; set; } = "Draft";

        /// <summary>
        /// العملة
        /// </summary>
        public string Currency { get; set; } = "SAR";

        /// <summary>
        /// الملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// معرف المستخدم الذي أنشأ الفاتورة
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// تفاصيل الفاتورة
        /// </summary>
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
    }
}
