using System;

namespace DesktopAppTrouvaille.Models
{
    public class Employee : IModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid GetGuid()
        {
            return new Guid(Id);
        }
    }
}
