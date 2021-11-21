using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress(29202,5,3,"Street1","Country1","City1");
            adress.Method();
            Console.ReadKey();
        }
    }
    class Adress
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public Adress(int index, int apartment, int house, string street, string country, string city)
        {
            this.Apartment = apartment;
            this.City = city;
            this.House = house;
            this.Index = index;
            this.Street = street;
            this.Country = country;
        }
        public void Method()
        {
            Console.WriteLine($"Индекс - {index}, Страна {country}, Город {city}");
            Console.WriteLine($"Улица {street}, Дом {house}, Квартира {apartment}");
        }
    }
}
