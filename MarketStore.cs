using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarketStore
{
    class Program
    {
        static Owner CreateOwner()
        {
            Owner owner = null;
            try
            {
                Console.WriteLine("Enter owner name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter owner town:");
                string town = Console.ReadLine();
                Console.WriteLine("Enter owner age:");
                int age = int.Parse(Console.ReadLine());
                if (age > 0)
                {
                    owner = new Owner();
                    owner.Name = name;
                    owner.Age = age;
                    owner.Town = town;
                }
                else
                {
                    Console.WriteLine("Age must be a positive number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return owner;
        }
        static DiscountCard ChooseCardType(string cardType)
        {
            DiscountCard card = null;
            switch (cardType)
             {
                 case "golden":
                    card = new GoldenCard();
                    break;
                    case "silver":
                     card = new SilverCard();
                     break;
                    case "bronze":
                      card = new BronzeCard();
                      break;
                    default:
                      Console.WriteLine("No such type of card");
                      break;
                }
            return card;
        }
        static bool ValidateTurnOverAndPurchasePrice(double turnover,double purchasePrice)
        {
            if(turnover<=0 || purchasePrice<=0)
            {
                Console.WriteLine("Turnover and purchase price must be positive numbers");
                return false;
            }
            return true;
        }
        static void Purchase(DiscountCard card,Owner owner)
        {
            if(owner!=null)
            {
                try
                {
                    Console.WriteLine("Enter purchase price:");
                    double purchasePrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter turnover:");
                    double turnover = double.Parse(Console.ReadLine());
                    if (ValidateTurnOverAndPurchasePrice(turnover, purchasePrice) == true)
                    {
                        Console.WriteLine("Enter type of card golden,silver or bronze:");
                        string cardType = Console.ReadLine();
                        card = ChooseCardType(cardType);
                        if (card != null)
                        {
                            InitializeDiscountCard(card, owner, turnover);
                            CalculateDiscountAndNewPrice(card, purchasePrice);
                        }
                        else
                        {
                            Console.WriteLine("Cant get a discount without card");
                            Console.WriteLine($"Total:${purchasePrice}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Cant continue with invalid owner data");
            }
        }
        static void CalculateDiscountAndNewPrice(DiscountCard card,double purchasePrice)
        {
            double discount;
            discount = purchasePrice - (purchasePrice - ((purchasePrice * card.DiscountRate) / 100));
            Console.WriteLine($"Purchase value:{Math.Round(purchasePrice,2)}");
            Console.WriteLine($"Discount rate:{Math.Round(card.DiscountRate,2)}%");
            Console.WriteLine($"Discount:${Math.Round(discount,2)}");
            purchasePrice -= discount;
            Console.WriteLine($"Total:${Math.Round(purchasePrice,2)}");

        }
        static void InitializeDiscountCard(DiscountCard card,Owner owner,double turnover)
        {
            card.Owner = owner;
            card.Turnover = turnover;
            card.CalculateDiscountRate();
        }
        static void Main()
        {
            Owner owner = CreateOwner();
            DiscountCard card = null;
            Purchase(card, owner);
        }
    }
}
