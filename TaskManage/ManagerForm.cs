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
using DataBaseLibrary;
using TaskLibrary;
using System.Drawing.Text;

namespace TaskManage
{
    public partial class ManagerForm : MaterialForm
    {
        private User _user;

        public ManagerForm(User user)
        {
            InitializeComponent();
            _user = user;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadSubordinates();
            LoadManagerTasks();
            cmbPriorityS.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }




        private void LoadSubordinates()
        {
            // Получаем данные о подчиненных через UserService
            var result = UserService.GetSubordinates(_user.Id);

            if (result != null && result.Count > 0)
            {
                cmbAssignee.Items.Clear();
                cmbAssigneS.Items.Clear();
                foreach (var row in result)
                {
                    // Добавляем подчиненного в ComboBox
                    cmbAssigneS.Items.Add(new { Id = row["id"], Login = row["login"] });
                    cmbAssignee.Items.Add(new { Id = row["id"], Login = row["login"] });
                }

                cmbAssignee.DisplayMember = "Login";
                cmbAssignee.ValueMember = "Id";
                cmbAssigneS.DisplayMember= "Login";
                cmbAssignee.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Не удалось загрузить подчиненных.");
            }
        }



        private void materialButton1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            string description = txtDescription.Text;

            var selectedAssignee = cmbAssignee.SelectedItem as dynamic;
            int? assigneeId = selectedAssignee?.Id;

            string priority = cmbPriority.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || assigneeId == null || string.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите подчиненного.");
                return;
            }

            // Используем TaskService для создания задачи
            bool success = TaskService.CreateTask(title, description, assigneeId.Value, _user.Id, priority);

            if (success)
            {
                MessageBox.Show("Задача успешно создана!");
                txtTitle.Clear();
                txtDescription.Clear();
                cmbAssignee.SelectedIndex = -1;
                cmbPriority.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Ошибка при создании задачи.");
            }
        }

        private void LoadManagerTasks(string priorityCondition = null, string statusCondition = null, int? assigneeSId = null)
        {

            // Получаем все задачи, выданные текущим менеджером
            var tasks = DataBaseService.GetFilteredTasksByCreator(_user.Id, priorityCondition, statusCondition, assigneeSId);
            tasks = tasks
                .OrderByDescending(task => Convert.ToInt32(task["id"]))
                .ToList();

            if (tasks != null && tasks.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();  // Очищаем панель перед добавлением новых карточек

                foreach (var task in tasks)
                {
                    // Создаем новый MaterialCard
                    var card = new MaterialCard
                    {
                        Width = flowLayoutPanel1.Width - 90,  // Устанавливаем ширину карточки
                        Height = 300,  // Высота карточки
                        Padding = new Padding(10),  // Отступы внутри карточки
                        BackColor = Color.White,  // Цвет фона карточки
                        Margin = new Padding(10)  // Отступы между карточками
                    };

                    // Создаем контейнер для текста в карточке
                    var taskInfo = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        FlowDirection = FlowDirection.TopDown,  // Располагаем элементы сверху вниз
                        Padding = new Padding(5)
                    };

                    // Заголовок задачи (имитация <h1>) - крупный, жирный
                    var titleLabel = new Label
                    {
                        Text = $"{task["title"]}",
                        Font = new Font("Arial", 18, FontStyle.Bold),  // Пример для h1 (крупный жирный)
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        Padding = new Padding(0, 0, 0, 10)  // Отступ снизу для разделения с другими элементами
                    };

                    // Описание задачи
                    var descriptionLabel = new Label
                    {
                        Text = $"{task["description"]}",
                        AutoSize = true,
                        Dock = DockStyle.Top,
                        Padding = new Padding(0, 0, 0, 10)  // Отступ снизу
                    };

                    // Получаем логин исполнителя
                    var assigneeId = (int)task["assignee_id"];
                    var assigneeLogin = UserService.GetLoginById(assigneeId);  // Получаем логин по ID

                    // Никнейм исполнителя
                    var assigneeLabel = new Label
                    {
                        Text = $"Исполнитель: {assigneeLogin}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        Dock = DockStyle.Top,
                        Padding = new Padding(0, 0, 0, 10)  // Отступ снизу
                    };

                    // Приоритет задачи
                    var priorityLabel = new Label
                    {
                        Text = $"Приоритет: {task["priority"]}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Dock = DockStyle.Bottom,
                        Padding = new Padding(0, 0, 0, 10)  // Отступ снизу
                    };

                    // Статус задачи
                    var statusLabel = new Label
                    {
                        Text = $"Статус: {task["status"]}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Dock = DockStyle.Bottom
                    };

                    // Добавляем все элементы в контейнер задачи
                    taskInfo.Controls.Add(titleLabel);
                    taskInfo.Controls.Add(descriptionLabel);
                    taskInfo.Controls.Add(assigneeLabel);
                    taskInfo.Controls.Add(priorityLabel);
                    taskInfo.Controls.Add(statusLabel);

                    // Кнопка для удаления задачи
                    var deleteButton = new Button
                    {
                        Size = new Size(card.Width - 20, 40),  // Ширина на всю карточку, высота 40
                        ImageList = imageList1,  // Устанавливаем ImageList для кнопки
                        ImageIndex = 3,  // Индекс крестика в ImageList
                        FlatStyle = FlatStyle.Flat,
                        FlatAppearance = { BorderSize = 0 },
                        Dock = DockStyle.Bottom,  // Кнопка будет располагаться внизу карточки
                        Text = "",  // Убираем текст, оставляем только изображение
                    };

                    // Обработчик нажатия на кнопку удаления
                    deleteButton.Click += (sender, e) =>
                    {
                        // Удаляем карточку из панели
                        flowLayoutPanel1.Controls.Remove(card);

                        // Дополнительно, если нужно удалить задачу из базы данных, вызываем метод удаления
                        int taskId = (int)task["id"];
                        bool isDeleted = TaskService.DeleteTask(taskId); // Используем метод DeleteTask для удаления
                        if (isDeleted)
                        {
                            MessageBox.Show("Задача успешно удалена.");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить задачу.");
                        }
                    };

                    // Добавляем кнопку удаления в контейнер задачи
                    card.Controls.Add(deleteButton);

                    // Добавляем контейнер с текстом в карточку
                    card.Controls.Add(taskInfo);

                    // Добавляем карточку в FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            else
            {
                MessageBox.Show("Нет задач для отображения.");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadManagerTasks();
        }

        private void ApplyFilters_Click(object sender, EventArgs e)
        {
            string priorityCondition = cmbPriorityS.SelectedItem?.ToString();

            string statusCondition = cmbStatus.SelectedItem?.ToString();

            var assigneCondition = cmbAssigneS.SelectedItem as dynamic;
            int? idAssignee = assigneCondition?.Id;

            LoadManagerTasks(priorityCondition, statusCondition, idAssignee);
        }

        private void DisableFilters_Click(object sender, EventArgs e)
        {

            cmbPriorityS.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbAssigneS.SelectedIndex = -1;
            cmbPriorityS.Refresh();
            cmbStatus.Refresh();
            cmbAssigneS.Refresh();

            LoadManagerTasks();
        }
    }
}
