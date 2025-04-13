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

namespace TaskManage
{
    public partial class ManagerForm : Form
    {
        private User _user;

        public ManagerForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Добро пожаловать, {_user.Login} (Руководитель)";
        }
    }
}
