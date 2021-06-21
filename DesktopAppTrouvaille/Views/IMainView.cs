using System;

namespace DesktopAppTrouvaille.Views
{
    public interface IMainView : IView
    {
        void ShowProductView();
        void ShowOrderView();
    }
}
