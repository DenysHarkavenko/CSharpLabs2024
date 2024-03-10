using Pr_3.Modules;
using System;

namespace Pr_3
{

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Крута книга", "Дуже крутий автор", "Книга з самим крутим контентом !");

            myBook.ShowInfo();
        }
    }
}
