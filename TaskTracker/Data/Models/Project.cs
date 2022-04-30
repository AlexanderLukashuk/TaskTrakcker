using System;
namespace TaskTracker.Data.Models
{
    public class Project
    {
        public string name { get; set; }

        public DateTime startDate { get; set; }

        public DateTime completionDate { get; set; }

        public enum status
        {
            ToDo, InProgress, Done
        }

        public int priority { get; set; }

        public Project()
        {
        }
    }
}
