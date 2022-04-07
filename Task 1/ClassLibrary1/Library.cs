using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class Library
    {
        List<Book> _books = new List<Book>();
        public List<Book> Books { get { return _books; } }


        public List<Book> FindAllBooksByName(string str)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.Contains(str))
                {
                    newBooks.Add(item);
                }
            }
            return newBooks;
        }

        public List<Book> RemoveAllBookByName(string str)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in _books)
            {
                if (!item.Name.Contains(str))
                {
                    newBooks.Add(item);
                }
            }
            return newBooks;
        }

        public List<Book> SearchBooks(string str)
        {
            List<Book> newBooks = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.Contains(str) || item.AuthorName.Contains(str) || Convert.ToString(item.PageCount).Contains(str))
                {
                    newBooks.Add(item);
                }
            }
            return newBooks;
        }
    }
}
