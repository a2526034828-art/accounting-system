using System;

namespace AccountingSystem.Core.Models
{
    /// <summary>
    /// نموذج المعاملة - يمثل معاملة محاسبية في النظام
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// معرف المعاملة الفريد
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// رقم المعاملة/الإيصال
        /// </summary>
        public string TransactionNumber { get; set; }

        /// <summary>
        /// تاريخ المعاملة
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// الوصف/التفاصيل
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// معرف الحساب المدين
        /// </summary>
        public int DebitAccountId { get; set; }

        /// <summary>
        /// معرف الحساب الدائن
        /// </summary>
        public int CreditAccountId { get; set; }

        /// <summary>
        /// المبلغ
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// حالة المعاملة (مسودة، معتمدة، ملغاة)
        /// </summary>
        public string Status { get; set; } = "Draft";

        /// <summary>
        /// معرف المستخدم الذي أنشأ المعاملة
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// معرف المستخدم الذي اعتمد المعاملة
        /// </summary>
        public int? ApprovedByUserId { get; set; }

        /// <summary>
        /// تاريخ الاعتماد
        /// </summary>
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ملاحظات إضافية
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// المرجع الخارجي (فاتورة، شيك، إلخ)
        /// </summary>
        public string ReferenceNumber { get; set; }
    }
}
