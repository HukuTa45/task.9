using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Materials
{
    public class ColorBox : Material
    {
        public string Color { get; }

        public ColorBox(string color)
        {
            Color = color;
        }

        public override int Price => 40;
    }

}
