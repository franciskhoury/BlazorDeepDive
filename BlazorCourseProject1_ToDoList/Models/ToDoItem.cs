using Microsoft.AspNetCore.Hosting.Server;
using System.Reflection.Metadata.Ecma335;

namespace ToDoListProject.Models
{
    public class ToDoItem
    {
        public ToDoItem()
        {
            Name = "New Task";
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        private bool _isComplete;

        public bool IsComplete
        {
            get => _isComplete;
            set
            {
                _isComplete = value;
                if (value)
                {
                    CompletedTime = DateTime.Now;
                }
            }
        }
        public DateTime CreatedTime { get; private set; }
        public DateTime? CompletedTime { get; set; }
    }
}
