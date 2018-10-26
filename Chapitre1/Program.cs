using Chapitre1.Models;
using System;

namespace Chapitre1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListAll();
            Console.ReadLine();
        }

        public static void ListAll()
        {
            using (var db = new AppDbContext())
            {
                foreach(var book in db.Books.As)
                {
                    var webUrl = book.Author.WebUrl == null ? "- no web URL given" : book.Author.WebUrl;
                    Console.WriteLine($"{book.Title} by {book.Author.Name}");
                    Console.WriteLine("Published on " + $"{book.PublishedOn:dd-MM-yyyy}" + $".{webUrl}");
                }
            }
        }
    }
}
