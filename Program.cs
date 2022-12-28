// See https://aka.ms/new-console-template for more information
/* 
 * C#에 대한 기초적인 이해 2022.12.28
 */

// using 키워드 (~를 사용하겠다는 선언)
using System; // using 키워드를 사용해 기본 필요 클래스를 가지고있는 System namespace안의 클래스를 사용하겠다고 선언) 
/*
 * ex) System.Console.WriteLine(...)를 계속해서 사용해야함 -> 그냥 Console.WriteLine()만 사용할 수 있음
 * using만 사용한다면 namespace(C++에서 나옴, 내부 식별자 간의 이름 충돌 방지, 유효 범위 제공 영역 제공) 전체를 사용한다는 의미
 * using static은 특정 데이터 형식(ex. 클래스)의 정적 멤버를 데이터 형식의 이름을 명시하지 않고 참조하겠다는 의미
 * ex) using static System.Console -> Console.WriteLine()에서 Console을 생략하고 사용할 수 있다.
 */

Console.WriteLine("Hello, World!"); // Console 도화지에 글을 쓴다.

namespace HelloCSharp // namespace 선언
{
    class Program // Class 선언
    {
        static void Main(string[] args) // 운영체제에 의해 호출되는 유일한 함수, string[] args -> 인자를 받는 경우
        {
            Console.WriteLine("hi"); // 실행 후 console 창이 바로 닫힘 (Main 함수가 끝나 프로그램 종료됨)
            Console.ReadKey(); // 커서가 깜박깜박 거리면서 Console 창이 닫히지 않음 -> 어떤 키가 눌러질 때까지 대기함
        }
    }
}
