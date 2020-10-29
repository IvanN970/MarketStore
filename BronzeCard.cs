using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MarketStore
{
    public class BronzeCard:DiscountCard
    {
        public BronzeCard() : base()
        {
            discountRate = 0;
        }
        public override void CalculateDiscountRate()
        {
            if(Turnover>=100 && Turnover<=300)
            {
                discountRate = 1;
            }
            else if(Turnover>300)
            {
                discountRate = 2.5;
            }
            else
            {
                Console.WriteLine("No discount for purchase under 100$");
            }
        }
    }
}
