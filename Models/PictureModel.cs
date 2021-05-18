using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Picture
    {
        public Guid PictureId { get; set; }

        public string ImageTitle { get; set; } = String.Empty;

        public byte[] ImageData { get; set; }

        public Bitmap ToBitmap()
        {
            Bitmap img;
            try
            {
                using (MemoryStream stream = new MemoryStream(ImageData))
                {
                    img = new Bitmap(stream);
                } 
                return img; 
            }
            catch(Exception e)
            {
                Bitmap bmp = new Bitmap(1024, 1024);
                using (Graphics g = Graphics.FromImage(bmp)) { g.Clear(Color.White); }
                return bmp;
            }
           
            
        }

        public void SetImageData(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();

            // Convert Picture to Byte Array and add to List:
            ImageData =  (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
