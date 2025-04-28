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
            cmbPriorityFilter.SelectedIndex = -1;
            cmbStatusFilter.SelectedIndex = -1;
            cmbPriorityNotMade.SelectedIndex= -1;

            LoadCompletedTasks();
            LoadTasksInProgress(); 
        }

        private void LoadTasksInProgress()
        {
            var tasks = DataBaseService.GetTasksByAssignee(_user.Id, "В работе");
            DisplayTasks(tasks, flowLayoutPanelInProgress, true);
        }

        private void LoadCompletedTasks()
        {
            var tasks = DataBaseService.GetTasksByAssignee(_user.Id, "Выполнено", "Провалено", "Отказано");
            DisplayTasks(tasks, flowLayoutPanelCompleted, false);
        }

        private void DisplayTasks(List<Dictionary<string, object>> tasks, FlowLayoutPanel panel, bool allowStatusChange)
        {
            panel.Controls.Clear();

            tasks = tasks
                .OrderByDescending(task => Convert.ToInt32(task["id"]))
                .ToList();

            foreach (var task in tasks)
            {
                var card = new MaterialCard
                {
                    Width = panel.Width - 75,
                    Height = 300,
                    Padding = new Padding(10),
                    Margin = new Padding(10)
                };


                var taskInfo = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    Padding = new Padding(5),
                    WrapContents = false
                };

                var titleLabel = new Label
                {
                    Text = $"{task["title"]}",
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Padding = new Padding(0, 0, 0, 10)
                };

                var descriptionLabel = new Label
                {
                    Text = $"{task["description"]}",
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Padding = new Padding(0, 0, 0, 10)
                };

                var priorityLabel = new Label
                {
                    Text = $"Приоритет: {task["priority"]}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(0, 0, 0, 10)
                };

                var statusLabel = new Label
                {
                    Text = $"Статус: {task["status"]}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Dock = DockStyle.Bottom
                };

                taskInfo.Controls.Add(titleLabel);
                taskInfo.Controls.Add(descriptionLabel);
                taskInfo.Controls.Add(priorityLabel);
                taskInfo.Controls.Add(statusLabel);

                if (allowStatusChange)
                {
                    var statuses = new[] { "Выполнено", "Провалено", "Отказано" };
                    var imageIndexes = new[] { 1, 2, 3 }; // Индексы иконок в imageList1

                    var buttonPanel = new Panel
                    {
                        Width = 60,   // Ширина под три кнопки
                        Height = 180, // Примерная высота
                        Anchor = AnchorStyles.Top | AnchorStyles.Right,
                        Location = new Point(card.Width - 70, (card.Height - 150) / 2), // Правый угол и центр по высоте
                        BackColor = Color.Transparent
                    };

                    for (int i = 0; i < statuses.Length; i++)
                    {
                        var button = new Button
                        {
                            Width = 50,
                            Height = 50,
                            Tag = statuses[i],
                            ImageList = imageList1,
                            ImageIndex = imageIndexes[i],
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Transparent,
                            Location = new Point(5, i * 55) // Размещаем кнопки друг под другом
                        };
                        button.FlatAppearance.BorderSize = 0;
                        button.FlatAppearance.MouseOverBackColor = Color.LightGray;

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

                        buttonPanel.Controls.Add(button);
                    }

                    card.Controls.Add(buttonPanel);
                }



                card.Controls.Add(taskInfo);
                panel.Controls.Add(card);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LoadTasksInProgress(); 
        }



        private void flowLayoutPanelCompleted_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApplyFilters_Click(object sender, EventArgs e)
        {
            string selectedPriority = cmbPriorityFilter.SelectedItem?.ToString();
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString();

            var filteredTasks = DataBaseService.GetFilteredTasksByAssignee(_user.Id, selectedPriority, selectedStatus);

            if (filteredTasks != null)
            {
                DisplayTasks(filteredTasks, flowLayoutPanelCompleted, false);
            }
            else
            {
                MessageBox.Show("Не удалось загрузить задачи с применёнными фильтрами.");
            }
        }

        private void DisableFilters_Click(object sender, EventArgs e)
        {
            LoadCompletedTasks();
            LoadTasksInProgress();

            cmbPriorityFilter.SelectedIndex = -1;
            cmbStatusFilter.SelectedIndex = -1;

            cmbPriorityFilter.Refresh();
            cmbStatusFilter.Refresh();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadCompletedTasks();
        }

        private void ApplyFiltersInWork_Click(object sender, EventArgs e)
        {
            string selectedPriority = cmbPriorityNotMade.SelectedItem?.ToString();

            var inProgressFilteredTasks = DataBaseService.GetFilteredTasksByAssignee(_user.Id, selectedPriority, "В работе");

            if (inProgressFilteredTasks == null || inProgressFilteredTasks.Count == 0)
            {
                MessageBox.Show("Не найдено задач с указанными параметрами.");
                return;
            }

            DisplayTasks(inProgressFilteredTasks, flowLayoutPanelInProgress, true);
        }

        private void DisableFiltersNoMade_Click(object sender, EventArgs e)
        {
            LoadTasksInProgress();

            cmbPriorityNotMade.SelectedIndex = -1;
            cmbPriorityNotMade.Refresh();
        }
    }
}
