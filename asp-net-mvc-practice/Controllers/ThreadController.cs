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

using MvcPractice.Repository;

namespace MvcPractice.Controllers
{
    public class ThreadController : Controller
    {
        private readonly IThreadRepository _threadRepository;
        private readonly ICommentRepository _commentRepository;

        //public ThreadController(IThreadRepository threadRepository, ICommentRepository commentRepository)
        //{
        //    _threadRepository = threadRepository;
        //    _commentRepository = commentRepository;
        //}

        public ThreadController()
        {
            _threadRepository = new ThreadRepository();
            _commentRepository = new CommentRepository();
        }


        public ActionResult Index()
        {
            return Redirect("/Thread/List");
        }

        public ActionResult List()
        {
            ViewBag.Message = "연습";

            List<Thread> threadList = _threadRepository.GetThreadsList(0);
            return View(new ThreadListViewModel(threadList));
        }

        public ActionResult Detail(int id = 0)
        {
            Thread thread = _threadRepository.GetThreadByThreadId(id);
            List<Comment> commentList = _commentRepository.GetCommentsList(id);

            return View(new ThreadDetailViewModel(thread, commentList));
        }

        public ActionResult New()
        {
            
            return View();
        }

        public ActionResult Create(string title, string content)
        {
            Thread newThread = new Thread(title, content, "Not Implemented", "some date");
            _threadRepository.InsertNewThread(newThread);
            
            return Redirect("/Thread/List");
        }
    }
}