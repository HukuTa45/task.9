using System;
using task9.Calculators;
using task9.Companies;
using task9.Materials;
using task9.Parcels;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceCalculator = new PriceCalculator(new ICalculateStrategy[]
             {
                new GoldSecretCalculator(),
                new MagicColorCalculator(),
                new SimpleFirmCalculator()
             });

            var packageStorage = new PackageStorage();
            var delivery = new Delivery(priceCalculator, packageStorage);

            var packages = new NewPackage[]
            {
                new NewPackage("Санкт-Петербург", "Синцев Владислав Олегович", new GoldSecretCompany(true), 400),
                new NewPackage("Санкт-Петербург", "Синцев Владислав Олегович", new MagicColorCompany(new ColorBox("Green"), new ColorTape("Black")), 200),
                new NewPackage("Москва", "Кузьмина Елена Владимировна", new SimpleFirmCompany(), 500),
                new NewPackage("Курган", "Афанасьев Сергей Викторович", new MagicColorCompany(new ColorBox("Blue"), new ColorTape("Red")), 1200),
                new NewPackage("Самара", "Непоспехова Диана Николаевна", new GoldSecretCompany(false), 650),
                new NewPackage("Камчатка", "Иванов Иван Иванович", new GoldSecretCompany(true), 5000),
            };

            foreach (var package in packages)
            {
                Console.WriteLine($"Был сделан заказ от {package.Company.GetType().Name}");
                Console.WriteLine($"Город назначения: {package.Address}");
                Console.WriteLine($"Получатель: {package.Addressee}");
                Console.WriteLine($"Стоимость доставки: {package.Price}");
                Console.WriteLine($"Общая стоимость доставки: {priceCalculator.CalculatorPrice(package)}\n");
                delivery.HandlePackage(package);
            }

            foreach (var package in packageStorage.Packages)
            {
                Console.WriteLine($"{package.Address} {package.Addressee} {package.Company.GetType().Name} {priceCalculator.CalculatorPrice(package)}");
            }

        }
    }
}
