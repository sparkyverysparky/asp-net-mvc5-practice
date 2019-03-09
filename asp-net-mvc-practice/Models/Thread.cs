using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{

    public class Thread
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string CreateDate { get; set; }

        public Thread(int id, string title, string creator, string createDate)
        {
            this.ID = id;
            this.Title = title;
            this.Creator = creator;
            this.CreateDate = createDate;
        }
    }
}
