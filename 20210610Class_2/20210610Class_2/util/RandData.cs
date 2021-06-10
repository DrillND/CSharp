using System;

namespace _20210610Class_2.util
{
    class RandData
    {
        private static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        private static int[] age = { 20, 25, 30, 40, 50 };
        private static char[] gender = { '남', '녀' };
        private string[] address = { "대구시 동구 신천3동", "서울시 동구 신천3동", "부산시 동구 신천3동", "대전시 동구 신천3동", "광주시 동구 신천3동" };
        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public int getAge()
        {
            return age[r.Next(0, 5)];
        }
        public char getGendr()
        {
            return gender[r.Next(0, 2)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }
    }
}
