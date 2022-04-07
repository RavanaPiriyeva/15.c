using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "aaaa";
            book.AuthorName = "Revane";
            book.PageCount = 1;
            Book book1 = new Book();
            book1.Name = "bbbb";
            book1.AuthorName = "Ayten";
            book1.PageCount = 2;
            Book book2 = new Book();
            book2.Name = "cccc";
            book2.AuthorName = "Arzu";
            book2.PageCount = 3;

            Library library = new Library();
            library.Books.Add(book);
            library.Books.Add(book1);
            library.Books.Add(book2);
            Console.WriteLine("========================== BOOKS ===========================");
            foreach (var item in library.Books)
            {
                Console.WriteLine($" No: {item.No} | Name: {item.Name}");
            }

            Console.WriteLine("========================== BOOKS ===========================");
            foreach (var item in library.FindAllBooksByName("aaaa"))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("========================== BOOKS ===========================");
            foreach (var item in library.RemoveAllBookByName("aaaa"))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("========================== BOOKS ===========================");
            foreach (var item in library.SearchBooks("Arzu"))
            {
                Console.WriteLine(item.Name);
            }
        
    }
    }
}
