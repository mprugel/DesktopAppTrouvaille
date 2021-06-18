
namespace DesktopAppTrouvaille.Controllers
{
    public class Iterator
    {
        public int From = 0;
        public int To = 0;
        public int StepSize;
        public int Count = 0;
        public int CurrentPage = 0;

        public Iterator(int stepSize = 10)
        {
            StepSize = stepSize;
            To = StepSize - 1;
        }

        public void Reset()
        {
            To = StepSize - 1;
            From = 0;
            CurrentPage = 0;
        }

        public void Next()
        {
            if(To <= Count)
            {
                From += StepSize - 1;
                To += StepSize - 1;
                CurrentPage++;
            }

        }
        public void Previous()
        {
            From -= StepSize;
            To -= StepSize;
            CurrentPage--;
            if(From < 0)
            {
                CurrentPage = 0;
                From = 0;
                To = StepSize - 1;
                
            }
        }
    }
}
