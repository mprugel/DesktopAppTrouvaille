using DesktopAppTrouvaille.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public class ProductStateAdd : IProductState
    {
        public IProductState ClickSave(ProductController controller)
        {
            throw new NotImplementedException();
        }

        public IProductState ItemSelected(ProductController controller)
        {
            return new ProductStateEdit();
        }
    }
}
