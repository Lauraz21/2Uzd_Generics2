using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Uzd_Generics2
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public FourSideGeometricFigure(string name, int baseParam, int heightParam)
        {
            Name = name;
            Base = baseParam;
            Height = heightParam;
        }

        public int GetArea()
        {
            return Base * Height;
        }
        public override string ToString()
        {
            return Name + " \nPlotas: " + GetArea();
        }


    }
}
