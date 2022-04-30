using System;
using System.Collections.Generic;

namespace TaskTracker.Data.Models
{
    public class Project
    {
        public int id { get; set; }

        public string name { get; set; }

        public DateTime startDate { get; set; }

        public DateTime completionDate { get; set; }

        public enum status
        {
            ToDo, InProgress, Done
        }

        public int priority { get; set; }

        public List<MyTask> tasks { get; set; }

        public Project()
        {
        }
    }
}
