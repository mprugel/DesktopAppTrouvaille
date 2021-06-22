using System;

namespace DesktopAppTrouvaille.Models
{
    public class LoginEmployeeModel
    {
        public LoginEmployeeModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public LoginEmployeeModel() { }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
