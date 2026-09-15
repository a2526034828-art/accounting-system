using System;
using System.Collections.Generic;

namespace AccountingSystem.Core.Models
{
    /// <summary>
    /// نموذج الحساب - يمثل حسابًا في النظام المحاسبي
    /// </summary>
    public class Account
    {
        /// <summary>
        /// معرف الحساب الفريد
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// رقم الحساب (مثل: 1-1-1 للأصول)
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// اسم الحساب
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// الوصف التفصيلي للحساب
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// نوع الحساب (أصل، التزام، رأس مال، إيراد، مصروف)
        /// </summary>
        public int AccountTypeId { get; set; }

        /// <summary>
        /// طبيعة الحساب (مدين، دائن)
        /// </summary>
        public string Nature { get; set; }

        /// <summary>
        /// الرصيد الافتتاحي
        /// </summary>
        public decimal OpeningBalance { get; set; }

        /// <summary>
        /// الرصيد الحالي
        /// </summary>
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// معرف الحساب الأب (للحسابات التفصيلية)
        /// </summary>
        public int? ParentAccountId { get; set; }

        /// <summary>
        /// حالة الحساب (نشط، معطل)
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ملف أرشيفي
        /// </summary>
        public bool IsArchived { get; set; } = false;

        /// <summary>
        /// الحسابات الفرعية
        /// </summary>
        public virtual ICollection<Account> SubAccounts { get; set; } = new List<Account>();
    }
}
