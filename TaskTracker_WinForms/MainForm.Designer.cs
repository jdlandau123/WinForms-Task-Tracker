using System;
using System.Windows.Forms;

namespace TaskTracker_WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.IsCompleteCheckbox = new System.Windows.Forms.CheckBox();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.AddTaskLabel = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.AddTaskPanel = new System.Windows.Forms.Panel();
            this.ListBoxLabel = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.EditTaskPanel = new System.Windows.Forms.Panel();
            this.EditTaskLabel = new System.Windows.Forms.Label();
            this.EditTaskTextBox = new System.Windows.Forms.TextBox();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.EditTaskCheckbox = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddTaskPanel.SuspendLayout();
            this.EditTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameLabel.Location = new System.Drawing.Point(15, 69);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(113, 25);
            this.TaskNameLabel.TabIndex = 1;
            this.TaskNameLabel.Text = "Task Name";
            // 
            // IsCompleteCheckbox
            // 
            this.IsCompleteCheckbox.AutoSize = true;
            this.IsCompleteCheckbox.Location = new System.Drawing.Point(20, 133);
            this.IsCompleteCheckbox.Name = "IsCompleteCheckbox";
            this.IsCompleteCheckbox.Size = new System.Drawing.Size(94, 20);
            this.IsCompleteCheckbox.TabIndex = 2;
            this.IsCompleteCheckbox.Text = "Complete?";
            this.IsCompleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTextBox.Location = new System.Drawing.Point(20, 97);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(295, 30);
            this.TaskNameTextBox.TabIndex = 0;
            // 
            // AddTaskLabel
            // 
            this.AddTaskLabel.AutoSize = true;
            this.AddTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskLabel.Location = new System.Drawing.Point(14, 10);
            this.AddTaskLabel.Name = "AddTaskLabel";
            this.AddTaskLabel.Size = new System.Drawing.Size(222, 32);
            this.AddTaskLabel.TabIndex = 3;
            this.AddTaskLabel.Text = "Add A New Task";
            this.AddTaskLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.Location = new System.Drawing.Point(20, 168);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(78, 35);
            this.AddTaskButton.TabIndex = 4;
            this.AddTaskButton.Text = "Add";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // AddTaskPanel
            // 
            this.AddTaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddTaskPanel.Controls.Add(this.AddTaskLabel);
            this.AddTaskPanel.Controls.Add(this.AddTaskButton);
            this.AddTaskPanel.Controls.Add(this.TaskNameLabel);
            this.AddTaskPanel.Controls.Add(this.TaskNameTextBox);
            this.AddTaskPanel.Controls.Add(this.IsCompleteCheckbox);
            this.AddTaskPanel.Location = new System.Drawing.Point(12, 12);
            this.AddTaskPanel.Name = "AddTaskPanel";
            this.AddTaskPanel.Size = new System.Drawing.Size(341, 224);
            this.AddTaskPanel.TabIndex = 5;
            this.AddTaskPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ListBoxLabel
            // 
            this.ListBoxLabel.AutoSize = true;
            this.ListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxLabel.Location = new System.Drawing.Point(359, 9);
            this.ListBoxLabel.Name = "ListBoxLabel";
            this.ListBoxLabel.Size = new System.Drawing.Size(89, 32);
            this.ListBoxLabel.TabIndex = 7;
            this.ListBoxLabel.Text = "Tasks";
            // 
            // ListView
            // 
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(365, 58);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(415, 448);
            this.ListView.TabIndex = 8;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // EditTaskPanel
            // 
            this.EditTaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditTaskPanel.Controls.Add(this.DeleteButton);
            this.EditTaskPanel.Controls.Add(this.EditTaskCheckbox);
            this.EditTaskPanel.Controls.Add(this.EditTaskButton);
            this.EditTaskPanel.Controls.Add(this.EditTaskTextBox);
            this.EditTaskPanel.Controls.Add(this.EditTaskLabel);
            this.EditTaskPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskPanel.Location = new System.Drawing.Point(12, 252);
            this.EditTaskPanel.Name = "EditTaskPanel";
            this.EditTaskPanel.Size = new System.Drawing.Size(341, 254);
            this.EditTaskPanel.TabIndex = 9;
            // 
            // EditTaskLabel
            // 
            this.EditTaskLabel.AutoSize = true;
            this.EditTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskLabel.Location = new System.Drawing.Point(14, 14);
            this.EditTaskLabel.Name = "EditTaskLabel";
            this.EditTaskLabel.Size = new System.Drawing.Size(132, 32);
            this.EditTaskLabel.TabIndex = 0;
            this.EditTaskLabel.Text = "Edit Task";
            // 
            // EditTaskTextBox
            // 
            this.EditTaskTextBox.Location = new System.Drawing.Point(20, 104);
            this.EditTaskTextBox.Name = "EditTaskTextBox";
            this.EditTaskTextBox.Size = new System.Drawing.Size(295, 30);
            this.EditTaskTextBox.TabIndex = 1;
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskButton.Location = new System.Drawing.Point(20, 198);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(78, 35);
            this.EditTaskButton.TabIndex = 5;
            this.EditTaskButton.Text = "Save";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // EditTaskCheckbox
            // 
            this.EditTaskCheckbox.AutoSize = true;
            this.EditTaskCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskCheckbox.Location = new System.Drawing.Point(20, 140);
            this.EditTaskCheckbox.Name = "EditTaskCheckbox";
            this.EditTaskCheckbox.Size = new System.Drawing.Size(94, 20);
            this.EditTaskCheckbox.TabIndex = 5;
            this.EditTaskCheckbox.Text = "Complete?";
            this.EditTaskCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Gold;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(228, 198);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 35);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 518);
            this.Controls.Add(this.EditTaskPanel);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.ListBoxLabel);
            this.Controls.Add(this.AddTaskPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Task Tracker";
            this.AddTaskPanel.ResumeLayout(false);
            this.AddTaskPanel.PerformLayout();
            this.EditTaskPanel.ResumeLayout(false);
            this.EditTaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TaskNameLabel;
        private CheckBox IsCompleteCheckbox;
        private TextBox TaskNameTextBox;
        private Label AddTaskLabel;
        private Button AddTaskButton;
        private Panel AddTaskPanel;
        private Label ListBoxLabel;
        private ListView ListView;
        private Panel EditTaskPanel;
        private CheckBox EditTaskCheckbox;
        private Button EditTaskButton;
        private TextBox EditTaskTextBox;
        private Label EditTaskLabel;
        private Button DeleteButton;
    }
}

