using System;

namespace TaskManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("==== Task Manager ====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter due date (yyyy-mm-dd): ");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());

                        manager.AddTask(title, description, dueDate);
                        break;

                    case "2":
                        manager.ListTasks();
                        break;

                    case "3":
                        Console.Write("Enter task ID to mark completed: ");
                        int completeId = int.Parse(Console.ReadLine());
                        manager.MarkTaskCompleted(completeId);
                        break;

                    case "4":
                        Console.Write("Enter task ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteTask(deleteId);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            }
        }
    }
}

