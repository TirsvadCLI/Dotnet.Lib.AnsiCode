namespace TirsvadCLI
{
    public class AnsiCode
    {
        public readonly static string BLACK = "\u001b[30m";
        public readonly static string RED = "\u001b[31m";
        public readonly static string GREEN = "\u001b[32m";
        public readonly static string YELLOW = "\u001b[33m";
        public readonly static string BLUE = "\u001b[34m";
        public readonly static string MAGENTA = "\u001b[35m";
        public readonly static string CYAN = "\u001b[36m";
        public readonly static string WHITE = "\u001b[37m";

        public readonly static string BRIGHT_BLACK = "\u001b[90m";
        public readonly static string BRIGHT_RED = "\u001b[91m";
        public readonly static string BRIGHT_GREEN = "\u001b[92m";
        public readonly static string BRIGHT_YELLOW = "\u001b[93m";
        public readonly static string BRIGHT_BLUE = "\u001b[94m";
        public readonly static string BRIGHT_MAGENTA = "\u001b[95m";
        public readonly static string BRIGHT_CYAN = "\u001b[96m";
        public readonly static string BRIGHT_WHITE = "\u001b[97m";

        public readonly static string BG_BLACK = "\u001b[40m";
        public readonly static string BG_RED = "\u001b[41m";
        public readonly static string BG_GREEN = "\u001b[42m";
        public readonly static string BG_YELLOW = "\u001b[43m";
        public readonly static string BG_BLUE = "\u001b[44m";
        public readonly static string BG_MAGENTA = "\u001b[45m";
        public readonly static string BG_CYAN = "\u001b[46m";
        public readonly static string BG_WHITE = "\u001b[47m";

        public readonly static string BG_BRIGHT_BLACK = "\u001b[100m";
        public readonly static string BG_BRIGHT_RED = "\u001b[101m";
        public readonly static string BG_BRIGHT_GREEN = "\u001b[102m";
        public readonly static string BG_BRIGHT_YELLOW = "\u001b[103m";
        public readonly static string BG_BRIGHT_BLUE = "\u001b[104m";
        public readonly static string BG_BRIGHT_MAGENTA = "\u001b[105m";
        public readonly static string BG_BRIGHT_CYAN = "\u001b[106m";
        public readonly static string BG_BRIGHT_WHITE = "\u001b[107m";

        public readonly static string BOLD = "\u001b[1m";
        public readonly static string UNDERLINE = "\u001b[4m";
        public readonly static string REVERSE = "\u001b[7m";

        public readonly static string CLEAR = "\u001b[2J";
        public readonly static string CLEAR_LINE = "\u001b[2K";
        public readonly static string CLEAR_END_LINE = "\u001b[K";
        public readonly static string CLEAR_START_LINE = "\u001b[1K";
        public readonly static string CLEAR_DOWN = "\u001b[J";
        public readonly static string CLEAR_UP = "\u001b[1J";

        public readonly static string CURSOR_UP = "\u001b[{0}A";
        public readonly static string CURSOR_DOWN = "\u001b[{0}B";
        public readonly static string CURSOR_RIGHT = "\u001b[{0}C";
        public readonly static string CURSOR_LEFT = "\u001b[{0}D";

        public readonly static string CURSOR_POS = "\u001b[{0};{1}H";

        public readonly static string ANSI_RESET = "\u001b[0m";

        public static string ColorText(string text, string fgColor, string? bgColor = null)
        {
            if (bgColor == null)
            {
                bgColor = BG_BLACK;
            }
            return $"{fgColor}{bgColor}{text}{ANSI_RESET}";
        }
    }
}
