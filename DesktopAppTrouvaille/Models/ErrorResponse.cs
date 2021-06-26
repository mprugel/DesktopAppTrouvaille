
using System.Collections.Generic;


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
        public List<string> Email{ get; set; }
        public List<string> Password { get; set; }
        public List<string> ConfirmPassword { get; set; }
    }

}
