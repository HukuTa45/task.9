using System;
using System.Collections.Generic;
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
            PriceCalculator priceCalculator = new PriceCalculator(new ICalculateStrategy[]
            {
                new GoldSecretCalculator(),
                new MagicColorCalculator(),
                new SimpleFirmCalculator()
            });
            
            var packageInfo = new PackageInformation();
            var flag = true;
            var packageStorage = new PackageStorage();
            var delivery = new Delivery(priceCalculator, packageStorage);

            var packages = new List<NewPackage>
            {
                new NewPackage("Город 1", "Получатель 1", new GoldSecretCompany(true), 100, false),
                new NewPackage("Город 2", "Получатель 2", new MagicColorCompany(new ColorBox(Colors.Blue), new ColorTape(Colors.Red)), 100, false),
                new NewPackage("Город 3", "Получатель 3", new SimpleFirmCompany(), 50, false),
                new NewPackage("Город 4", "Получатель 4", new MagicColorCompany(new ColorBox(Colors.Green), new ColorTape(Colors.Red)), 100, false),
                new NewPackage("Город 5", "Получатель 5", new GoldSecretCompany(false), 350, false),
                new NewPackage("Город 6", "Получатель 6", new GoldSecretCompany(true), 1000, false),
                new NewPackage("Город 7", "Получатель 7", new MagicColorCompany(new ColorBox(Colors.White), new ColorTape(Colors.Red)), 160, false),
                new NewPackage("Город 8", "Получатель 8", new SimpleFirmCompany(), 500, false),
                new NewPackage("Город 9", "Получатель 9", new MagicColorCompany(new ColorBox(Colors.Red), new ColorTape(Colors.Red)), 200, false),
            };

            packages.Sort((a, b)=>
            {
                if (a.Company.Priority == b.Company.Priority)
                    return 0;
                if (a.Company.Priority < b.Company.Priority)
                    return 1;
                else return -1;             
            });
            while (flag)
            {
                Console.WriteLine("Введите:\n\"1\" - для просмотра очереди всех посылок" +
                    "\n\"2\" - для просмотра всех отпраленных посылок" +
                    "\n\"3\" - для просмотра всех неотправленных посылок" +
                    "\n\"4\" - для передачи курьеру 4-ех посылок курьеру" +
                    "\n\"5\" - для выхода");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        foreach (var package in packages)
                        {
                            Console.WriteLine($"Был сделан заказ от {package.Company.GetType().Name}");
                            packageInfo.getPackageInformation(package, priceCalculator);
                            delivery.HandlePackage(package);

                        }
                        break;
                    case 2:
                        foreach (var package in packages)
                        {
                            if (package.Delivered == true)
                            {
                                Console.WriteLine($"Заказ от {package.Company.GetType().Name} был отправлен");
                                packageInfo.getPackageInformation(package, priceCalculator);
                               
                            }
                        }
                        break;
                    case 3:
                        foreach (var package in packages)
                        {
                            if (package.Delivered == false)
                            {
                                Console.WriteLine($"Заказ от {package.Company.GetType().Name} еще не отправлен");
                                packageInfo.getPackageInformation(package, priceCalculator);
                               
                            }
                        }
                        break;
                    case 4:
                        var currentCount = 0;
                        for (var index = 0; index < packages.Count; index++)
                        {
                            if (currentCount == 4) break;

                            if (packages[index].Delivered == false)
                            {                              
                                packages[index].Delivered = true;
                                Console.WriteLine($"Заказ от {packages[index].Company.GetType().Name} был передан курьеру");
                                packageInfo.getPackageInformation(packages[index], priceCalculator);
                                currentCount++;
                            }
                        }
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }

        }
    }
}
