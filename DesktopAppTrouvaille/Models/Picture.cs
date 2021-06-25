using System;
using System.Drawing;
using System.IO;


namespace DesktopAppTrouvaille.Models
{
    public class Picture
    {
        public Guid PictureId { get; set; }

        public string ImageTitle { get; set; } = String.Empty;

        public byte[] ImageData { get; set; }

        public Bitmap ToBitmap()
        {
            if(ImageData != null)
            {
                using (MemoryStream stream = new MemoryStream(ImageData))
                {
                    try
                    {
                        return new Bitmap(stream); 
                    }
                    catch(ArgumentException e)
                    {
                        return CreateEmptyBitmap();
                    }
                   
                }

            }
            return CreateEmptyBitmap();
        }

        private Bitmap CreateEmptyBitmap()
        {
            Bitmap img = new Bitmap(450, 300);
            using (Graphics g = Graphics.FromImage(img))
            using (Brush brush = new SolidBrush(Color.Black))
            using (Font font = new Font("Arial", 20))
            {
                g.Clear(Color.White);
                g.DrawString("Noch kein Bild vorhanden", font, brush, new Point(0, 150));
            }
            return img;
        }

        public void SetImageData(Bitmap img)
        {
            Bitmap resized = Resize(img,450,300);
            ImageConverter converter = new ImageConverter();

            // Convert Picture to Byte Array and add to List:
            ImageData =  (byte[])converter.ConvertTo(resized, typeof(byte[]));
        }


        // Resizes and Crops an Image to given Size:
        private Bitmap Resize(Bitmap img, int width, int height)
        {
            if(img == null || width > img.Width || height > img.Height)
            {
                return img;
            }

            float xPos = (img.Width - width) / 2;
            float yPos = (img.Height - height) / 2;
            float ratio = width / height;
            RectangleF destRect = new RectangleF(0,0,width,height);
            RectangleF sourceRect = new RectangleF((img.Width- ratio * img.Height) / 2, 0, ratio * img.Height, img.Height);
            Bitmap resizedImg = new Bitmap(width, height);
            using(Graphics g = Graphics.FromImage(resizedImg))
            {
                g.DrawImage(img,destRect,sourceRect,GraphicsUnit.Pixel);
            }

            return resizedImg;
        }
    }
}
