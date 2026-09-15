# هيكل المشروع

## شجرة المجلدات

```
accounting-system/
│
├── src/                          # كود المصدر
│   ├── AccountingSystem.Core/    # النواة والمنطق الأساسي
│   │   ├── Models/               # نماذج البيانات
│   │   ├── Enums/                # التعريفات
│   │   ├── Interfaces/           # الواجهات
│   │   └── Constants/            # الثوابت
│   │
│   ├── AccountingSystem.Data/    # طبقة الوصول للبيانات
│   │   ├── Context/              # Entity Framework Context
│   │   ├── Repositories/         # مستودعات البيانات
│   │   ├── Migrations/           # هجرات قاعدة البيانات
│   │   └── Seeders/              # بيانات البذور
│   │
│   ├── AccountingSystem.Services/# خدمات الأعمال
│   │   ├── Accounts/             # خدمات الحسابات
│   │   ├── Transactions/         # خدمات المعاملات
│   │   ├── Invoices/             # خدمات الفواتير
│   │   ├── Reports/              # خدمات التقارير
│   │   └── Validators/           # التحقق من الصحة
│   │
│   ├── AccountingSystem.API/     # واجهات REST API
│   │   ├── Controllers/          # وحدات التحكم
│   │   ├── DTOs/                 # نماذج نقل البيانات
│   │   ├── Middleware/           # البرامج الوسيطة
│   │   └── Startup/              # تكوين البدء
│   │
│   ├── AccountingSystem.UI/      # واجهات المستخدم
│   │   ├── Forms/                # نماذج WinForms
│   │   ├── Components/           # المكونات المخصصة
│   │   ├── Resources/            # الموارد (صور، أيقونات)
│   │   └── Themes/               # المظاهر
│   │
│   └── AccountingSystem.Common/  # الوظائف المشتركة
│       ├── Extensions/           # الامتدادات
│       ├── Utilities/            # الأدوات المساعدة
│       ├── Helpers/              # المساعدات
│       └── Logging/              # تسجيل الأحداث
│
├── tests/                         # الاختبارات
│   ├── AccountingSystem.Tests/   # اختبارات الوحدة
│   ├── AccountingSystem.IntegrationTests/ # اختبارات التكامل
│   └── AccountingSystem.E2ETests/ # اختبارات النهاية إلى النهاية
│
├── docs/                          # التوثيق
│   ├── API.md                    # توثيق API
│   ├── DATABASE.md               # توثيق قاعدة البيانات
│   ├── DEPLOYMENT.md             # توثيق النشر
│   └── USER_GUIDE.md             # دليل المستخدم
│
├── config/                        # ملفات الإعدادات
│   ├── appsettings.json          # الإعدادات الأساسية
│   ├── appsettings.Development.json
│   └── appsettings.Production.json
│
├── scripts/                       # السكريبتات
│   ├── database-setup.sql        # إعداد قاعدة البيانات
│   ├── seed-data.sql             # بيانات البذور
│   └── migrations.sh             # سكريبت الهجرات
│
├── .github/                       # إعدادات GitHub
│   ├── workflows/                # سير العمل الآلي
│   └── ISSUE_TEMPLATE/           # قوالب المشاكل
│
├── README.md                      # ملف البدء السريع
├── ARCHITECTURE.md                # وثائق المعمارية
├── CONTRIBUTING.md                # دليل المساهمة
├── LICENSE                        # الترخيص
├── .gitignore                     # ملف Git Ignore
└── accounting-system.sln          # ملف الحل
```

## وصف المجلدات

### src/AccountingSystem.Core
- تحتوي على نماذج البيانات الأساسية
- التعريفات والثوابت
- الواجهات التي تُستخدم في المشروع

### src/AccountingSystem.Data
- Entity Framework DbContext
- مستودعات البيانات (Repositories)
- هجرات قاعدة البيانات

### src/AccountingSystem.Services
- خدمات الأعمال (Business Logic)
- التحقق من الصحة
- معالجة البيانات

### src/AccountingSystem.API
- واجهات REST API
- وحدات التحكم
- نماذج نقل البيانات (DTOs)

### tests/
- اختبارات الوحدة
- اختبارات التكامل
- اختبارات القبول

### docs/
- التوثيق الكاملة للمشروع
- أمثلة الاستخدام
- دليل المستخدم
