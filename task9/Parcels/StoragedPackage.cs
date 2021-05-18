using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Parcels
{
    public class StoragedPackage : Package
    {
        private Package[] _packages;

        public StoragedPackage(string address, string addressee, Company company, int price)
            : base(address, addressee, company, price)
        {
            _packages = new Package[] { };
        }

        public void AddPackage(Package package)
        {
            Array.Resize(ref _packages, _packages.Length + 1);
            _packages[_packages.Length - 1] = package;
        }
    }

}
