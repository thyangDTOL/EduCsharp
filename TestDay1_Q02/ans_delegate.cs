using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDay1_Q02
{
    class subscripter
    {
        public subscripter(publisher pb)
        {
            pb.onBigSale += Pb_onBigSale;
        }

        private void Pb_onBigSale(int sale_rate)
        {
            System.Diagnostics.Debug.Print("Wow !! Big sale " + sale_rate + "%");
        }
    }

    class publisher
    {
        public delegate void BigSaleEventHandler(int sale_rate);
        public event BigSaleEventHandler onBigSale;

        public publisher()
        {

        }

        public void BigSale(int sale_rate)
        {
            if (this.onBigSale != null)
            {
                onBigSale(sale_rate);
            }
        }
    }
}
