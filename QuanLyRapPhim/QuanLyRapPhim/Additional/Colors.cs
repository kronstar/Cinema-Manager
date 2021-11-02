using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.Additional
{
    class Colors
    {
        public static Color SelectedSeatColor()
        {
            Color color = new Color();
            color = Color.FromArgb(255, 117, 117);
            return color;
        }

        public static Color SoldSeatColor()
        {
            Color color = new Color();
            color = Color.FromArgb(214, 212, 208);
            return color;
        }

        public static Color SeatColor()
        {
            Color color = new Color();
            color = Color.FromArgb(50, 125, 168);
            return color;
        }

        public static Color TextColor()
        {
            Color color = new Color();
            color = Color.FromArgb(245, 245, 245);
            return color;
        }

        public static Color BackGroundColor()
        {
            Color color = new Color();
            color = Color.FromArgb(46, 46, 46);
            return color;
        }

        public static Color MainColor()
        {
            Color color = new Color();
            color = Color.FromArgb(69, 101, 255);
            return color;
        }
    }
}