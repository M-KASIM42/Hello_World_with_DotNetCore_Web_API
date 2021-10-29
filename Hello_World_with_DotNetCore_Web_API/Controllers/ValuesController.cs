using Hello_World_with_DotNetCore_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_World_with_DotNetCore_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<AppMessage> Get()
        {
            var messages = new List<AppMessage>()
            {
                new AppMessage { Message = "hello world"},
                new AppMessage {Message = "hello Samu"},
                new AppMessage {Message = "hello MVC"},
                new AppMessage {Message = "Hello Razor Pages"},
                new AppMessage {Message = "hello WEB API"}
            };
            return messages;
        }
    }
}
