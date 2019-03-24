using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Linq;

namespace MvcPractice.Repository
{

    public class ThreadRepository : IThreadRepository
    {

        ApplicationDbContext _context;

        public ThreadRepository()
        {
            _context = new ApplicationDbContext();
            //@todo
        }

        public Thread GetThreadByThreadId(int id)
        {
            return _context.Threads.SingleOrDefault(e => e.ID == id);
        }

        public List<Thread> GetThreadsList(int page)
        {
            return _context.Threads.ToList();
        }

        public int InsertNewThread(Thread newThread)
        {
            _context.Threads.Add(newThread);
            return _context.SaveChanges();
        }
    }
}