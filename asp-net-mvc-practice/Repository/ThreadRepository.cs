using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace MvcPractice.Repository
{

    public class ThreadRepository
    {

        public ThreadRepository()
        {
            //@todo
        }

        public Thread getThreadByThreadId(int id)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                "SELECT * FROM thread WHERE ID = " + id);

            List<Thread> threadList = ModelBinder.SqlDataReaderMapToList<Thread>(sqlDataReader);

            sqlDataReader.Close();
            
            return threadList[0];
        }

        public List<Thread> getThreadsList(int page)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                "SELECT * FROM thread");

            List<Thread> threadList = new List<Thread>();

            while (sqlDataReader.Read())
            {
                Thread t = new Thread();
                t.ID = (int) sqlDataReader["ID"];
                t.Title = (string) sqlDataReader["Title"];
                t.Creator = (string)sqlDataReader["Creator"];
                t.CreateDate = (string)sqlDataReader["CreateDate"];
                threadList.Add(t);
            }


            //List<Thread> threadList = ModelBinder.SqlDataReaderMapToList<Thread>(sqlDataReader);

            sqlDataReader.Close();

            return threadList;
        }
    }
}