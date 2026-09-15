# دليل المساهمة

## كيفية المساهمة في المشروع

### خطوات البدء

1. **Fork المستودع**
   - انقر على زر Fork في أعلى الصفحة

2. **استنساخ فرعك**
   ```bash
   git clone https://github.com/your-username/accounting-system.git
   cd accounting-system
   ```

3. **إنشاء فرع جديد**
   ```bash
   git checkout -b feature/اسم-الميزة
   ```

4. **إجراء التغييرات**
   - قم بتطوير الميزة الجديدة
   - اكتب اختبارات للتحقق
   - تأكد من اتباع معايير الكود

5. **Commit التغييرات**
   ```bash
   git add .
   git commit -m "إضافة: وصف الميزة الجديدة"
   ```

6. **Push للفرع**
   ```bash
   git push origin feature/اسم-الميزة
   ```

7. **فتح Pull Request**
   - اذهب لمستودعك على GitHub
   - انقر على "New Pull Request"
   - أضف وصفاً مفصلاً للتغييرات

## معايير الكود

### تسمية المتغيرات والدوال
```csharp
// الفئات - PascalCase
public class AccountManager { }

// الدوال - PascalCase
public void CreateAccount() { }

// المتغيرات - camelCase
private string accountName;

// الثوابت - UPPER_CASE
private const int MAX_ACCOUNTS = 100;
```

### التعليقات
```csharp
/// <summary>
/// إنشاء حساب جديد في النظام
/// </summary>
/// <param name="account">بيانات الحساب</param>
/// <returns>رقم الحساب الجديد</returns>
public int CreateAccount(Account account)
{
    // التحقق من صحة البيانات
    if (account == null)
        throw new ArgumentNullException(nameof(account));
    
    // حفظ الحساب
    return _accountRepository.Add(account);
}
```

### الاختبارات
```csharp
[TestClass]
public class AccountManagerTests
{
    [TestMethod]
    public void CreateAccount_ValidData_ReturnsAccountId()
    {
        // Arrange
        var account = new Account { Name = "Test" };
        
        // Act
        var result = _manager.CreateAccount(account);
        
        // Assert
        Assert.IsTrue(result > 0);
    }
}
```

## رسائل الـ Commit

استخدم الصيغة التالية:
```
نوع: وصف قصير

وصف مفصل إضافي إذا لزم الأمر

الأنواع:
- إضافة: ميزة جديدة
- تصحيح: إصلاح خطأ
- تحسين: تحسين الأداء أو الشفرة
- توثيق: تحديث التوثيق
- اختبار: إضافة أو تحديث الاختبارات
```

مثال:
```
إضافة: نموذج إدارة الحسابات

- إضافة فئة AccountManager
- إضافة طرق CRUD الأساسية
- كتابة اختبارات الوحدة
```

## طلب المساعدة

- استخدم Issues للإبلاغ عن الأخطاء
- استخدم Discussions للأسئلة والاقتراحات
- تحقق من الإصدارات السابقة قبل الإبلاغ

شكراً لمساهمتك! 🙏
