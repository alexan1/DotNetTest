﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CartItem> itemList = getItemsList();

            //decimal salestaxes = 0.00m;
            //decimal totalprice = 0.00m;

            //foreach (ShoppingCartItem item in itemList)
            //{
            //    salestaxes += item.Taxes*item.Quantity;
            //    totalprice += item.Item.Price*item.Quantity;
            //    Console.WriteLine(string.Format("{0} {1} : {2}", item.Quantity, item.Item.Name, (item.Item.Price + item.Taxes)*item.Quantity));
            //}
            //totalprice += salestaxes;
            //Console.WriteLine("Sales Taxes : " + salestaxes);
            //Console.WriteLine("Total : " + totalprice);
            //Console.ReadLine();
        }

        private static List<CartItem> getItemsList()
        {
            List<CartItem> Items = new List<CartItem>();
            //input 1
            Items.Add(new CartItem { Item = new Book { Name = "War and Peace", Price = 12.49m, IsImport = false }, Quantity = 1 });
            Items.Add(new CartItem { Item = new Product { Name = "music CD", Price = 14.99m, IsImport = false }, Quantity = 1 });
            Items.Add(new CartItem { Item = new Food { Name = "chocolate bar", Price = 0.85m, IsImport = false }, Quantity = 1 });            
           
            return Items;
        }
    }
}
