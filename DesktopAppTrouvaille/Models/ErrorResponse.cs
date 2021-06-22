using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{

    public class ErrorResponse
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
        public Errors errors { get; set; }
    }

    public class Errors
    {
        public string[] Email { get; set; }
        public string[] Password { get; set; }
        public string[] ConfirmPassword { get; set; }
    }

}
