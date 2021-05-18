using System;
using System.Collections.Generic;
using System.Text;
using task9.Materials;

namespace task9.Companies
{
    public class GoldSecretCompany : Company
    {
        TightBox tightBox = new TightBox();
        Filler filler = new Filler();
        public GoldSecretCompany(bool isfragile)
        {
            Isfragile = isfragile;
            if (isfragile)
            {
                Filler = filler;
            }
        }

        public override int Priority => 5;
        public bool Isfragile { get; }

        public override Material Material => tightBox;
        public Material Filler { get; set; }


    }

}
