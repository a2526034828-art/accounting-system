using AccountingSystem.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountingSystem.Core.Interfaces
{
    /// <summary>
    /// واجهة خدمة الحسابات
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// الحصول على جميع الحسابات
        /// </summary>
        Task<IEnumerable<Account>> GetAllAccountsAsync();

        /// <summary>
        /// الحصول على حساب بواسطة المعرف
        /// </summary>
        Task<Account> GetAccountByIdAsync(int id);

        /// <summary>
        /// إنشاء حساب جديد
        /// </summary>
        Task<Account> CreateAccountAsync(Account account);

        /// <summary>
        /// تحديث حساب
        /// </summary>
        Task<Account> UpdateAccountAsync(Account account);

        /// <summary>
        /// حذف حساب
        /// </summary>
        Task<bool> DeleteAccountAsync(int id);

        /// <summary>
        /// الحصول على رصيد الحساب
        /// </summary>
        Task<decimal> GetAccountBalanceAsync(int accountId);

        /// <summary>
        /// البحث عن حسابات بواسطة الاسم
        /// </summary>
        Task<IEnumerable<Account>> SearchAccountsAsync(string searchTerm);

        /// <summary>
        /// الحصول على الحسابات النشطة
        /// </summary>
        Task<IEnumerable<Account>> GetActiveAccountsAsync();
    }
}
