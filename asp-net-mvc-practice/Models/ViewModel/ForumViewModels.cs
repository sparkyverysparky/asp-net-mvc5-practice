using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    public class ThreadListViewModel
    {
        public List<ThreadViewModel> ThreadViewModelList { get; set; }

        public ThreadListViewModel()
        {
            this.ThreadViewModelList = new List<ThreadViewModel>();
        }

        public ThreadListViewModel(List<Thread> threadList)
        {
            this.ThreadViewModelList = new List<ThreadViewModel>();

            foreach(Thread thread in threadList)
            {
                this.ThreadViewModelList.Add(new ThreadViewModel(thread));
            }
        }
    }

    public class ThreadViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string CreateDate { get; set; }

        public ThreadViewModel(int id, string title, string creator, string createDate)
        {
            this.ID = id;
            this.Title = title;
            this.Creator = creator;
            this.CreateDate = createDate;
        }

        public ThreadViewModel(Thread thread)
        {
            this.ID = thread.ID;
            this.Title = thread.Title;
            this.Creator = thread.Creator;
            this.CreateDate = thread.CreateDate;
        }


    }
}
