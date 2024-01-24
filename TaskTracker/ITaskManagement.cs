using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    internal interface ITaskManagement
    {
        void AddTask(Task task);
        void CompleteTask(int taskId);
        void DisplayTasks();
    }
}
