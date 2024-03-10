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
