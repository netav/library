using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            foreach (var item in library.ShowAll()) {
                Console.WriteLine("Book = {0} , Author = {1}",item.BookName, item.Author);
            }
            library.Add("цель", "голдрат єлиях");
            foreach (var item in library.ShowAll())
            {
                Console.WriteLine("Book = {0} , Author = {1}", item.BookName, item.Author);
            }
            List<Book> FindBook = library.FindByName("цель");
            foreach (var item in FindBook)
            {
                Console.WriteLine("Book = {0} , Author = {1}", item.BookName, item.Author);
            }
            Console.ReadLine();

        }
    }
}
