using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //기본생성자, 안만들었는데, C#컨파일러가만들어준다. 
            //new 메모리 할당해서 다른 곳에 저장, 메모리 해제 가비지 컬렉터가 해준다.

            car.printCarInfo();

            Car car2 = new Car("현대", "은색", "G80", "6천만원");
            car2.SetPrice("7천만원");
            car2.printCarInfo();
            Console.WriteLine("가격표: " + car2.getPrice());

            Car2 car3 = new Car2("테슬라","빨강","1억2천","모델s");
            car3.Price = "4천오백만원";
            Console.WriteLine("가격표:" + car3.Price);
            Console.WriteLine(car3.ToString());
            Console.WriteLine("-----------");
            car3.printCarInfo();
        }
    }
}
