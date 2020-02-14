using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilterExample.Filters
{
    public class ExceptionFilter:Attribute ,IExceptionFilter
    {
        string filePath = @"C:\Users\Lavanya\source\repos\ActionFilterExample\ActionFilterExample\Filters\Log.txt";

        public void OnException(ExceptionContext context)
        {
            using(StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(context.Exception.Message);
                writer.WriteLine(context.Exception.StackTrace);
            }
        }
    }
}
