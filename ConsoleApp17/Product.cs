using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17 {
    internal abstract class Product {
        public string Name;
        public double Price;

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
