using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarketStore
{
    public class SilverCard:DiscountCard
    {
        public SilverCard() : base()
        {
            discountRate = 2;
        }
        public override void CalculateDiscountRate()
        {
            if(Turnover>300)
            {
                DiscountRate = 3.5;
            }
        }
    }
}
