using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthLibrary
{
    public class User
    {
        // Свойства
        public int Id { get; set; }
        public string Login { get; set; }
        public bool IsManager { get; set; }
        public int? ManagerId { get; set; }

        // Конструктор
        public User(int id, string login, bool isManager, int? managerId)
        {
            Id = id;
            Login = login;
            IsManager = isManager;
            ManagerId = managerId;
        }
    }
}
