using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class_22.com.Car.carApp.util
{
    class RandomCustomer
    {
        private String[] name;
        private String[] tel;
        private String[] address;
        private String[] model;
        private String[] color;
        private int[] year;
        private String[] company;


        Random r = new Random();
        //Program p = new Program(); !!!메인이 있는 클래스 호출 하면 안됨!!! 게터를 사용해서 옮김
        //
        //메인에 있는 배열을 당겨 오고 싶은데 어떻게 하는가?
        //힌트 매개변수가 있는 생성자. 여기서 코드를 더 줄이려면 리스트로 변수들을 한번에 넘기면 된다.

        public RandomCustomer(String[] name, String[] tel, String[] address, String[] model, String[] color, int[] year, String[] company)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        
        
        

        public string getName()
        {
            return name[r.Next(0, 5)];
        }
    }
}
