using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            Console.WriteLine("Введiть назву книги:");
            title.NameOftitle = Console.ReadLine();
            Content content = new Content();
            Console.WriteLine("Введiть iм'я автора:");
            content.NameOfcontent = Console.ReadLine();
            Author author = new Author();
            Console.WriteLine("Введiть змiст книги:");
            author.NameOfauthor = Console.ReadLine();
            title.Show();
            content.Show();
            author.Show();
        }
    }
}

