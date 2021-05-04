using Json;
using System;
using System.Collections.Generic;
using Xml;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISaveLoadAdapter> Adapters = new List<ISaveLoadAdapter>();
           
            Adapters.Add(new JsonSaveLoadAdapter(new JsonSaveLoad()));
            Adapters.Add(new XMLSaveLoadAdapter(new XMLSaveLoad()));


            List<Product> products = new List<Product>();
            List<Contact> contacts = new List<Contact>();

            products.Add(new Product() { Name = "Phone", Price = 456 });
            products.Add(new Product() { Name = "Notebook", Price = 780 });
            products.Add(new Product() { Name = "Pen", Price = 1 });

            contacts.Add(new Contact() { Email = "f-abdullayev@mail.ru", FullName = "Abdullayev Farid", Phone = "051-999-99-02" });
            contacts.Add(new Contact() { Email = "cavidabdullayev93@mail.ru", FullName = "Abdullayev Cavid", Phone = "051-999-99-01" });
            contacts.Add(new Contact() { Email = "Oktay@gmail.ru", FullName = "Abdullayev Oktay", Phone = "051-999-99-00" });


            //zapis po 2 ekzemplyarom kajdiy (JSON,XML)
            foreach (var item in Adapters)
            {
                item.Save("product", products);
                item.Save("contact", contacts);
            }

            products.Clear();
            contacts.Clear();

            foreach (ISaveLoadAdapter item in Adapters)
            {
                products = item.Load<Product>("product");
                contacts = item.Load<Contact>("contact");

                foreach (var item1 in products)
                {
                    Console.WriteLine(item1);
                }

                foreach (var item2 in contacts)
                {
                    Console.WriteLine(item2);
                }

                contacts.Clear();
                products.Clear();
            }
        }
    }
}
