using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace MvcPractice.Repository
{

    public interface IThreadRepository
    {
        Thread GetThreadByThreadId(int id);

        List<Thread> GetThreadsList(int page);

        int InsertNewThread(Thread newThread);
    }
}