using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17 {
    internal class Book: Product{
        public string Genre;

        public Book(string name, double price, string genre): base(name, price) {
            Genre = genre;
        }
    }
}
