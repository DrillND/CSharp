using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210611carRentMgr
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기능 도출(요구분석 사항, 어디까지 개발 할 것인지) 유스케이스 다이어그램
            // 요구분석사항 - 설계(화면 설계 UI,DB설계) - 구현 - 테스트 - 유지보수
            // UML - usercase diagram [하나의 시스템(소프트웨어거나 하드웨어)] - 클래스 diagram - 시퀀스 다이어그램
            
            // ##01 요구사항분석
            // 고객(하나의 액터) - 고객정보 제공
            // 직원 - 고객정보 등록, 상태조회
            // 차량 - 챠량정보 제공
            // 관리자 -  단가 결정, 일일매출 조회,  - (include,반드시 로그인을 거쳐야한다. <>exclude,해도되고 안해도 되는것) - 로그인

            // 화면설계-디자이너,중요한 것:UI/UX   클래스설계-개발자, DB설계(ERD)-DBA
            // 디자인 패턴MVP MVC
        }
    }
}
