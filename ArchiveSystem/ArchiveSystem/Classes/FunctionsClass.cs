using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveSystem.Classes
{
    internal class FunctionsClass
    {
        public static Image byteToImage(byte[] img)
        {
            var ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }
    }

}
