﻿namespace Observer_Pattern
{
    class Buyer : ISubscriber
    {
        public string Name { get; set; }
        public decimal Money { get; set; }

        public void Update(Shop shop, Product newProduct)
        {
            if (newProduct.Title == "Samsung")
            {
                shop.SellProduct(newProduct);
                Money -= newProduct.Price;
            }
        }
    }














    //interface IPhoneBuyer
    //{
    //    void Buy(Shop shop);
    //}

    //class Customer : IPhoneBuyer
    //{
    //    public string Name { get; set; }
    //    public int Money { get; set; }

    //    public void Buy(Shop shop)
    //    {
    //        if (this.Money >= shop.NewPhone.Price)
    //        {
    //            this.Money -= shop.NewPhone.Price;
    //            shop.Money += shop.NewPhone.Price;
    //            Console.WriteLine($"{Name} bought {shop.NewPhone.Name}");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{Name} can't buy {shop.NewPhone.Name} :(");
    //        }
    //    }
    //}

    //class Phone
    //{
    //    public string Name { get; set; }
    //    public int Price { get; set; }
    //}

    //class Shop
    //{
    //    public Phone NewPhone { get; set; } = null;
    //    public int Money { get; set; } = 100000;
    //    public List<IPhoneBuyer> Buyers { get; set; } = new List<IPhoneBuyer>();

    //    public void AddSubscription(IPhoneBuyer buyer)
    //    {
    //        Buyers.Add(buyer);
    //    }

    //    public void RemoveBuyer(IPhoneBuyer buyer)
    //    {
    //        Buyers.Remove(buyer);
    //    }

    //    public void OnNewPhoneArrived(Phone phone)
    //    {
    //        NewPhone = phone;
    //        foreach (var item in Buyers)
    //        {
    //            item.Buy(this);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var shop = new Shop();

    //        var customer1 = new Customer { Name = "Gleb", Money = 50000 };
    //        var customer2 = new Customer { Name = "Alex", Money = 500 };
    //        var customer3 = new Customer { Name = "Ivan", Money = 3000 };

    //        shop.AddSubscription(customer1);
    //        shop.AddSubscription(customer2);
    //        shop.AddSubscription(customer3);

    //        shop.OnNewPhoneArrived(new Phone { Name = "IPhone X", Price = 1000 });
    //    }
    //}
}
