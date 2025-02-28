﻿using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationDbContext _context;

        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateTask(TaskItem task, string employeeId)
        {
            task.EmployeeId = employeeId;
            await _context.TaskItems.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            await _context.TaskItems.FindAsync(id);

            if (id != 0)
            {
                var task = await _context.TaskItems.FindAsync(id);
                _context.TaskItems.Remove(task);
                await _context.SaveChangesAsync();
            }



        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            var tasks = await _context.TaskItems.ToListAsync();
            return tasks;
        }

        public Task<TaskItem> GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskItem>> GetTasksForEmployeeAsync(string employeeId)
        {
            var tasks = await _context.TaskItems.Where(t => t.EmployeeId == employeeId).ToListAsync();
            return tasks;
        }

        public async Task UpdateTask(TaskItem task)
        {
            var existingTask = await _context.TaskItems.FindAsync(task.Id);

            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.IsCompleted = task.IsCompleted;

                await _context.SaveChangesAsync();
            }
        }
    }
}
