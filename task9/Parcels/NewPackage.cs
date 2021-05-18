using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Parcels
{
    public class NewPackage : Package
    {
        public NewPackage(string address, string addressee, Company company, int price, bool delivered)
            : base(address, addressee, company, price, delivered)
        {
        }
    }

}
