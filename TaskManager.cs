using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagerApp
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private int nextId = 1;

        public void AddTask(string title, string description, DateTime dueDate)
        {
            TaskItem task = new TaskItem(nextId++, title, description, dueDate);
            tasks.Add(task);
            Console.WriteLine("Task added successfully!\n");
        }

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.\n");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();
        }

        public void MarkTaskCompleted(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Task marked as completed!\n");
            }
            else
            {
                Console.WriteLine("Task not found.\n");
            }
        }

        public void DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Task deleted successfully!\n");
            }
            else
            {
                Console.WriteLine("Task not found.\n");
            }
        }
    }
}
