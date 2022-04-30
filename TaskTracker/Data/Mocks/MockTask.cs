using System;
using System.Collections.Generic;
using System.Linq;
using TaskTracker.Data.Interfaces;
using TaskTracker.Data.Models;

namespace TaskTracker.Data.Mocks
{
    public class MockTask : ITask
    {
        public MockTask()
        {
        }

        private readonly IProject _project = new MockProject();

        public IEnumerable<MyTask> getAllTasks
        {
            get
            {
                return new List<MyTask>
                {
                    new MyTask { name = "Create logo", description = "Make logo for online shop", project = _project.getAllProjects.First() },
                    new MyTask { name = "Create home page", description = "Make home page with products" },
                };
            }
        }
    }
}
