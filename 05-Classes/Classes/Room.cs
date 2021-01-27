using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Room //oh hi mark
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        
        public double SurfaceArea
        {
            get
            {
                double topAndBottom = 2 * Length * Width;
                return (
                    2 * Length * Width +
                    2 * Length * Height +
                    2 * Width * Height
                    );
            }

        }


        public double Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }

        public Room () { }

        public Room (double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }




}
}

    



//give this class properties of:
    // Length, Width, Height
    // Surface area and Volume //"getters only"

    // Empty and full Constructor