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

using MvcPractice.Models;
using MvcPractice.Repository;

namespace MvcPractice.Controllers
{
    public class ThreadController : Controller
    {
        public ThreadReository _threadRepository { get; set; }

        public ThreadController()
        {
            _threadRepository = new ThreadReository();
        }

        public ActionResult Index()
        {
            return Redirect("/Thread/List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "연습";

            List<Thread> threadList = _threadRepository.getThreadsList(0);
            return View(new ThreadListViewModel(threadList));
        }

        public ActionResult Detail(int id = 0)
        {
            Thread thread = _threadRepository.getThreadByThreadId(id);
            return View(new ThreadViewModel(thread));
        }
    }
}