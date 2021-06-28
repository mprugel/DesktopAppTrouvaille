
using DesktopAppTrouvaille.Enums;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Controllers
{
    public interface IErrorHandler
    {
        List<Errors> GetError();
    }
}
