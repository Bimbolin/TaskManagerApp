using System;

namespace TaskManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the main TaskManager object that controls all operations
            TaskManager manager = new TaskManager();
            
            // Load existing tasks from the file when the app starts
            manager.LoadTasksFromFile();

            bool running = true;

            // Main loop that keeps running until the user chooses to exit
            while (running)
            {
                // Display the menu to the user
                Console.WriteLine("\n==== Task Manager ====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Save & Exit");
                Console.Write("Choose an option: ");

                // Get user input
                string choice = Console.ReadLine();
                Console.WriteLine();

                // Use a switch to handle each possible menu choice
                switch (choice)
                {
                    case "1":
                        // Prompt user for task details
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();

                        Console.Write("Enter due date (yyyy-mm-dd): ");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());

                        // Call AddTask method to add a new task
                        manager.AddTask(title, description, dueDate);
                        break;

                    case "2":
                        // Show all tasks
                        manager.ListTasks();
                        break;

                    case "3":
                        // Ask for the ID of the task to complete
                        Console.Write("Enter task ID to mark completed: ");
                        int completeId = int.Parse(Console.ReadLine());
                        manager.MarkTaskCompleted(completeId);
                        break;

                    case "4":
                        // Ask for the ID of the task to delete
                        Console.Write("Enter task ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        manager.DeleteTask(deleteId);
                        break;

                    case "5":
                        // Save tasks to file and end the loop
                        manager.SaveTasksToFile();
                        running = false;
                        Console.WriteLine("Tasks saved. Goodbye!");
                        break;

                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            }
        }
    }
}

