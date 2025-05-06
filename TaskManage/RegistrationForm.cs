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
using MaterialSkin.Controls;


namespace TaskManage
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            txtManagerLogin.Visible = false;
        }

        private void chkIsManager_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsManager.Checked)
            {
                txtManagerLogin.Visible = false;
            }
            else
            {
                txtManagerLogin.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            string managerLogin = txtManagerLogin.Text;

            // Валидация
            if (!UserValidator.IsLoginValid(login) || !UserValidator.IsPasswordValid(password))
            {
                MessageBox.Show("Пожалуйста, убедитесь, что логин и пароль корректны.");
                return;
            }

            bool isManager = chkIsManager.Checked;
            int? managerId = null;

            if (!isManager)
            {
                // Получаем ID менеджера
                managerId = UserService.GetUserIdByLogin(managerLogin);
                if (managerId == null)
                {
                    MessageBox.Show("Менеджер с таким логином не найден.");
                    return;
                }
            }

            // Регистрация пользователя
            bool success = UserService.RegisterUser(login, password, isManager, managerId);
            if (success)
            {
                MessageBox.Show("Пользователь успешно зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при регистрации.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Создаем экземпляр формы авторизации
            LoginForm loginForm = new LoginForm();

            // Открываем форму авторизации
            loginForm.Show();

            // Закрываем текущую форму, если это необходимо
            this.Hide();
        }
    }
}
