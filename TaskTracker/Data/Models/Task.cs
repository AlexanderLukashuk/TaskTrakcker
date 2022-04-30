using System;
namespace TaskTracker.Data.Models
{
    public class Task
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public Task()
        {
        }
    }
}
