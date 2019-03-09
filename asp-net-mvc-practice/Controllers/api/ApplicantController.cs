using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcPractice.Controllers
{
    public class ApplicantController : ApiController
    {
        [HttpGet]
        [Route("api/Applicant/question")]
        public IHttpActionResult question()
        {
            return Json(new {
                value = "test1"
            });
        }

        [HttpGet]
        [Route("api/Applicant/question2")]
        public IHttpActionResult question2()
        {
            return Json(new
            {
                value = "test1"
            });
        }

        [HttpGet]
        [Route("api/Applicant/question3/{id}")]
        public IHttpActionResult question3(int id)
        {
            return Json(new
            {
                value = id
            });
        }
    }
}
