using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MarketStore
{
    public class GoldenCard:DiscountCard
    {
        public GoldenCard() : base()
        {
            discountRate = 2;
        }
        public override void CalculateDiscountRate()
        {
            int count = 0;
            while(count<Turnover)
            {
                discountRate += 1;
                count += 100;
                if(discountRate==10)
                {
                    break;
                }
            }
        }
    }
}
