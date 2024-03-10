namespace Pr_3.Modules
{
    internal class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Content: " + content);
            Console.ResetColor();
        }
    }
}
