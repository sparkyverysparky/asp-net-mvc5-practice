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
        public ActionResult Index()
        {
            return Redirect("/thread");
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