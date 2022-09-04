using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker_WinForms
{
    public class TaskModel
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; } = false;
        public string DisplayText
        {
            get
            {
                var complete = IsComplete ? "Complete" : "Not Complete";
                return $"{TaskName} - {complete}";
            }

        }
    }
}
