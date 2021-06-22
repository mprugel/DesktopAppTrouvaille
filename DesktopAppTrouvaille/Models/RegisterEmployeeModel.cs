

namespace DesktopAppTrouvaille.Models
{
    public class RegisterEmployeeModel
    {
        public RegisterEmployeeModel(Employee employee,string password, string confirmPassword)
        {
            Email = employee.Email;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Password = password;
            ConfirmPassword = confirmPassword;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
