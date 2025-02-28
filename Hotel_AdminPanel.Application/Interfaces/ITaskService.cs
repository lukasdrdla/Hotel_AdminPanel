﻿using Hotel_AdminPanel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskItem>> GetTasksForEmployeeAsync(string employeeId);
        Task<List<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> GetTaskById(int id);
        Task CreateTask(TaskItem task, string employeeId);
        Task UpdateTask(TaskItem task);
        Task DeleteTask(int id);

    }
}
