using System.Text;
using Npgsql;
using System;
using System.Security.Cryptography;
using System.Text;
using DataBaseLibrary;


namespace AuthLibrary
{
    public static class UserService
    {

        // Метод для хеширования пароля
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Метод для регистрации пользователя
        public static bool RegisterUser(string login, string password, bool isManager, int? managerId)
        {
            try
            {
                string hashedPassword = HashPassword(password); // Хешируем пароль перед сохранением

                var columnValues = new Dictionary<string, object>
                {
                    { "login", login },
                    { "password", hashedPassword },
                    { "is_manager", isManager },
                    { "manager", managerId.HasValue ? (object)managerId.Value : DBNull.Value }
                };

                // Используем метод Add из UserDatabaseService для добавления нового пользователя
                return DataBaseService.Add("Users", columnValues);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при регистрации: " + ex.Message);
                return false;
            }
        }

        // Метод для поиска ID пользователя по логину
        public static int? GetUserIdByLogin(string login)
        {
            try
            {
                var result = DataBaseService.Select("Users", new List<string> { "id" }, "login", login);
                if (result != null && result.Count > 0)
                {
                    return (int?)result[0]["id"];
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении ID пользователя: " + ex.Message);
                return null;
            }
        }

        // Метод для авторизации пользователя
        public static User AuthenticateUser(string login, string password)
        {
            try
            {
                string hashedPassword = HashPassword(password);
                Console.WriteLine("Введенный пароль (хеш): " + hashedPassword);  // Логируем хеш пароля

                // Получаем пользователя по логину
                var result = DataBaseService.Select("Users", new List<string> { "id", "login", "is_manager", "manager", "password" }, "login", login);
                if (result != null && result.Count > 0)
                {
                    var userRow = result[0];
                    string storedPassword = (string)userRow["password"];
                    Console.WriteLine("Пароль из базы данных: " + storedPassword);  // Логируем пароль из базы

                    if (storedPassword == hashedPassword)
                    {
                        int id = (int)userRow["id"];
                        string userLogin = (string)userRow["login"];
                        bool isManager = (bool)userRow["is_manager"];
                        int? managerId = userRow["manager"] as int?;

                        return new User(id, userLogin, isManager, managerId);
                    }
                    else
                    {
                        Console.WriteLine("Пароли не совпадают.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Пользователь не найден.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при авторизации: " + ex.Message);
                return null;
            }
        }

        public static List<Dictionary<string, object>> GetSubordinates(int managerId)
        {
            // Получаем подчиненных для указанного менеджера
            return DataBaseService.Select("Users", new List<string> { "id", "login" }, "manager", managerId);
        }
    }
}