using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            var buyer1 = new Buyer { Name = "Farid", Money = 9999 };
            var buyer2 = new Buyer { Name = "Cavid", Money = 8888 };

            shop.NewItemInShop(new Product { Title = "IPhone", Price = 1999 });

            shop.Subscribe(buyer1);
            shop.Subscribe(buyer2);

            shop.NewItemInShop(new Product { Title = "Samsung", Price = 1599 });
        }
    }

    interface ISubscriber
    {
        void Update(Shop shop, Product newProduct);
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
