using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public abstract class Processor
    {
        protected ErrorViewModel _error;
        public ErrorViewModel Error { get { return _error; } }


    }
}
