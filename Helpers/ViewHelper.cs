using Microsoft.AspNetCore.Mvc;

namespace mvcproject.Helpers
{
    public static class ViewHelper
    {
        // معادل تابع asset برای مسیر فایل‌های استاتیک
        public static string Asset(string path, HttpContext context)
        {
            return $"{context.Request.Scheme}://{context.Request.Host}/" + path;
        }

        // چون View توی ASP.NET خودش اتومات کار می‌کنه نیازی به include نیست

        // معادل تابع url
        public static string Url(string relativeUrl, HttpContext context)
        {
            if (relativeUrl.StartsWith("/"))
                relativeUrl = relativeUrl.Substring(1);

            return $"{context.Request.Scheme}://{context.Request.Host}/{relativeUrl}";
        }
    }
}