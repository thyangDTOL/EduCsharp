using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//3. 현재 시간을 출력하는 예제이다. 4개의 Clock 클래스를 생성하여 다음과 출력
//   되도록 Form1 클래스를 수정하시오.

//   ex) Clock:0, Time:2019-01-30 08:19:47
//        Clock:1, Time:2019-01-30 09:19:47
//        Clock:2, Time:2019-01-30 10:19:47
//        Clock:3, Time:2019-01-30 11:19:47


namespace TestDay1_Q03
{

    public partial class Form1 : Form
    {

        //수정 -->
        //Clock myClock;
        private int clock_count = 4;
        List<Clock> myClock = new List<Clock>();
        //수정
        public Form1()
        {
            InitializeComponent();

            btnPrint.Click += btnPrint_Click;

            //수정 -->
            //myClock = new Clock();
            //myClock.ClockNo = 0;
            //myClock.ClockEvent += myClock_ClockEvent;
            for (int i = 0; i < clock_count; i++)
            {
                myClock.Add(new Clock());
                myClock[i].ClockNo = i;
                myClock[i].ClockEvent += myClock_ClockEvent;
            }
            //수정 <--
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //수정 -->
            //myClock.Trigger();
            foreach (Clock myclock in myClock )
            {
                myclock.Trigger();
            }
            //수정 <--
        }

        private void myClock_ClockEvent(int ClockNo, string CurrTime)
        {
            System.Diagnostics.Debug.Print("ClockNo:{0}, Time:{1}", ClockNo, CurrTime);
        }
    }

    class Clock
    {
        public delegate void ClockEventHandler(int ClockNo, string CurrTime);
        public event ClockEventHandler ClockEvent = null;

        public int ClockNo = -1;

        public Clock() { }

        public Clock(int ClockNo) { this.ClockNo = ClockNo; }

        public void Trigger()
        {
            if (ClockEvent != null)
            {
                DateTime dt = DateTime.Now;
                dt = dt.AddHours(ClockNo);

                ClockEvent(ClockNo, dt.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
    }
}
