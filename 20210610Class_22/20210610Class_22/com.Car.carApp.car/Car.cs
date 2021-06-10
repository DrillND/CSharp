using System;

namespace _20210610Class_22.com.Car.carApp
{
    class Car
    {
        private string model;
        private string color;
        private int year;
        private string company;
        //static Random r = new Random(); 스테틱 생성해도 된다. 

        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public Car(string[] model, string[] color, int[] year, string[] company, Random r)
        {
            this.model = model[r.Next(0,5)];
            this.color = color[r.Next(0,5)];
            this.year = year[r.Next(0,5)];
            this.company = company[r.Next(0,5)];
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }


        public void printCarInfo()
        {
            Console.WriteLine("모델명: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연식: " + year);
            Console.WriteLine("제조사: " + company);

        }

        public override string ToString()
        {
            string str = "모델명: " + model;
            str += "색상: " + color;
            str += "연식: " + year;
            str += "제조사: " + company;

            return str;
        }
    }
}
