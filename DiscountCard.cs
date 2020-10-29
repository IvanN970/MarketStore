using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarketStore
{
    public abstract class DiscountCard
    {
        protected Owner owner;
        protected double turnover;
        protected double discountRate;
        public DiscountCard()
        {
            owner = null;
            turnover = 0;
        }
        public Owner Owner
        {
            set { owner = value;}
            get { return owner; }
        }
        public double Turnover
        {
            set { turnover = value;}
            get { return turnover;}
        }
        public double DiscountRate
        {
            set { discountRate = value;}
            get { return discountRate;}
        }
        public abstract void CalculateDiscountRate();
    }
}
