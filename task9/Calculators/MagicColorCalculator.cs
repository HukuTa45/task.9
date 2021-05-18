using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Calculators
{
    public class MagicColorCalculator : ICalculateStrategy
    {
        public int CalculatePrice(Company company)
        {
            var result = company as MagicColorCompany;
            return company.Material.Price + result.ColorTape.Price;
        }

        public bool IsSuitable(Company company)
        {
            return company is MagicColorCompany;
        }
    }

}
