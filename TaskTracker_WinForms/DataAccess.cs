using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker_WinForms
{
    public class DataAccess
    {
        public static List<TaskModel> LoadTasks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TaskModel>("SELECT * FROM Task", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTask(TaskModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Task (TaskName, IsComplete) VALUES (@TaskName, @IsComplete)", task);
            }
        }

        public static void UpdateTask(string currentTask, string newTaskName, int newIsComplete)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"UPDATE Task SET TaskName='{newTaskName}', IsComplete={newIsComplete} WHERE TaskName='{currentTask}';");
            }

        }

        public static void DeleteTask(string currentTask)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Task WHERE TaskName='{currentTask}';");
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
