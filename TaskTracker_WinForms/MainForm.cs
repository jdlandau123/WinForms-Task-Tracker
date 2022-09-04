using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracker_WinForms
{
    public partial class MainForm : Form
    {
        List<TaskModel> tasks = new List<TaskModel>();
        public MainForm()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            tasks = DataAccess.LoadTasks();
            ConnectListView();
        }

        private void ConnectListView()
        {
            ColumnHeader TaskNameHeader, CompleteHeader;
            TaskNameHeader = new ColumnHeader();
            CompleteHeader = new ColumnHeader();

            TaskNameHeader.Text = "Task Name";
            TaskNameHeader.Width = 230;

            CompleteHeader.Text = "Complete?";
            CompleteHeader.Width = 80;

            ListView.Columns.Add(TaskNameHeader);
            ListView.Columns.Add(CompleteHeader);

            foreach (TaskModel task in tasks)
            {
                var complete = task.IsComplete ? "Yes" : "No";
                ListViewItem item = new ListViewItem(task.TaskName);
                item.SubItems.Add(complete);
                ListView.Items.Add(item);
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel newTask = new TaskModel();
            newTask.TaskName = TaskNameTextBox.Text;
            newTask.IsComplete = false;

            if (IsCompleteCheckbox.Checked)
            {
                newTask.IsComplete = true;
            }

            DataAccess.SaveTask(newTask);
            TaskNameTextBox.Text = "";
            LoadTasks();
        }


        private void AddTaskPanel_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = ListView.SelectedItems;

            if (selectedItems.Count > 0)
            {
                EditTaskTextBox.Text = selectedItems[0].Text;
                EditTaskCheckbox.Checked = false;

                if (selectedItems[0].SubItems[1].Text == "Yes")
                {
                    EditTaskCheckbox.Checked = true;
                }
            }
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            string currentTask = ListView.SelectedItems[0].Text;
            string newTaskName = EditTaskTextBox.Text;
            int newIsComplete = EditTaskCheckbox.Checked ? 1 : 0;

            ListView.Items.Clear();
            DataAccess.UpdateTask(currentTask, newTaskName, newIsComplete);
            LoadTasks();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string currentTask = ListView.SelectedItems[0].Text;

            ListView.Items.Clear();
            DataAccess.DeleteTask(currentTask);
            EditTaskTextBox.Text = "";
            LoadTasks();
        }
    }
}
