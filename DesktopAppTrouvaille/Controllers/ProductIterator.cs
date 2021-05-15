using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public class ProductIterator
    {
        public int From = 0;
        public int To = 0;
        public int StepSize;

        public ProductIterator(int stepSize = 10)
        {
            StepSize = stepSize;
            To = StepSize - 1;
        }

        public void Next()
        {
            From += StepSize - 1;
            To += StepSize - 1;
        }
        public void Previous()
        {
            From -= StepSize;
            To -= StepSize;
            if(From < 0)
            {
                From = 0;
                To = StepSize - 1;
            }
        }
    }
}
