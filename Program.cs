using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Classes__and_Objects
{
    internal class Program
    {
         internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
        }
    }
        static void Main(string[] args)
        {
            Book book1 = new Book();//creates a new book object, at this point Book is now a data type in C#

            //creation of first book, you can now create thousands of different books eg for a library app

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();//creates a new book object, at this point Book is now a data type in C#

            //creation of first book, you can now create thousands of different books eg for a library app

            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            //freeze
            Console.ReadLine();

        }
    }
}
