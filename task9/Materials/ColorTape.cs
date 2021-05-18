using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Materials
{
    public class ColorTape : Material
    {
        public string Color { get; }

        public ColorTape(string color)
        {
            Color = color;
        }
        public override int Price => 15;
    }

}
