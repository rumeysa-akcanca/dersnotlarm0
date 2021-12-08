using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İK_project
{
    class Address
    {

        public string city { get; set; }
        public string country { get; set; }
        public int HouseNumber { get; set; }
        public string Street{ get; set; }
        public  int ZipCode { get; set; }
        public int ID { get;  }
        public Address(int ıd)
        {
            this.ID = ıd;
        }
       
        public Address(string city, string country, int houseNumber, string street, int zipCode)
        {
            this.city = city;
            this.country = country;
            HouseNumber = houseNumber;
            Street = street;
            ZipCode = zipCode;
        }


    }
}
