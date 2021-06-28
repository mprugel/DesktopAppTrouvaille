using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;
using System.Collections.Generic;


namespace DesktopAppTrouvaille.Controllers
{
    public class ErrorHandler
    {
        private List<Errors> _error = new List<Errors>();

        public List<Errors> GetErrors()
        {
            return _error;
        }

        public void Reset()
        {
            _error.Clear();
        }
        public void SetError(ErrorViewModel model)
        {
            _error.Clear();
            List<string> errors = (List<string>)model.Errors;
            foreach (string error in errors)
            {
                if (error.Contains("Password"))
                {
                    _error.Add(Errors.PasswordInvalid);
                }
                if (error.Contains("taken"))
                {
                    _error.Add(Errors.UserAlreadyTaken);
                }
            }
        }
    }
}
