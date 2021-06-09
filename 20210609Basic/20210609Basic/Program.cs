using System;
using System.Collections.Generic; //using = import
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210609Basic // 네임 스페이스 = 자바의 패키지의 개념, 하나의 파일 하나의 클래스
{
    class Program  //클래스 이름 첫자는 대문자, 자바와 같은 구조.
    {
        /// <summary>
        /// 요약된 정보
        /// </summary>
        /// <param name="args">매개변수 정보</param>
        
        // 비주얼 스튜디오에서는 하나의 프로젝트에 하나의 메인만.
        static void Main(string[] args) //static =  클래스 메소드 main = 진입점
        {
            //기본 출력
            Console.Write("안녕하세요");
            Console.WriteLine("헬로우 C#"); //콘솔 = 클래스
            // 그냥 시작 = 디버깅 모드, 디버깅하지 않고 시작 Ctrl +F5

            //입력
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine(); //스트링 클래스인데 소문자
            Console.WriteLine("이름 : " + name);

            Console.Write("나이 입력 : ");
            //string age = Console.ReadLine(); //스캐너의 역할, 타입 맞춰주기
            //int nage = Convert.ToInt32(age);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("나이 : {0}", age); // c에서 프린트 에프
            Console.WriteLine("나이 : {0}, 이름: {1}", age, name);
            
            string str = string.Format("이름: {0},나이: {1}", name, age);
            Console.WriteLine(str);

            //이클립스 f3 = 여기서 f12, 맨위에 좌측



        }
    }
}
