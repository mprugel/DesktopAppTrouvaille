using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class ErrorViewModel
    {

        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; }

        public DateTime? ExpireDate { get; set; }

    }
}
