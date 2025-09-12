namespace TaskManagerApp
{
    // Abstract base class to demonstrate inheritance
    // All tasks must have an ID and a Display method
    public abstract class TaskBase
    {
        public int Id { get; set; }

        // Abstract method forces subclasses to implement their own display logic
        public abstract void Display();
    }
}
