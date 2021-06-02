using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Views
{
    public interface IMainView
    {
        void SetTabView(IDetailView view);
    }
}
