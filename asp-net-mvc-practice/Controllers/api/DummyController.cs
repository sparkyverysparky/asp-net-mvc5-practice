using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcPractice.Controllers
{
    public class DummyController : ApiController
    {
        [HttpGet]
        [Route("api/Dummy/DummyAction")]
        public IHttpActionResult DummyAction()
        {
            return Json(new {
                value = "DummyAction"
            });
        }
    }
}
