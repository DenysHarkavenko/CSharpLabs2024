using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_3.Modules
{
    internal class Author
    {
        private string authorName;

        public Author(string name)
        {
            this.authorName = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Author: " + authorName);
            Console.ResetColor();
        }
    }
}
