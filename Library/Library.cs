using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library : ILibrary
    {
        public Library()
        {
            books = new List<Book>();
            books.Add(new Book { BookName = "Bilbo", Author = "Tolkin"  });
            books.Add(new Book { BookName = "Pinokio", Author = "NoName"  });
            books.Add(new Book { BookName = "Bykvar", Author = "nationale"  });
        }
        
        private List<Book> books { get; set; }

        public void Add(string bookName, string author)
        {
           books.Add(new Book { BookName = bookName, Author = author });
        }

        public bool CheckIfExist(string name, string author)
        {
            return books.Any(x => x.Author.ToUpper() == author.ToUpper() && x.BookName.ToUpper() == name.ToUpper());
        }

        public List<Book> FindByAuthor(string author)
        {
            return books.FindAll(x => x.Author == author);
        }

        public List<Book> FindByName(string name)
        {
            return books.FindAll(x => x.BookName == name);

        }

        public void Remove(string bookName, string author)
        {
            Book foundBook = books.Find(x => x.Author == author && x.BookName == bookName);

            books.Remove(foundBook);
        }

        public List<Book> ShowAll()
        {
            return books;
        }
    }
}
