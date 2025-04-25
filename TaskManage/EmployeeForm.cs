using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthLibrary;
using MaterialSkin;
using MaterialSkin.Controls;
using TaskLibrary;
using DataBaseLibrary;

namespace TaskManage
{
    public partial class EmployeeForm : MaterialForm
    {
        private User _user;

        public EmployeeForm(User user)
        {
            InitializeComponent();
            _user = user;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadCompletedTasks();
            LoadTasksInProgress(); 
        }

        private void LoadTasksInProgress()
        {
            var tasks = DataBaseService.GetTasksByAssignee(_user.Id, "В работе");
            DisplayTasks(tasks, tabPageTasks, true);
        }

        private void LoadCompletedTasks()
        {
            var tasks = DataBaseService.GetTasksByAssignee(_user.Id, "Выполнено", "Провалено", "Отказано");
            DisplayTasks(tasks, tabPageCompletedTasks, false);
        }

        private void DisplayTasks(List<Dictionary<string, object>> tasks, TabPage tabPage, bool allowStatusChange)
        {
            tabPage.Controls.Clear();
            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            tabPage.Controls.Add(panel);

            foreach (var task in tasks)
            {
                var card = new MaterialCard
                {
                    Width = panel.Width - 30,
                    Height = 300,
                    Padding = new Padding(10),
                    BackColor = Color.White,
                    Margin = new Padding(10)
                };

                var container = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    AutoScroll = true
                };

                var title = new Label
                {
                    Text = $"{task["title"]}",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    AutoSize = true
                };

                var description = new Label
                {
                    Text = $"{task["description"]}",
                    AutoSize = true
                };

                var priority = new Label
                {
                    Text = $"Приоритет: {task["priority"]}",
                    AutoSize = true
                };

                var status = new Label
                {
                    Text = $"Статус: {task["status"]}",
                    AutoSize = true
                };

                container.Controls.Add(title);
                container.Controls.Add(description);
                container.Controls.Add(priority);
                container.Controls.Add(status);

                if (allowStatusChange)
                {
                    var statuses = new[] { "Выполнено", "Провалено", "Отказано" };

                    foreach (var newStatus in statuses)
                    {
                        var button = new Button
                        {
                            Text = newStatus,
                            Width = card.Width - 40,
                            Height = 35,
                            Tag = newStatus,
                            Margin = new Padding(3)
                        };

                        button.Click += (s, e) =>
                        {
                            int taskId = Convert.ToInt32(task["id"]);
                            string selectedStatus = (string)((Button)s).Tag;

                            bool success = TaskService.ChangeTaskStatus(taskId, selectedStatus);

                            if (success)
                            {
                                MessageBox.Show($"Статус задачи изменён на \"{selectedStatus}\".");
                                LoadTasksInProgress();
                                LoadCompletedTasks();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при изменении статуса.");
                            }
                        };

                        container.Controls.Add(button);
                    }
                }

                card.Controls.Add(container);
                panel.Controls.Add(card);
            }
        }

    }
}
