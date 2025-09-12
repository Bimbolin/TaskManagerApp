using System;

namespace TaskManagerApp
{
    // TaskItem inherits from TaskBase and represents an actual task
    public class TaskItem : TaskBase
    {
        // Task properties
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        // Override the abstract Display method from TaskBase
        // This prints the task info to the console
        public override void Display()
        {
            string status = IsCompleted ? "✅" : "❌";
            Console.WriteLine($"{Id}. {Title} - {Description} | Due: {DueDate.ToShortDateString()} | {status}");
        }
    }
}


 