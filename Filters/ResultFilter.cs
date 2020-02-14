using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilterExample.Filters
{
    public class ResultFilter : Attribute, IResultFilter
    {
        string filePath = @"C:\Users\Lavanya\source\repos\ActionFilterExample\ActionFilterExample\Filters\Log.txt";

        public void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                var output = (ObjectResult)context.Result;
                writer.WriteLine($"{output.Value} end");
            }
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                var output = (ObjectResult)context.Result;
                writer.WriteLine($"{output.Value} start");
            }
        }
    }
}
