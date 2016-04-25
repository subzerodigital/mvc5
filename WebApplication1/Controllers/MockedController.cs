using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MockedController : Controller
    {
        // GET: Mocked
        public ActionResult ReturnMock(string type)
        {
            var message = Server.HtmlEncode(type);
            return Content("Hello"+ message);
        }
    
    }
}