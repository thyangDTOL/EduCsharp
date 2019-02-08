using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. 클래스에서 클래스로 이벤트를 전달하는 3가지 방법들 중 한가지를 선택하여 예제를
//   작성하시오.  (virtual, abstract, delegate)

namespace TestDay1_Q02
{
    class Program
    {
        static void Main(string[] args)
        {
            //virtual
            Hero hero = new Hero("Samwise Gamgee");
            hero.SayName();
            Charector monster = new Charector("Orc");
            monster.SayName();

            //abstrect
            Jin jinramen = new Jin(400, 300);
            jinramen.MakeRamen();
            Nuguri nuguri = new Nuguri(450, 350);
            nuguri.MakeRamen();

            //delegate
            publisher pb = new publisher();
            subscripter sub = new subscripter(pb);
            pb.BigSale(80);
        }
    }
}
