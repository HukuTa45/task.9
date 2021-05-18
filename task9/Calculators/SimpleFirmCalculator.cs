using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Calculators
{
    public class SimpleFirmCalculator : ICalculateStrategy
    {
        public int CalculatePrice(Company company)
        {
            return company.Material.Price;
        }

        public bool IsSuitable(Company company)
        {
            return company is SimpleFirmCompany;
        }
    }


}
