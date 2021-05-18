using System;
using System.Collections.Generic;
using System.Text;
using task9.Materials;

namespace task9.Companies
{
    public abstract class Company
    {
        public abstract int Priority { get; }
        public abstract Material Material { get; }
    }

}
