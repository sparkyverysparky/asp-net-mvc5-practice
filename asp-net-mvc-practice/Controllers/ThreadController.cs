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

namespace MvcPractice.Controllers
{
    public class ThreadController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Thread/List");
        }

        public ActionResult List()
        {
            ThreadListViewModel listViewModel = new ThreadListViewModel();
            listViewModel.ThreadViewModelList.Add(new ThreadViewModel("제목이 곧 내용", "홍길동", "2019년 3월 2일"));
            listViewModel.ThreadViewModelList.Add(new ThreadViewModel("제목이 곧 내용2", "임꺽정", "2019년 4월 2일"));

            ViewBag.Message = "연습";

            return View(listViewModel);
        }
    }
}