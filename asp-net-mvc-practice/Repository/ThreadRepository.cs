using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;

namespace MvcPractice.Repository
{

    public class ThreadReository
    {

        public ThreadReository()
        {
            //@todo
        }

        public Thread getThreadByThreadId(int id)
        {
            return new Thread(1, "제목이 곧 내용", "홍길동", "2019년 3월 2일"); //@todo
        }

        public List<Thread> getThreadsList(int page)
        {
            //@todo
            List<Thread> list = new List<Thread>();
            list.Add(new Thread(1, "제목이 곧 내용", "홍길동", "2019년 3월 2일"));
            list.Add(new Thread(2, "제목이 곧 내용2", "홍길동", "2019년 4월 2일"));
            list.Add(new Thread(3, "제목이 곧 내용3", "홍길동", "2019년 5월 2일"));
            list.Add(new Thread(4, "제목이 곧 내용4", "홍길동", "2019년 6월 2일"));

            return list;
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
