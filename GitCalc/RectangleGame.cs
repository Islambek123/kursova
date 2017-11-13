using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalc
{
    public class RectangleGame : Matrix
    {
        public Point Begin { get; set; }
        public Point End { get; set; }

        public RectangleGame()
        {
            Width = 10;
            Length = 15;
        }
    }

    public class Matrix 
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public int Type { get; set; }

     

        //public int Width { get; set; }
        //public int Length { get; set; }

        //public void GetMatrixSize()
        //{
        //    Width = 10;
        //    Length = 10;

        //    
        //}

    }
}
