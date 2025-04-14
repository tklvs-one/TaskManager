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
        }




        private void LoadSubordinates()
        {
            // Получаем данные о подчиненных через UserService
            var result = UserService.GetSubordinates(_user.Id);

            if (result != null && result.Count > 0)
            {
                cmbAssignee.Items.Clear();
                foreach (var row in result)
                {
                    // Добавляем подчиненного в ComboBox
                    cmbAssignee.Items.Add(new { Id = row["id"], Login = row["login"] });
                }

                cmbAssignee.DisplayMember = "Login";
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

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || assigneeId == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите подчиненного.");
                return;
            }

            // Используем TaskService для создания задачи
            bool success = TaskService.CreateTask(title, description, assigneeId.Value, _user.Id);

            if (success)
            {
                MessageBox.Show("Задача успешно создана!");
            }
            else
            {
                MessageBox.Show("Ошибка при создании задачи.");
            }
        }
    }
}
