using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkl_app_1_munir.SpaceInveders.Classes
{
    public class PeluruModel
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool IsAktif { get; set; }
        public Image Gambar { get; set; }
    }
}
