﻿using System;
using System.Collections.Generic;
using TaskTracker.Data.Models;

namespace TaskTracker.Data.Interfaces
{
    public interface ITask
    {
        IEnumerable<MyTask> getAllTasks { get; set; }
    }
}
