using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDay1_Q02
{
    abstract class Ramen
    {
        protected int water_qty_;
        protected int cook_time_;

        public Ramen(int water_qty, int boil_time)
        {

        }

        public abstract void MakeRamen();
    }

    class Nuguri : Ramen
    {
        const int pouder_soup = 300;
        bool dasima = true;

        public Nuguri(int water_qty, int boil_time) : base(water_qty, boil_time)
        {
            water_qty_ = water_qty;
            cook_time_ = boil_time;
        }

        public override void MakeRamen()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*Nuguri*" + "\r\n");
            sb.Append("1)Boil water : " + water_qty_ + " ml" + "\r\n");
            sb.Append("2)put in : Men,PouderSoup(" + pouder_soup + ")," + (dasima ? "Dasima " : "") + "\r\n");
            sb.Append("3)Cook : " + cook_time_ + " sec ");
            System.Diagnostics.Debug.Print(sb.ToString());
        }
    }

    class Jin : Ramen
    {
        const int pouder_soup = 200;

        public Jin(int water_qty, int boil_time) : base(water_qty, boil_time)
        {
            water_qty_ = water_qty;
            cook_time_ = boil_time;
        }

        public override void MakeRamen()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*JinRamen*" + "\r\n");
            sb.Append("1)Boil water : " + water_qty_ + " ml" + "\r\n");
            sb.Append("2)put in : Men,PouderSoup(" + pouder_soup + ")" + "\r\n");
            sb.Append("3)Cook : " + cook_time_ + " sec ");
            System.Diagnostics.Debug.Print(sb.ToString());
        }
    }
}
