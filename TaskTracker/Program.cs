using TaskTracker;

class Program
{
    static void Main()
    {
        Tracker taskTracker = new Tracker();

        while (true)
        {
            Console.WriteLine("Welcome to TaskTracker! What can i help you with today?");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. Complete a task");
            Console.WriteLine("3. View all tasks");
            Console.WriteLine("4. Exit the task tracker");

            var valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.WriteLine("Enter task title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter task description:");
                    string description = Console.ReadLine();
                    TaskTracker.Task newTask = new TaskTracker.Task { Title = title, Description = description };
                    taskTracker.AddTask(newTask);
                    break;
                case "2":
                    Console.WriteLine("Enter the ID of the task to complete:");
                    if (int.TryParse(Console.ReadLine(), out int taskId))
                    {
                        taskTracker.CompleteTask(taskId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid task ID. Please enter a valid integer.");
                    }
                    break;
                case "3":
                    taskTracker.DisplayTasks();
                    break;
                case "4":
                    Console.WriteLine("Exiting the task tracker. Goodbye!");
                    return;
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
        }
    }
}
