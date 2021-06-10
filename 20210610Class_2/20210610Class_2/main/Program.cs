using _20210610Class_2.model;
using _20210610Class_2.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210610Class_2 
{
    class Program 
    {
        static void Main(string[] args)
        {
            RandData rd = new RandData();
            Student[] st = new Student[10]; //다른 패키지에 것 참조 에러 Using

            for (int i = 0;i<st.Length; i++)
            {
                st[i] = new Student( rd.getName(), rd.getAge(), rd.getGendr(), rd.getAddress());
                //t[i]={ rd.getName(), rd.getAge(), rd.getGendr(), rd.getAddress() }; 객체 생성
                //Student [] stt = { rd.getName(), rd.getAge(), rd.getGendr(), rd.getAddress() }; 배열 초기화랑 다른 개념이다.
            }

            for (int i = 0; i < st.Length; i++)
            {
                //st[i].showStudentInfo();
                Console.WriteLine(st[i].ToString());
            }


            st[9].Name = "전우치";
            st[9].Age = 24;
            st[9].Gender = '남';
            st[9].Address = "대구";
            //st[9] = new Student("전우치", 23, '남', "대구");
            //st[9].showStudentInfo();

           
        }
    }
}
