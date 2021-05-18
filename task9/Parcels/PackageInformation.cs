using System;
using System.Collections.Generic;
using System.Text;
using task9.Calculators;

namespace task9.Parcels
{
	public class PackageInformation
	{
        public void getPackageInformation(Package package, PriceCalculator priceCalculator)
        {
            Console.WriteLine($"Город назначения: {package.Address}");
            Console.WriteLine($"Получатель: {package.Addressee}");
            Console.WriteLine($"Стоимость доставки: {package.Price}");
            Console.WriteLine($"Общая стоимость посылки: {priceCalculator.CalculatorPrice(package)}\n");
        }
    }
}
