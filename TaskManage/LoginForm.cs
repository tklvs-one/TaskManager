using AuthLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();//
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            // Валидация
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
                return;
            }

            // Попытка авторизовать пользователя
            User user = UserService.AuthenticateUser(login, password);

            if (user != null)
            {
                // Пользователь успешно авторизован
                MessageBox.Show("Авторизация успешна!");

                // Открытие соответствующего окна в зависимости от типа пользователя
                if (user.IsManager)
                {
                    // Если это руководитель, открываем форму для руководителя
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(user);
                    managerForm.Show(); 
                    this.Close();
                }
                else
                {
                    // Если это подчиненный, открываем форму для подчиненного
                    this.Hide();
                    EmployeeForm employeeForm = new EmployeeForm(user);
                    employeeForm.Show();
                    this.Close();
                }

                // Закрываем текущую форму (форма авторизации)
                this.Hide();
            }
            else
            {
                // Неверные данные
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Создаем экземпляр формы авторизации
            RegistrationForm registrationForm = new RegistrationForm();

            // Открываем форму авторизации
            registrationForm.Show();

            // Закрываем текущую форму, если это необходимо
            this.Hide();
        }
    }
}
