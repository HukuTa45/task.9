using System;
using System.Collections.Generic;
using System.Text;
using task9.Materials;

namespace task9.Companies
{
    public class SimpleFirmCompany : Company
    {
        DefaultBox defaultBox = new DefaultBox();

        public override int Priority => 1;

        public override Material Material => defaultBox;
    }

}
