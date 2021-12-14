using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupBy
{
    class Program
    {
        class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
        }

        static void Main(string[] args)
        {
            // Sort of Data with order .

            Book[] Books =
            {
                new Book() { Id = 6, Title = "C# in Depth", Author = "Mark James" },
                new Book() { Id = 7, Title = "Javascript in 0", Author = "john wick" },
                new Book() { Id = 4, Title = "Java", Author = "Xman 12-0a" },
                new Book() { Id = 7, Title = "C# in Depth", Author = "Mark James" },
                new Book() { Id = 7, Title = "C++", Author = "Z-03" },
                new Book() { Id = 8, Title = "Clojure", Author = "proman" },
                new Book() { Id = 7, Title = "Ruby", Author = "Rails" }
            };

            // In Query Syntax 

            var List = from item 
                       in Books 
                       group item by item.Author;

            foreach (var item in List)
            {
                Console.Write("Author: " + item.Key);
                Console.WriteLine("---------------------------------");

                foreach (var book in item)
                    Console.WriteLine("Id = {0}, Title = {1}, Author = {2} ", book.Id, book.Title, book.Author);
            }
        }
    }
}
