using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDay1_Q02
{
    //Virtual
    class Charector
    {
        protected string name_;

        public Charector(string name)
        {
            this.name_ = name;
        }

        virtual public void SayName()
        {
            System.Diagnostics.Debug.Print("I'm " + name_);
        }
    }

    class Hero : Charector
    {
        public Hero(string name) : base(name)
        {

        }

        public override void SayName()
        {
            System.Diagnostics.Debug.Print("I'm Hero " + name_);
        }
    }

    class Mob : Charector
    {
        public Mob(string name) : base(name)
        {

        }
    }
}
