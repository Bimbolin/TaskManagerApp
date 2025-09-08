using System;

namespace TaskManagerApp
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(int id, string title, string description, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Id}. {Title} - {(IsCompleted ? "Completed" : "Pending")} (Due: {DueDate.ToShortDateString()})";
        }
    }
}
