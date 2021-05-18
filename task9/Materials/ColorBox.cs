using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Materials
{
    public class ColorBox : Material
    {
        
       public Colors Color { get; }

       public ColorBox(Colors color)
       {
          Color = color;
       }
        
        public override int Price => 40;
    }

}
