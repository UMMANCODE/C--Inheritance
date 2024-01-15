using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17 {
    internal class Library {
        public Book[] Books = new Book[0];
        
        public void AddBook(Book book) {
            for (int i = 0; i < Books.Length; i++) {
                if (Books[i].Name == book.Name) {
                    Console.WriteLine("This book is already in the library");
                    return;
                }
            }
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public void RemoveBookByName(string name) {
            for (int i = 0; i < Books.Length; i++) {
                if (Books[i].Name == name) {
                    for (int j = i; j < Books.Length - 1; j++) {
                        Books[j] = Books[j + 1];
                    }
                    Array.Resize(ref Books, Books.Length - 1);
                    return;
                }
            }
            Console.WriteLine("This book is not in the library");
            return;
        }

        public Book FindBookByName(string name) {
            for (int i = 0; i < Books.Length; i++)
                if (Books[i].Name == name) return Books[i];
            return null;
        }

        public Book[] SearchBookByString(string str) {
            Book[] books = new Book[0];
            for (int i = 0; i < Books.Length; i++) {
                if (Books[i].Name.Contains(str)) {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = Books[i];
                }
            }
            return books;
        }
    }
}
