using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. PropertyTest 클래스에서 다음과 같이 사용 하도록 myProperty 클래스에 IsProc 라는
//   속성을 정의하시오.

namespace TestDay1_Q05
{
    public class PropertyTest
    {
        public PropertyTest()
        {
            myProperty property = new myProperty();
            property.IsProc = true;
            Console.WriteLine(property.IsProc.ToString());
        }
    }

    public class myProperty
    {
        private bool temp = false;
        // 속성 정의 -->
        public bool IsProc { get { return temp; } set { temp = value; }}
        // 속성 정의 <--
    }

    class Program
    {
        static void Main(string[] args)
        {
            PropertyTest pt = new PropertyTest();
        }
    }
}
