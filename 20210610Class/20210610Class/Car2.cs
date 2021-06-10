using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class
{
    class Car2
    {
        //클래스 변수
        public const string JIJUM = "동대구 영업소"; 

        //인스턴스 변수
        private string company; 
        private string color; 
        private string price;
        private string model;

        //람다식(익명함수 개념??), 인스턴스 변수 블록 - 전구 클릭 - 필드캡술화
        public string Company { get => company; set => company = value; }
        //앞에 컴퍼니 특수한 메소드
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        public Car2(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }

        public void printCarInfo()
        {
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);

        }

        // 빈칸 클릭-드라이버 아이콘 - 재정의
        public override string ToString()
        {
            string str = "제조사 : " + company + "\n";
            str += "색상: " + color + "\n";
            str += "모델: " + model + "\n";
            str += "가격: " + price + "\n";
            return str; //상속받은 부모의 위치정보  base 여기서는 오브젝트 부모
        }


    }
}
