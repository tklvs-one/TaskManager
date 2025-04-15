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
using MaterialSkin.Controls;

namespace TaskManage
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
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

                    // Открытие соответствующего окна в зависимости от типа пользователя
                    if (user.IsManager)
                    {
                        // Если это руководитель, открываем форму для руководителя
                        this.Hide();
                        ManagerForm managerForm = new ManagerForm(user);
                        managerForm.Show();

                    }
                    else
                    {
                        // Если это подчиненный, открываем форму для подчиненного
                        this.Hide();
                        EmployeeForm employeeForm = new EmployeeForm(user);
                        employeeForm.Show();

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
        }
    }
}
