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
    public class CommentController : Controller
    {
        public CommentRepository _commentRepository { get; set; }

        public CommentController()
        {
            _commentRepository = new CommentRepository();
        }

        public ActionResult Create(string content, int threadId)
        {
            Comment newComment = new Comment(content, "Not Implemented", "some day", threadId);
            _commentRepository.InsertNewComment(newComment);
            
            //go back to where it was
            return Redirect("/Thread/Detail?id=" + threadId);
        }
    }
}