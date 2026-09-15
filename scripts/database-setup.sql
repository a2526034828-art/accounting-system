-- إعداد قاعدة البيانات للنظام المحاسبي
-- Database Setup Script

-- إنشاء قاعدة البيانات
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'AccountingSystemDb')
BEGIN
    CREATE DATABASE [AccountingSystemDb]
    COLLATE Arabic_CI_AS
END

GO

USE [AccountingSystemDb]

GO

-- جدول الحسابات
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Accounts')
BEGIN
    CREATE TABLE [dbo].[Accounts]
    (
        [Id] INT PRIMARY KEY IDENTITY(1,1),
        [AccountNumber] NVARCHAR(50) NOT NULL UNIQUE,
        [Name] NVARCHAR(255) NOT NULL,
        [Description] NVARCHAR(MAX),
        [AccountTypeId] INT NOT NULL,
        [Nature] NVARCHAR(50),
        [OpeningBalance] DECIMAL(18,2) DEFAULT 0,
        [CurrentBalance] DECIMAL(18,2) DEFAULT 0,
        [ParentAccountId] INT,
        [IsActive] BIT DEFAULT 1,
        [IsArchived] BIT DEFAULT 0,
        [CreatedAt] DATETIME DEFAULT GETDATE(),
        [UpdatedAt] DATETIME
    )
END

GO

-- جدول المعاملات
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Transactions')
BEGIN
    CREATE TABLE [dbo].[Transactions]
    (
        [Id] INT PRIMARY KEY IDENTITY(1,1),
        [TransactionNumber] NVARCHAR(50) NOT NULL UNIQUE,
        [TransactionDate] DATETIME NOT NULL,
        [Description] NVARCHAR(MAX),
        [DebitAccountId] INT NOT NULL,
        [CreditAccountId] INT NOT NULL,
        [Amount] DECIMAL(18,2) NOT NULL,
        [Status] NVARCHAR(50) DEFAULT 'Draft',
        [CreatedByUserId] INT,
        [ApprovedByUserId] INT,
        [ApprovedDate] DATETIME,
        [CreatedAt] DATETIME DEFAULT GETDATE(),
        [UpdatedAt] DATETIME,
        [Notes] NVARCHAR(MAX),
        [ReferenceNumber] NVARCHAR(100)
    )
END

GO

-- جدول الفواتير
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Invoices')
BEGIN
    CREATE TABLE [dbo].[Invoices]
    (
        [Id] INT PRIMARY KEY IDENTITY(1,1),
        [InvoiceNumber] NVARCHAR(50) NOT NULL UNIQUE,
        [InvoiceType] NVARCHAR(50) NOT NULL,
        [InvoiceDate] DATETIME NOT NULL,
        [DueDate] DATETIME NOT NULL,
        [CustomerId] INT NOT NULL,
        [SubTotal] DECIMAL(18,2) NOT NULL,
        [Discount] DECIMAL(18,2) DEFAULT 0,
        [Tax] DECIMAL(18,2) DEFAULT 0,
        [TotalAmount] DECIMAL(18,2) NOT NULL,
        [PaidAmount] DECIMAL(18,2) DEFAULT 0,
        [Status] NVARCHAR(50) DEFAULT 'Draft',
        [Currency] NVARCHAR(10) DEFAULT 'SAR',
        [Notes] NVARCHAR(MAX),
        [CreatedAt] DATETIME DEFAULT GETDATE(),
        [UpdatedAt] DATETIME,
        [CreatedByUserId] INT
    )
END

GO

-- جدول تفاصيل الفواتير
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'InvoiceItems')
BEGIN
    CREATE TABLE [dbo].[InvoiceItems]
    (
        [Id] INT PRIMARY KEY IDENTITY(1,1),
        [InvoiceId] INT NOT NULL,
        [Description] NVARCHAR(MAX),
        [Quantity] DECIMAL(18,2) NOT NULL,
        [UnitPrice] DECIMAL(18,2) NOT NULL,
        [LineTotal] DECIMAL(18,2) NOT NULL,
        [DiscountPercent] DECIMAL(5,2) DEFAULT 0,
        [LineNumber] INT NOT NULL,
        FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoices]([Id])
    )
END

GO

-- إنشاء الفهارس
CREATE INDEX [IX_Accounts_AccountNumber] ON [dbo].[Accounts]([AccountNumber])
CREATE INDEX [IX_Accounts_IsActive] ON [dbo].[Accounts]([IsActive])
CREATE INDEX [IX_Transactions_TransactionDate] ON [dbo].[Transactions]([TransactionDate])
CREATE INDEX [IX_Transactions_Status] ON [dbo].[Transactions]([Status])
CREATE INDEX [IX_Invoices_InvoiceNumber] ON [dbo].[Invoices]([InvoiceNumber])
CREATE INDEX [IX_Invoices_InvoiceDate] ON [dbo].[Invoices]([InvoiceDate])
CREATE INDEX [IX_Invoices_Status] ON [dbo].[Invoices]([Status])

GO

PRINT 'تم إعداد قاعدة البيانات بنجاح!'
GO
