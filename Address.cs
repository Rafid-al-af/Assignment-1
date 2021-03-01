using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Managment_System
{
    class Address
    {
        private int roadNo;
        private int houseNo;
        private string city;
        private string country;

        public Address(int roadNo, int houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;

        }

        public int RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }

        public int HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public void PrintAddress()
        {
            Console.WriteLine("Address:Road No-{0}",this.roadNo);
            Console.WriteLine("Address:House No-{0}", this.houseNo);
            Console.WriteLine("Address:City-{0}", this.city);
            Console.WriteLine("Address:Country-{0}", this.country);
        }
    }
}
