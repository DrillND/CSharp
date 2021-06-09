using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace _20210609Basic
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("새로운 main");

            // 1차원 배열 초기화 
            int[] arrint = { 10, 20, 30, 40, 50 }; //지역변수
            for (int i = 0; i < arrint.Length; i++)
            {
                Console.Write(arrint[i] + " ");
                string str = string.Format("1차원배열[{0}]:{1}", i, arrint[i]);
                Console.WriteLine(str);
            }


            // 1차원 배열 초기화 2
            Console.WriteLine("=========================");
            char[] arrCh = new char[4] //힙이라는 공간에 만들어진다. 메소드 종료해도 안 사라진다. 가비지 콜렉터가 없앤다.
            {
                '박','김','이','최'
            };
            //다른 메모리 공간에 new만듦

            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
                string str = string.Format("1차원배열[{0}]:{1}", i, arrCh[i]);
                Console.WriteLine(str);
            }



            // 2차원 배열 초기화 1
            Console.WriteLine("=========================");
            int[,] arrin2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < 2; i++) //행
            {
                for (int j = 0; j < 3; j++) //열
                {
                    Console.Write(arrin2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화 2
            Console.WriteLine("=========================");
            string[][] arrStr = new string[2][]; //배열의 행렬
            arrStr[0] = new string[] { "홍길동", "김길동", "박길동" };
            arrStr[1] = new string[] { "전우치", "이순신" };

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < arrStr[i].Length; j++)
                {
                    Console.Write(arrStr[i][j] + " ");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화 3
            Console.WriteLine("=========================");
            int[][] arrInt3 = new int[3][];
            for (int i = 0; i < arrInt3.Length; i++)
            {
                //arrInt3[i] = new int[3];//고정 3행 3열
                arrInt3[i] = new int[i + 1]; //변화
                for (int j = 0; j < arrInt3[i].Length; j++)
                {
                    arrInt3[i][j] = 10 + j;
                    Console.Write(arrInt3[i][j] + " ");
                }
                Console.WriteLine();
            }

            // foreach 1차원 1
            Console.WriteLine("=========================");
            int[] arrEach = { 10, 20, 30, 40, 50 };
            foreach (int i in arrEach) //var 모든 정보를 받을 수 있다.
            {
                Console.Write(i + " ");
            }

            // foreach 1차원 2
            Console.WriteLine("\n=========================");
            string[,] arrEach2 = { { "홍길동", "김길동" }, { "전우치", "박우치" } };

            foreach (string s in arrEach2)
            {
                Console.Write(s + " ");
            }

            // 컬렉션 클래스 = 자료구조
            // List
            Console.WriteLine("\n=========컬렉션 클래스================");
            List<string> list = new List<string>();
            list.Add("홍길동"); //순차적으로 들어간다.
            list.Add("김길동");
            list.Add("박길동");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.RemoveAt(0); // index 0번째 데이터 삭제
            list.Remove("박길동");
            list.Insert(0, "전우치"); //index 0번째 "전우치" 추가
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            // hash table (key, value)
            Hashtable hTable = new Hashtable();
            hTable.Add(1, "홍길동"); //키값, 벨류값
            hTable.Add(2, "김길동");

            if(hTable.Contains(1))
            {
                Console.WriteLine(hTable[1]);
            }

            // 딕셔너리 <>있으면 제네릭 클레스
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key1", "홍길동");
            dic.Add("key2", "김길동");
            dic.Add("key3", "박길동");
            Console.WriteLine("값:{0}", dic["key2"]);

            foreach(KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine("key:{0}-value:{1}", item.Key, item.Value);
            }

            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string val1 in dic.Values)
            {
                Console.WriteLine(val1);
            }
        }
    }
}
