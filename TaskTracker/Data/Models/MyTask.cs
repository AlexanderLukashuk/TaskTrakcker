using System;
namespace TaskTracker.Data.Models
{
    public class MyTask
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int projectID { get; set; }

        public Project project { get; set; }

        public MyTask()
        {
        }
    }
}
