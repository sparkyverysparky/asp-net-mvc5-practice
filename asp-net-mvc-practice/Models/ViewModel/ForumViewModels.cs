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
    }

    public class ThreadViewModel
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string CreateDate { get; set; }

        public ThreadViewModel(string title, string creator, string createDate)
        {
            this.Title = title;
            this.Creator = creator;
            this.CreateDate = createDate;
        }
    }
}
