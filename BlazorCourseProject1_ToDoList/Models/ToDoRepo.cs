using Microsoft.AspNetCore.Hosting.Server;
using System.Threading.Tasks;

namespace ToDoListProject.Models
{
    public static class ToDoRepo
    {
        private static List<ToDoItem> tasks = new List<ToDoItem>()
        {
            new ToDoItem { Id=1, Name = "Task numbah 1", IsComplete=false }
        };

        public static void AddTask()
        {
            ToDoItem task = new ToDoItem();
            var maxId = tasks.Max(t => t.Id);
            task.Id = maxId + 1;
            tasks.Add(task);
            //tasks = tasks.OrderBy(t => t.IsComplete.ToString()).Reverse().ToList();
        }

        public static List<ToDoItem> GetTasks()
        {
            var sortedTasks = tasks.
                OrderBy(t => t.IsComplete)
                .ThenByDescending(t => t.Id)
                .ToList();
            return sortedTasks;
        }

        public static ToDoItem? GetTaskById(int id)
        {
            var task = tasks.FirstOrDefault(s => s.Id == id);
            if (task != null)
            {
                return new ToDoItem
                {
                    Id = task.Id,
                    Name = task.Name,
                    IsComplete = task.IsComplete,
                    CompletedTime = task.CompletedTime
                };
            }
            return null;
        }

    }
}
