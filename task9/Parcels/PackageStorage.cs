using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Parcels
{

    public class PackageStorage
    {
        private StoragedPackage[] _packages;
        public StoragedPackage[] Packages => _packages;
        public PackageStorage()
        {
            _packages = new StoragedPackage[] { };
        }
        public void AddOrUpdate(NewPackage newPackage)
        {
            var storagedPackage = Get(newPackage);
            if (storagedPackage == null)
            {
                Array.Resize(ref _packages, _packages.Length + 1);
                var newStoragedPackage = new StoragedPackage
                (
                    newPackage.Address,
                    newPackage.Addressee,
                    newPackage.Company,
                    newPackage.Price
                );
                _packages[_packages.Length - 1] = newStoragedPackage;
                newStoragedPackage.AddPackage(newStoragedPackage);
                return;
            }
            storagedPackage.AddPackage(newPackage);
        }
        private StoragedPackage Get(Package package)
        {
            foreach (var storagedPackaged in _packages)
            {
                if (package.Address == storagedPackaged.Address
                    && package.Addressee == storagedPackaged.Addressee
                    && package.Company.GetType() == storagedPackaged.Company.GetType())
                    return storagedPackaged;
            }
            return null;
        }
    }

}
