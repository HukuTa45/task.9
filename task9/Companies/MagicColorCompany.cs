using System;
using System.Collections.Generic;
using System.Text;
using task9.Materials;

namespace task9.Companies
{
    public class MagicColorCompany : Company
    {

        public MagicColorCompany(Material colorBox, Material colorTape)
        {
            Material = colorBox;
            ColorTape = colorTape;
        }

        public override int Priority => 3;

        public override Material Material { get; }

        public Material ColorTape { get; }
    }

}
