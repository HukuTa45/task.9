using System;
using System.Collections.Generic;
using System.Text;
using task9.Calculators;
using task9.Parcels;

namespace task9
{
    public class Delivery
    {
        private PackageStorage _packageStorage;
        private PriceCalculator _priceCalculator;

        public Delivery(PriceCalculator priceCalculator, PackageStorage packageStorage)
        {
            _priceCalculator = priceCalculator;
            _packageStorage = packageStorage;
        }
        public int HandlePackage(NewPackage newPackage)
        {
            _packageStorage.AddOrUpdate(newPackage);
            return _priceCalculator.CalculatorPrice(newPackage);
        }
    }

}
