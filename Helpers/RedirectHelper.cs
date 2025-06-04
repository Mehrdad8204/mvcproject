using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvcproject.Helpers
{
    public static class RedirectHelper
    {
        public static IActionResult RedirectTo(string url)
        {
            return new RedirectResult("/" + url);
        }

        public static IActionResult RedirectBack(HttpContext context)
        {
            var referer = context.Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(referer))
            {
                return new RedirectResult(referer);
            }
            else
            {
                return new ContentResult { Content = "Route not found" };
            }
        }
    }
}