using TirsvadCLI.AnsiCode;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AnsiCode.Colorize("Hello, World!", AnsiCode.BLUE));
            Console.WriteLine(AnsiCode.Colorize("Hello, World!", AnsiCode.BRIGHT_YELLOW, AnsiCode.BG_BRIGHT_BLUE));
            Console.WriteLine(AnsiCode.Colorize("Error message!", AnsiCode.RED));
            Console.WriteLine(AnsiCode.Colorize("Error message!", AnsiCode.BLACK, AnsiCode.BG_RED));
        }
    }
}
