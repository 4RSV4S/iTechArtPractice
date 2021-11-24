using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    public class RootObject
    {
        public Shop[] Shops { get; set; }

        public void DispalyIfAvaliable()
        {
            int iosCount = 0;
            int androidCount = 0;
            for (int i = 0; i < Shops.Length; i++)
            {
                Console.WriteLine($"[Id] [Name]\n{Shops[i].Id} {Shops[i].Name}\n[Description]\n{Shops[i].Description}\n[Amount of phones in stock]");
                for (int j = 0; j < Shops[i].Phones.Length; j++)
                {
                    if (Shops[i].Phones[j].OperationSystemType == "IOS")
                    {
                        iosCount++;
                    }
                    else if(Shops[i].Phones[j].OperationSystemType == "Android")
                    {
                        androidCount++;
                    }
                }
                Console.WriteLine($"{iosCount} IOS based phones are avaliable");
                Console.WriteLine($"{androidCount} Android based phones are avaliable");
                iosCount = 0;
                androidCount = 0;
            }
        }

        public void WantToBuy()
        {
            Console.WriteLine("Which mobile phone do you want to buy?");
            string model;
            string shop;
            model = Console.ReadLine();
            List<Phone> purchase = new List<Phone>();
            bool isFound = false;
            for (int i = 0; i < Shops.Length; i++)
            {
                for (int j = 0; j < Shops[i].Phones.Length; j++)
                {
                    if(model == Shops[i].Phones[j].Model)
                    {
                        if(Shops[i].Phones[j].IsAvailable == true)
                        {
                            purchase.Add(Shops[i].Phones[j]);
                        }
                        else
                        {
                            Console.WriteLine("This mobile phone is out of stock");
                            WantToBuy();
                        }
                    } 
                }
            }
            if(purchase.Count == 0)
            {
                Console.WriteLine("This mobile phone is not found");
                WantToBuy();
            }
            if(purchase.Count > 0)
            {
                Console.WriteLine("Your request is satisfied.");
                Console.WriteLine($"{purchase[0].Model}\n{purchase[0].OperationSystemType}\n{purchase[0].MarketLaunchDate}\n{purchase[0].Price}");
                if (purchase.Count == 1)
                {
                    Console.WriteLine($"You can purchase it on {Shops[purchase[0].ShopId - 1].Name}\n{Shops[purchase[0].ShopId - 1].Description}");
                }
                else if(purchase.Count > 1)
                {
                    Console.WriteLine("You can purchase it in the following shops:");
                    for(int i = 0; i <= purchase.Count -1; i++)
                    {
                        Console.WriteLine($"{Shops[purchase[i].ShopId - 1].Name}\n{Shops[purchase[i].ShopId - 1].Description}");
                    }
                }
                Console.WriteLine($"In which store do you want to buy the mobile phone {purchase[0].Model}?");
                shop = Console.ReadLine();
                for (int i = 0; i <= purchase.Count - 1; i++)
                {
                    if (shop == Shops[purchase[i].ShopId - 1].Name)
                    {
                        Console.WriteLine($"Order for {purchase[i].Model} ({purchase[i].OperationSystemType}), price ${purchase[i].Price}, market launch date {purchase[i].MarketLaunchDate}, in shop {Shops[purchase[i].ShopId - 1].Name} has been successfully placed.");
                        isFound = true;
                    }
                }
                if(isFound == false)
                {
                    Console.WriteLine("This shop is not found");
                }
            }
        }
    }

    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Phone[] Phones { get; set; }
    }

    public class Phone
    {
        public string Model { get; set; }
        public string OperationSystemType { get; set; }
        public string MarketLaunchDate { get; set; }
        public string Price { get; set; }
        public bool IsAvailable { get; set; }
        public int ShopId { get; set; }
    }

}
