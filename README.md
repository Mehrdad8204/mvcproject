# mvcproject
پنل مدیریت ساده برای مدیریت مقالات و دسته‌بندی با استفاده از ASP.NET Core MVC و EF Core
# 🛠️ Admin Panel with ASP.NET Core MVC

پنل ادمینی طراحی‌شده با ASP.NET Core MVC که قابلیت‌های کامل CRUD را با استفاده از EF Core و پایگاه‌داده SQL Server پیاده‌سازی می‌کند.

---

## ✨ ویژگی‌ها
- معماری MVC
- پیاده‌سازی کامل عملیات CRUD
- استفاده از EF Core (Code First)
- اتصال به SQL Server
- مدیریت مقالات و دسته‌بندی‌ها
- اعتبارسنجی فرم‌ها با DataAnnotations
- طراحی ساده و واکنش‌گرا (در صورت استفاده از Bootstrap)

---

## 🧰 تکنولوژی‌های استفاده‌شده
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap *(در صورت استفاده)*

---


## 🚀 نحوه اجرای دیتابیس

برای راه‌اندازی دیتابیس این پروژه مراحل زیر را انجام دهید:
1. پروژه را در Visual Studio یا Rider باز کنید.
2. اتصال دیتابیس را در `appsettings.json` تنظیم کنید.
3. در Package Manager Console دستور زیر را اجرا کنید:
   ```bash
   dotnet ef database update


   dotnet run

---


   ## 🚀 نحوه اجرای پروژه

برای اجرای پروژه مراحل زیر را به ترتیب در ترمینال یا Command Prompt انجام دهید:
---

```bash
dotnet clean
dotnet build
dotnet run

---
---
## 🎯 هدف پروژ
این پروژه با هدف تمرین مباحث ASP.NET Core MVC و EF Core طراحی شده تا توسعه‌دهنده به صورت عملی با ساخت پنل‌های مدیریتی و ارتباط با دیتابیس آشنا شود.


## 📺 **خروجی‌های پروژه در مرورگر**
.


 صفحه index (داشبورد)آرتیکل ها
![Image](https://github.com/user-attachments/assets/5eb73bd7-37e0-48a0-95dd-1ec563f4e5cc)



اینجا صفحه create آرتیکل هست برای ایجاد یک آرتیکل
![Image](https://github.com/user-attachments/assets/f6e64894-c47c-4b3d-a582-82d2ea10e330)



صفحه index ارتیکل ها مقاله داخلش ویرایش شده
![Image](https://github.com/user-attachments/assets/50d7052c-09af-4a62-aad1-981af3630be4)



مقاله ای از صفحه index (داشبورد) ارتیکل ها دیلیت شد
![Image](https://github.com/user-attachments/assets/44013824-3b82-45fa-bffe-bcc15f36e405)



صفحه index (داشبورد) کتگوری ها
![Image](https://github.com/user-attachments/assets/a6c60f22-5802-4943-807c-cfab8dbbe475)


 
صفحه edit کتگوری ها برای ویرایش کردن مقادیر دسته بندی
![Image](https://github.com/user-attachments/assets/fc585349-17f4-4e1f-8737-e986916cef2e) 



تو صفحه index (داشبورد) کتگوری ها مقدار اول دسته بندی ویرایش شده
![Image](https://github.com/user-attachments/assets/e7bb6659-44aa-452b-8f8b-00f70b86c0c7)
