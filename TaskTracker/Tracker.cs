using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    internal class Tracker : ITaskManagement
    {
        public List<Task> Tasks { get; set; }
        public Tracker()
        {
            Tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            task.TaskId = Tasks.Count + 1;
            Tasks.Add(task);
            Console.WriteLine($"Task added: {task.Title}");
        }
        public void CompleteTask(int taskId)
        {
            Task task = Tasks.Find(t => t.TaskId == taskId);

            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"Task completed: {task.Title}");
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
            }
        }
        public void DisplayTasks()
        {
            Console.WriteLine("All Tasks:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"Task ID: {task.TaskId}, Title: {task.Title}, Completed: {task.IsCompleted}");
            }
        }
    }
}
