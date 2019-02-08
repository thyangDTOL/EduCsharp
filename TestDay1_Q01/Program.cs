using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.다음과 같이 Using 키워드를 사용하지 않는 변수 myClient, myLog 를 선언하기 위한
//  네임스페이스 및 클래스 구조를 작성하시오.
//  ex) dtolLibrary.TcpSocket.AsyncSocketClient myClient;
//      dtolLibrary.Log myLog;

namespace dtolLibrary
{
    namespace TcpScoket
    {
        class AsyncSocketClient
        {

        }
    }

    class Log
    {

    }
}

namespace TestDay1_Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            dtolLibrary.TcpScoket.AsyncSocketClient myClient = new dtolLibrary.TcpScoket.AsyncSocketClient();
            dtolLibrary.Log myLog = new dtolLibrary.Log();
        }
    }
}
