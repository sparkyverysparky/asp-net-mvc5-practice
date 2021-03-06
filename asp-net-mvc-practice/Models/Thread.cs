﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{

    public class Thread
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public string Create_date { get; set; }

        public Thread()
        {

        }

        public Thread(string title, string content, string creator, string createDate)
        {
            this.Title = title;
            this.Content = content;
            this.Creator = creator;
            this.Create_date = createDate;
        }
    }
}
