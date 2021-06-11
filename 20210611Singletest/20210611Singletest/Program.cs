using System;

namespace _20210611Singletest
{
    class Program
    {
        static void Main(string[] args) //프로그램 순서는 메인부터 시작한다. 
        {
            Random r = new Random(); // 여기서 만들어지는 객체가 바로 인스턴스 
            //싱글톤이란? 한 번 만들어진 객체를 계속 쓰자. 

            for (int i = 0; i < 5; i++)
            {
                SingleTest st1 = new SingleTest(r);
                Console.WriteLine("인스턴스: "+st1.getData());
                //Console.WriteLine(new SingleTest().getData());
                // 여기에서 의미는 5개의 서로다른 객체를 생성한 것이다. 
                // 인스턴스 싱글톤 둘 중 인스턴스 추천

                Console.WriteLine("싱글톤: " + SingleTest.getInst(r).getData());
            }

        }
    }
}
