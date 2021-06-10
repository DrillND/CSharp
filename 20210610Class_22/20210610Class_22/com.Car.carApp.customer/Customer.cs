using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class_22.com.Car.carApp.customer
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        private Car car;

        //Random r = new Random();

        public Customer(string[] name, string[] tel, string[] address, Car car, Random r)
        {
            this.name = name[r.Next(0,5)];
            this.tel = tel[r.Next(0,5)];
            this.address = address[r.Next(0,5)];
            this.car = car;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        internal Car Car { get => car; set => car = value; }


        public void printCustomerInfo()
        {
            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화번호: " + tel);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("차량정보: " + car);

        }
    }
}
