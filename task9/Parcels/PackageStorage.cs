using System;
using System.Collections.Generic;
using System.Text;

namespace task9.Parcels
{

    public class PackageStorage
    {
        private List<StoragedPackage> _packages;
        public List<StoragedPackage> Packages => _packages;
        public PackageStorage()
        {
            _packages = new List<StoragedPackage> { };
        }
        public void AddOrUpdate(NewPackage newPackage)
        {
            var storagedPackage = Get(newPackage);
            if (storagedPackage == null)
            {               
                var newStoragedPackage = new StoragedPackage
                (
                    newPackage.Address,
                    newPackage.Addressee,
                    newPackage.Company,
                    newPackage.Price,
                    newPackage.Delivered
                );
                _packages.Add(newStoragedPackage);
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
