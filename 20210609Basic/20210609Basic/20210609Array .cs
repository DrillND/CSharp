using System;

namespace _20210609Basic
{
    class Class2
    {
        static void Main(string[] args)
        {
            //기본 알고리즘 6번째 array (배열)
            //01
            Console.WriteLine("문제 1");
            Console.WriteLine("==============================");
            int[] arr = { 20, 34, 22, 14, 36, 23, 67 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            //Console.WriteLine(arr.Length);
            Console.WriteLine("합 : {0}, 평균 : {1}", sum, sum / (arr.Length));



            //02
            Console.WriteLine("\n문제 2");
            Console.WriteLine("==============================");
            int[] arr2 = new int[100];
            for (int i = 0; i < arr2.Length - 10; i++)
            {
                arr2[i] = i + 1;
                if (arr2[i] % 5 == 0)
                {
                    Console.WriteLine(arr2[i]);
                }

            }

            //03
            Console.WriteLine("\n문제 3");
            Console.WriteLine("==============================");
            int[] arr3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] arr33 = new int[10];

            //Console.WriteLine(arr3.Length);
            for (int i = 0; i < arr33.Length; i++)
            {
                arr33[i] = arr3[(arr3.Length - 1) - i];
                Console.Write(arr33[i] + " ");
            }

            //04 헷갈림
            Console.WriteLine("\n문제 4");
            Console.WriteLine("==============================");
            int[][] arr4 = new int[5][];

            arr4[0] = new int[] { 1, 2 };
            arr4[1] = new int[] { 2, 4, 6 };
            arr4[2] = new int[] { 3, 6 };
            arr4[3] = new int[] { 4, 8, 10, 12 };
            arr4[4] = new int[] { 10 };

            for (int i = 0; i < arr4.Length; i++)
            {
                for (int j = 0; j < arr4[i].Length; j++)
                {
                    Console.Write(arr4[i][j] + " ");
                }
                Console.WriteLine();
            }

            //05
            Console.WriteLine("\n문제 5");
            Console.WriteLine("==============================");

            int[][] arr5 = new int[3][];
            for (int i = 0; i<arr5.Length; i++)
            {
                for(int j=0; i<arr5.Length; j++)
                {
                    arr5[i][j] = { }
                }
                
               
            }
            int[][] arr55 = new int[3][];
            for (int i = 0; i < arr55.Length; i++)
            {
                for (int j = 1; j < 10; j = j + 3)
                {
                    arr5[i] = new int[] { j*10, (j + 1)*10, (j + 2)*10 };
                }

            }
            
            

            //06
            Console.WriteLine("\n문제 6");
            Console.WriteLine("==============================");

            int[][] arr6 = new int[8][];

            for (int i = 0; i < arr6.Length+1; i++)
            {
                for (int j = 0; j < arr6.Length; j++)
                {
                    Console.Write("{0}X{1}={2}\t", j + 2, i + 1, (j + 2) * (i + 1));
                }
                Console.WriteLine();
            }


            //07
            Console.WriteLine("\n문제 7");
            Console.WriteLine("==============================");

        }
    }
}
