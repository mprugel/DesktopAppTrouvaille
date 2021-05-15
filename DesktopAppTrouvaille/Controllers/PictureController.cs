using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public class PictureController
    {
        private List<Bitmap> _images = new List<Bitmap>();

        private int _pos = 0;

        
        public void Next()
        {
            if (_pos < _images.Count - 1)
            {
               _pos++;
            }
            
        }
        public void Previous()
        {
            _pos--;
            if(_pos < 0) 
            {
                _pos = 0; 
            }
        }

        public void AddPicture(Bitmap img)
        {
            _images.Add(img);
            _pos = (_images.Count - 1);
        }

        public void RemoveCurrentPicture()
        {
            _images.RemoveAt(_pos);
        }

        public Bitmap GetCurrentPicture()
        {
            if(_images.Count == 0)
            {
                return null;
            }
            return _images[_pos];
        }
    }
}
