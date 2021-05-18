using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Calculators
{
    public interface ICalculateStrategy
    {
        public bool IsSuitable(Company company);
        public int CalculatePrice(Company company);
    }



}
