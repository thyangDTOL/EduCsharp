using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. 다음 코드에 사용된 Custom 클래스 구조를 유추하여 작성하시오.
namespace TestDay1_Q04
{
    // ICustomEvent 정의 -->
    interface ICustomEvent
    {
        void iEvent();
    }
    // ICustomEvent 정의 <--

    // CustomClass 정의 -->
    class CustomClass : ICustomEvent
    {
        public delegate void ClickEventHandler(int arg1, string arg2);
        public delegate void CheckEventHandler();

        public event ClickEventHandler ClickEvent;
        public event CheckEventHandler CheckEvent;

        public int arg1 { get; set;}

        public int GetArg1()
        {
            return 0;
        }

        public void iEvent()
        {
            ClickEvent(1, "abc");
            CheckEvent();
        }

        public CustomClass(int v)
        {

        }
    }
    // CustomClass 정의 <--

    class Sample
    {
        CustomClass cc = new CustomClass(5);

        public Sample()
        {
            cc.ClickEvent += cc_ClickEvent;
            cc.CheckEvent += cc_CheckEvent;

            ICustomEvent iCustomEvent = (ICustomEvent)cc;
            cc.iEvent();
        }

        void cc_ClickEvent(int arg1, string arg2)
        {
            int i = cc.arg1;
        }

        void cc_CheckEvent()
        {
            int i = cc.GetArg1();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
        }
    }
}
