using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Content
    {

        private string nameofcontent = "";
        public string NameOfcontent
        { 
            set { nameofcontent = value; } 
            get { return nameofcontent; } 
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Змiст: {NameOfcontent}");
        }
    }
}