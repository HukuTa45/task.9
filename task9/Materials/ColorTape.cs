using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Materials
{
    public class ColorTape : Material
    {
        public Colors Color { get; }

        public ColorTape(Colors color)
        {
            Color = color;
        }
        public override int Price => 15;
    }

}
