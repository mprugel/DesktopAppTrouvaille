using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public interface IProductState
    {
        IProductState ClickSave(ProductController controller);
        IProductState ItemSelected(ProductController controller);
    }
}
