using System;
using System.Collections.Generic;
using TaskTracker.Data.Interfaces;
using TaskTracker.Data.Models;

namespace TaskTracker.Data.Mocks
{
    public class MockProject : IProject
    {
        public MockProject()
        {
        }

        public IEnumerable<Project> getAllProjects
        {
            get
            {
                return new List<Project>
                {
                    new Project { name = "Website", startDate = DateTime.Today, completionDate = DateTime.Today.AddDays(15)},
                    new Project { name = "Game 2048", startDate = DateTime.Today, completionDate = DateTime.Today.AddDays(4)},
                };
            }
        }
    }
}
