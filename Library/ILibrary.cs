using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface ILibrary
    {
        void Add(string bookName, string author);
        void Remove(string bookName, string author);
        List<Book> ShowAll();
        List<Book> FindByName(string name);
        List<Book> FindByAuthor(string author);
        bool CheckIfExist(string name, string author);
    }
}
