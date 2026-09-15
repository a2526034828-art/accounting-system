using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AccountingSystem.Core.Interfaces
{
    /// <summary>
    /// واجهة المستودع العامة - توفر العمليات الأساسية للبيانات
    /// </summary>
    /// <typeparam name="T">نوع الكيان</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// الحصول على جميع البيانات
        /// </summary>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// الحصول على سجل بواسطة المعرف
        /// </summary>
        Task<T> GetByIdAsync(int id);

        /// <summary>
        /// البحث عن بيانات باستخدام شروط
        /// </summary>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// إضافة سجل جديد
        /// </summary>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// إضافة عدة سجلات
        /// </summary>
        Task AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// تحديث سجل
        /// </summary>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// حذف سجل
        /// </summary>
        Task<bool> DeleteAsync(int id);

        /// <summary>
        /// حذف سجل
        /// </summary>
        Task<bool> DeleteAsync(T entity);

        /// <summary>
        /// عد عدد السجلات
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// عد السجلات حسب شروط معينة
        /// </summary>
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// التحقق من وجود سجل
        /// </summary>
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }
}
