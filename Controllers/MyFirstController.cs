using ActionFilterExample.Filters;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ActionFilterExample.Controllers
{
    [Route("api/filtresExamples")]
    [ApiController]
    public class MyFirstController : ControllerBase
    {
        [Route("actionFilter")]
        [HttpGet]
        [ActionFilter]
        public string Display()
        {
            return "Hi Lavanya";
        }
        [Route("resultFilter")]
        [HttpGet]
        [ResultFilter]
        public dynamic GetValues()
        {
            var details = new
            {
                Name = "Lavanya",
                age = 25,
                Desigination = "junior"

            };
            return details;
        }
        [Route("exceptionFilter")]
        [HttpGet]
        [ExceptionFilter]
        public string Exce()
        {
            throw new Exception("exception will occured");
        }
        [Route("outputCache")]
        [HttpGet]
        [OutputCache(Duration =100)]
       
        public string GetName()
        {
            return DateTime.Now.ToString();
        }

    }
}
