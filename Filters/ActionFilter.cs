using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace ActionFilterExample.Filters
{
    public class ActionFilter : Attribute, IActionFilter
    {
        string filePath = @"C:\Users\Lavanya\source\repos\ActionFilterExample\ActionFilterExample\Filters\Log.txt";
        public void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(context.HttpContext.Request.Path.Value);
            };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(context.HttpContext.Request.Path.Value);
            };
        }
    }
}
