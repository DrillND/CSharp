using _20210610Class_22.com.Car.carApp;
using _20210610Class_22.com.Car.carApp.customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class_22
{
    class Program
    {
        public static void Main(string[] args)
        {
            String[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            String[] tel = {"010-1234-5678", "010-4321-5678", "010-3478-1278","010-4523-1978", "010-7890-2134"};
            String[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동","부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
            String[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
            String[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
            int[] year = { 2016, 2017, 2016, 2017, 2016 };
            String[] company = { "삼성르노", "현대", "현대", "기아", "현대" };
            Random r = new Random();
            
            //Customer ct = new Customer(name, tel, address, new Car(model, color, year, company));
            //ct.printCustomerInfo();
            
            Customer[] arr = new Customer[10];
            
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i]= new Customer(name, tel, address, new Car(model, color, year, company, r), r);

                arr[i].printCustomerInfo();
            }            

        }
    }
}
