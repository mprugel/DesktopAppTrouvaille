using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Views
{
    public interface IDetailView : IView
    {
        void SetModel(IModel model);
        void SetController(IController controller);
    }
}
