using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210611Singletest
{
    class SingleTest
    {
        private static SingleTest inst;  //inst = 변수명
        private int data;
        //static Random r = new Random(); //static 랜덤 동작이 객체 생성과 상관 없게 다른 곳에 랜덤 객체를 생성

        public SingleTest(Random r) //생성자
        {
            data = r.Next(1, 100);
        }

        public int getData() //인스턴스 메소드
        {
            return data;
        }

        public static SingleTest getInst(Random r)//새롭게 만드는 클래스는 내가 새롭게 만드는 하나의 타입으로 이해해도 된다.
        {
            if(inst == null)
            {
                inst = new SingleTest(r);
            }
            return inst;
            //어떤 메소드 인가? 클래스 메소드
            //싱글톤은 개념 : 처음 만들어진 객체를 계속 재사용
            //여기의 싱글톤은 아무대서나 당겨올 수 있다.
            //똑같은 객체가 계속 리턴되게 되는 형식이다.
        }
    }

}
