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

            foreach(Thread t in threadList)
            {
                this.ThreadViewModelList.Add(new ThreadViewModel(t));
            }
        }
    }

    public class ThreadViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public string CreateDate { get; set; }

        public ThreadViewModel(int id, string title, string content, string creator, string createDate)
        {
            this.ID = id;
            this.Title = title;
            this.Content = content;
            this.Creator = creator;
            this.CreateDate = createDate;
        }

        public ThreadViewModel(Thread thread)
        {
            this.ID = thread.ID;
            this.Title = thread.Title;
            this.Content = thread.Content;
            this.Creator = thread.Creator;
            this.CreateDate = thread.Create_date;
        }

        public ThreadViewModel()
        {

        }
    }

    public class ThreadDetailViewModel : ThreadViewModel
    {
        public List<Comment> CommentsList { get; set; }

        public ThreadDetailViewModel(Thread thread, List<Comment> commentsList) : base(thread)
        {
            CommentsList = commentsList;
        }
    }
}
