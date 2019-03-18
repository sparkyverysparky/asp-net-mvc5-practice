using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{

    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public string Create_date { get; set; }
        public int Thread_id { get; set; }

        public Comment()
        {

        }

        public Comment( string content, string creator, string createDate, int threadId)
        {
            this.Content = content;
            this.Creator = creator;
            this.Create_date = createDate;
            this.Thread_id = threadId;
        }
    }
}
