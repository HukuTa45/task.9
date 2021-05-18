using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Calculators
{
    public class GoldSecretCalculator : ICalculateStrategy
    {
        public int CalculatePrice(Company company)
        {
            var result = company as GoldSecretCompany;
            if (result.Filler == null)
            {
                return company.Material.Price;
            }
            return (company.Material.Price + result.Filler.Price) * 2;
        }

        public bool IsSuitable(Company company)
        {
            return company is GoldSecretCompany;
        }
    }


}
