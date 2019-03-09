using Microsoft.ApplicationBlocks.Data;
using Newtonsoft.Json;
using MvcPractice.Database;
using MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// First landing page for applicants
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public ActionResult Index(string userEmail = "")
        {
            ViewBag.Message = userEmail;
            //If user is already logged in, 

            //@todo set a variable to determine whether the user has already received an auth key.
            

            return View();
        }

        [HttpPost]
        public ActionResult NewAuthKey(string userEmail = "")
        {
            //@todo: verify that the user email is not already registered and not locked
            //@todo: if the user application is locked, display message accordingly.
            //@todo: if the user already should have the auth key, display message accordingly.
            if (IsAuthKeyAlreadyIssued())
            {
                ViewBag.Message = "이미 Authkey가 발급되었습니다";
                return View();
            }
            //@todo: issue new auth key
            //@todo send email to applicant.
            //@todo set cookie to remember that the auth key was issued for the user
            SetCookieAuthKeyWasIssued(24);

            ViewBag.Message = "Auth Key가 발급되어 다음주소로 전송되었습니다: " + userEmail;

            return View();
        }

        /// <summary>
        /// Returns true if the auth key was already issued for the user.
        /// </summary>
        /// <returns></returns>
        private bool IsAuthKeyAlreadyIssued()
        {
            HttpCookie authCookie = Request.Cookies["applicant-auth-key"];
            if (authCookie == null)
            {
                return false;   
            }

            if (!string.IsNullOrEmpty(authCookie.Values["issued-already"]) && authCookie.Values["issued-already"] == "yes")
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Remember that the Auth key was issued for the user.
        /// </summary>
        /// <param name="hours"> the number of hours the cookie will live </param>
        private void SetCookieAuthKeyWasIssued(int hours)
        {
            HttpCookie authCookie = new HttpCookie("applicant-auth-key");
            authCookie.Values.Add("issued-already", "yes");
            authCookie.Expires = DateTime.Now.AddHours(hours);
            Response.Cookies.Add(authCookie);
        }
        
    }
}


//List<Object> result = new List<Object>();

//SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
//    DatabaseManager.GetConnectionString(),
//    CommandType.Text,
//    "SELECT * FROM guytable");

//List<DummyTest> dummyList = ModelBinder.SqlDataReaderMapToList<DummyTest>(sqlDataReader);

//ViewBag.Message = dummyList[0].guy;

//            sqlDataReader.Close();