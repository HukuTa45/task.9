using System;
using System.Collections.Generic;
using System.Text;
using task9.Companies;

namespace task9.Parcels
{
    public class Package
    {
        public Package(string address, string addressee, Company company, int price)
        {
            Address = address;
            Addressee = addressee;
            Company = company;
            Price = price;
        }
        public string Address { get; }
        public string Addressee { get; }
        public Company Company { get; }
        public int Price { get; }

    }


}
