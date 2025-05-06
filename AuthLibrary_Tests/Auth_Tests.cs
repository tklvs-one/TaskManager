using AuthLibrary;
using DataBaseLibrary;
using Npgsql;
using System.Text.RegularExpressions;

namespace AuthLibrary_Tests
{
    [TestClass]
    public class Auth_Tests
    {
        private const string login = "testuser";
        private const string password = "Qwerty1!";

        [ClassInitialize]
        public static void GlobalSetup(TestContext context)
        {
            using var conn = new NpgsqlConnection(DataBaseService.connectionString);
            conn.Open();
            using var del = new NpgsqlCommand("DELETE FROM Users WHERE login = 'testuser'", conn);
            del.ExecuteNonQuery();
            using var insert = new NpgsqlCommand("INSERT INTO Users (login, password, is_manager, manager) VALUES (@login, @password, false, 1)", conn);
            insert.Parameters.AddWithValue("login", login);
            insert.Parameters.AddWithValue("password", UserService.HashPassword(password));
            insert.ExecuteNonQuery();
        }

        [TestMethod] public void TC1_IsLoginValid_TooShort() => Assert.IsFalse(UserValidator.IsLoginValid("ab"));
        [TestMethod] public void TC2_IsLoginValid_Valid() => Assert.IsTrue(UserValidator.IsLoginValid("testuser"));
        [TestMethod] public void TC3_IsPasswordValid_Invalid() => Assert.IsFalse(UserValidator.IsPasswordValid("abcdef"));
        [TestMethod] public void TC4_IsPasswordValid_Valid() => Assert.IsTrue(UserValidator.IsPasswordValid("Qwerty1!"));

        [TestMethod]
        public void TC5_HashPassword_CorrectLengthAndFormat()
        {
            var hash = UserService.HashPassword("test123!");
            Assert.AreEqual(64, hash.Length);
            Assert.IsTrue(Regex.IsMatch(hash, "^[a-f0-9]{64}$"));
        }

        [TestMethod] public void TC6_AuthenticateUser_UnknownLogin() => Assert.IsNull(UserService.AuthenticateUser("nouser", "Qwerty1!"));
        [TestMethod]
        public void TC7_AuthenticateUser_ValidCredentials()
        {
            var user = UserService.AuthenticateUser(login, password);
            Assert.IsNotNull(user);
            Assert.AreEqual(login, user.Login);
        }

        [TestMethod] public void TC8_AuthenticateUser_WrongPassword() => Assert.IsNull(UserService.AuthenticateUser(login, "Wrong123!"));
        [TestMethod] public void TC9_RegisterUser_ManagerValid() => Assert.IsTrue(UserService.RegisterUser("manager1", "Qwerty1!", true, null));
        [TestMethod] public void TC10_RegisterUser_SubordinateValid() => Assert.IsTrue(UserService.RegisterUser("worker1", "Qwerty1!", false, 1));
        [TestMethod] public void TC11_RegisterUser_SubordinateNoManager() => Assert.IsFalse(UserService.RegisterUser("worker2", "Qwerty1!", false, null));
        [TestMethod] public void TC12_RegisterUser_SubordinateInvalidManager() => Assert.IsFalse(UserService.RegisterUser("worker3", "Qwerty1!", false, 9999));
        [TestMethod] public void TC13_RegisterUser_EmptyLogin() => Assert.IsFalse(UserService.RegisterUser("", "Qwerty1!", false, 1));
        [TestMethod] public void TC14_RegisterUser_EmptyPassword() => Assert.IsFalse(UserService.RegisterUser("testuser2", "", false, 1));
        [TestMethod] public void TC15_RegisterUser_InvalidPassword() => Assert.IsFalse(UserService.RegisterUser("testuser3", "Qwerty1", false, 1));
        [TestMethod] public void TC16_RegisterUser_ExistingLogin() => Assert.IsFalse(UserService.RegisterUser("testuser", "Qwerty1!", false, 1));

    }
}