using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaskManagerApp
{
    // The TaskManager class is responsible for managing all task operations
    public class TaskManager
    {
        // List to store all tasks in memory
        private List<TaskItem> tasks = new List<TaskItem>();

        // Keeps track of the next available ID for new tasks
        private int nextId = 1;

        // The file where tasks are saved
        private readonly string filePath = "tasks.json";

        // AddTask creates a new TaskItem object and adds it to the list
        public void AddTask(string title, string description, DateTime dueDate)
        {
            TaskItem newTask = new TaskItem
            {
                Id = nextId++,
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsCompleted = false
            };
            tasks.Add(newTask);
            Console.WriteLine("Task added successfully!");
        }

        // ListTasks shows all current tasks to the console
        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            // Loop through tasks and call their Display method
            foreach (TaskItem task in tasks)
            {
                task.Display();
            }
        }

        // MarkTaskCompleted finds a task by ID and sets IsCompleted to true
        public void MarkTaskCompleted(int id)
        {
            TaskItem task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        // DeleteTask removes a task from the list by ID
        public void DeleteTask(int id)
        {
            TaskItem task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        // SaveTasksToFile writes all tasks to a JSON file for persistence
        public void SaveTasksToFile()
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // LoadTasksFromFile reads existing tasks from the JSON file (if it exists)
        public void LoadTasksFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tasks = JsonSerializer.Deserialize<List<TaskItem>>(json);

                // Set the nextId to be higher than the last existing ID
                if (tasks.Count > 0)
                    nextId = tasks[^1].Id + 1;
            }
        }
    }
}



