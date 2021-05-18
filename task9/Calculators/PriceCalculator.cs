using System;
using System.Collections.Generic;
using System.Text;
using task9.Parcels;

namespace task9.Calculators
{
    public class PriceCalculator
    {
        private ICalculateStrategy[] _concreteCalculators;

        public PriceCalculator(ICalculateStrategy[] concreteCalculators)
        {
            _concreteCalculators = concreteCalculators;
        }
        public int CalculatorPrice(Package package)
        {
            foreach (var concreteCalculator in _concreteCalculators)
            {
                if (concreteCalculator.IsSuitable(package.Company))
                {
                    return concreteCalculator.CalculatePrice(package.Company) + package.Price;
                }
            }
            throw new ArgumentException("Компания не найдена");
        }
    }

}
