using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthLibrary
{
    public class UserValidator
    {
        // Проверка на валидность логина
        public static bool IsLoginValid(string login)
        {
            return !string.IsNullOrEmpty(login) && login.Length >= 3;
        }

        // Проверка на валидность пароля
        public static bool IsPasswordValid(string password)
        {
            // Проверка на наличие хотя бы одной заглавной буквы
            bool hasUpperCase = password.Any(char.IsUpper);

            // Проверка на наличие хотя бы одной цифры
            bool hasDigit = password.Any(char.IsDigit);

            // Проверка на наличие хотя бы одного спецсимвола
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            // Регулярное выражение для проверки, что пароль состоит хотя бы из одной буквы и одной цифры
            bool isValid = hasUpperCase && hasDigit && hasSpecialChar;

            return !string.IsNullOrEmpty(password) && password.Length >= 6 && isValid ;
        }

    }
}
