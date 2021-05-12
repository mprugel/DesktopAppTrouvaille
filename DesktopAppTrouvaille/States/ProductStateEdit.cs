using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.States
{
    public class ProductStateEdit : IProductState
    {
        public IProductState ClickSave(ProductController controller)
        {
            
            return this;
        }

        public IProductState ItemSelected(ProductController controller)
        {
            return this;
        }
    }
}
