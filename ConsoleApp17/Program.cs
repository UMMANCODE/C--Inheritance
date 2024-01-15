using System;

namespace ConsoleApp17 {
    internal class Program {
        static void Main(string[] args) {
            Library Library = new Library();
            string option;
            do {
                ShowMenu();
                Console.Write("\nPlease choose an option: ");
                option = Console.ReadLine();
                switch (option) {
                    case "1":
                        string name;
                        do {
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            name = name.Trim();
                            for (int i = 0; i < name.Length; i++) {
                                if (!char.IsLetter(name[i]) && !char.IsWhiteSpace(name[i])) {
                                    name = "";
                                    break;
                                }
                            }
                            string[] wordsInName = name.Split(" ");
                            string[] justUsefulWords = new string[0];
                            int j = 0;
                            for (int i = 0; i < wordsInName.Length; i++) {
                                if (!string.IsNullOrWhiteSpace(wordsInName[i])) {
                                    Array.Resize(ref justUsefulWords, justUsefulWords.Length + 1);
                                    justUsefulWords[j++] = wordsInName[i];
                                }
                            }
                            name = string.Join(" ", justUsefulWords);
                        } while (name.Length < 3 || name.Length > 20);

                        double price;
                        do {
                            Console.Write("Price: ");
                        } while (!double.TryParse(Console.ReadLine(), out price) || price < 0);
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();
                        Book book = new Book(name, price, genre);
                        Library.AddBook(book);
                        break;
                    case "2":
                        Console.Write("Name: ");
                        string nameToRemove = Console.ReadLine();
                        Library.RemoveBookByName(nameToRemove);
                        break;
                    case "3":
                        for (int i = 0; i < Library.Books.Length; i++) {
                            ShowBook(Library.Books[i]);
                        }
                        break;
                    case "4":
                        Console.Write("Name: ");
                        string nameToFind = Console.ReadLine();
                        Book bookToFind = Library.FindBookByName(nameToFind);
                        if (bookToFind != null) ShowBook(bookToFind);
                        else Console.WriteLine("Book not found");
                        break;
                    case "5":
                        Console.Write("String: ");
                        string str = Console.ReadLine();
                        Book[] books = Library.SearchBookByString(str);
                        if (books.Length > 0) {
                            for (int i = 0; i < books.Length; i++) {
                                ShowBook(books[i]);
                            }
                        } else Console.WriteLine("No books found");
                        break;
                    case "0":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (option != "0");
        }

        static void ShowMenu() {
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Remove book");
            Console.WriteLine("3. Show all books");
            Console.WriteLine("4. Find book");
            Console.WriteLine("5. Search book by string");
            Console.WriteLine("0. Exit");
        }

        static void ShowBook(Book book) {
            Console.WriteLine();
            Console.WriteLine($"Name: {book.Name}");
            Console.WriteLine($"Price: {book.Price}");
            Console.WriteLine($"Genre: {book.Genre}");
            Console.WriteLine();
        }
    }
}
