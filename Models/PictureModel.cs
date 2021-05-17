using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class PictureModel
    {
        public Guid PictureId { get; set; }

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }
    }
}
