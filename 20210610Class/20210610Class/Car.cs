using System;

namespace _20210610Class // 자바의 패키지 개념
{
    class Car
    {
        // 클래스 변수
        public const string JIJUM = "동대구 영업소"; //const ==상수 변수
        // 클래스 = 오브젝트 UML
        // 테이블 = 엔터티(개체) ERD(개체의 관계)**중요함


        // 클래스 변수와 인스턴스 변수 다른 위치에 저장된다.


        // 인스턴스 변수, 객체 생성한 곳 안에 잡히는 변수다.
        private string company; //자동으로 프라이빗 된다.(씨샾에서)
        private string color; //멤버 변수
        private string price;
        private string model;

        public Car() //매개변수가 없는 기본 생성자, 타입이 없는 특수한 메소드, 객체를 생성할 때 만들어지는
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }
        //블럭 후 컨트롤 슬러시, 컨트롤 씨프트 슬러시
        public Car(String company, string color, string model, string price) //생성자 오버로딩
        {
            this.company = company; //this = 인스턴스 변수, 객체 자기 자신의 주소값
                                    //this 없으면 두 컴퍼니 다 매개변수인줄 안다.

        }


        public void printCarInfo()
        {
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " + price);

        }

        public void setModel(string model) //카멜방식 변수이름 설정
        {
            this.model = model;
        }

        public void SetPrice(string price) //파스칼 방식 (C#에서)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }

        public string getPrice()
        {
            return price;
        }





    }
}
