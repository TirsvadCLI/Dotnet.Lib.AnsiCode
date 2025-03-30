namespace TirsvadCLI.AnsiCode;


/// <summary>
/// ANSI escape codes for terminal colors and formatting
/// </summary>
public class AnsiCode
{
    public readonly static string BLACK = "\u001b[30m"; ///> Black text
    public readonly static string RED = "\u001b[31m"; ///> Red text
    public readonly static string GREEN = "\u001b[32m"; ///> Green text
    public readonly static string YELLOW = "\u001b[33m"; ///> Yellow text
    public readonly static string BLUE = "\u001b[34m"; ///> Blue text
    public readonly static string MAGENTA = "\u001b[35m"; ///> Magenta text
    public readonly static string CYAN = "\u001b[36m"; ///> Cyan text
    public readonly static string WHITE = "\u001b[37m"; ///> White text

    public readonly static string BRIGHT_BLACK = "\u001b[90m"; ///> Bright black text
    public readonly static string BRIGHT_RED = "\u001b[91m"; ///> Bright red text
    public readonly static string BRIGHT_GREEN = "\u001b[92m"; ///> Bright green text
    public readonly static string BRIGHT_YELLOW = "\u001b[93m"; ///> Bright yellow text
    public readonly static string BRIGHT_BLUE = "\u001b[94m"; ///> Bright blue text
    public readonly static string BRIGHT_MAGENTA = "\u001b[95m"; ///> Bright magenta text
    public readonly static string BRIGHT_CYAN = "\u001b[96m"; ///> Bright cyan text
    public readonly static string BRIGHT_WHITE = "\u001b[97m"; ///> Bright white text

    public readonly static string BG_BLACK = "\u001b[40m"; ///> Black background
    public readonly static string BG_RED = "\u001b[41m"; ///> Red background
    public readonly static string BG_GREEN = "\u001b[42m"; ///> Green background
    public readonly static string BG_YELLOW = "\u001b[43m"; ///> Yellow background 
    public readonly static string BG_BLUE = "\u001b[44m"; ///> Blue background
    public readonly static string BG_MAGENTA = "\u001b[45m"; ///> Magenta background
    public readonly static string BG_CYAN = "\u001b[46m"; ///> Cyan background
    public readonly static string BG_WHITE = "\u001b[47m"; ///> White background

    public readonly static string BG_BRIGHT_BLACK = "\u001b[100m"; ///> Bright black background
    public readonly static string BG_BRIGHT_RED = "\u001b[101m"; ///> Bright red background
    public readonly static string BG_BRIGHT_GREEN = "\u001b[102m"; ///> Bright green background
    public readonly static string BG_BRIGHT_YELLOW = "\u001b[103m"; ///> Bright yellow background
    public readonly static string BG_BRIGHT_BLUE = "\u001b[104m"; ///> Bright blue background
    public readonly static string BG_BRIGHT_MAGENTA = "\u001b[105m"; ///> Bright magenta background
    public readonly static string BG_BRIGHT_CYAN = "\u001b[106m"; ///> Bright cyan background
    public readonly static string BG_BRIGHT_WHITE = "\u001b[107m"; ///> Bright white background

    public readonly static string BOLD = "\u001b[1m"; ///> Bold text
    public readonly static string UNDERLINE = "\u001b[4m"; ///> Underlined text
    public readonly static string REVERSE = "\u001b[7m"; ///> Reversed text

    public readonly static string CLEAR = "\u001b[2J"; ///> Clear screen
    public readonly static string CLEAR_LINE = "\u001b[2K"; ///> Clear line
    public readonly static string CLEAR_END_LINE = "\u001b[K"; ///> Clear to end of line
    public readonly static string CLEAR_START_LINE = "\u001b[1K"; ///> Clear to start of line
    public readonly static string CLEAR_DOWN = "\u001b[J"; ///> Clear down 
    public readonly static string CLEAR_UP = "\u001b[1J"; ///> Clear up

    public readonly static string CURSOR_UP = "\u001b[{0}A"; ///> Move cursor up
    public readonly static string CURSOR_DOWN = "\u001b[{0}B"; ///> Move cursor down
    public readonly static string CURSOR_RIGHT = "\u001b[{0}C"; ///> Move cursor right
    public readonly static string CURSOR_LEFT = "\u001b[{0}D"; ///> Move cursor left

    public readonly static string CURSOR_POS = "\u001b[{0};{1}H"; ///> Move cursor to position

    public readonly static string ANSI_RESET = "\u001b[0m"; ///> Reset ANSI codes


    /// <summary>
    /// Colorize a string with the given foreground and background colors
    /// </summary>
    /// <param name="text">The text to colorize</param>
    /// <param name="fgColor">The foreground color</param>
    /// <param name="bgColor">Optional: The background color</param>
    public static string Colorize(string text, string fgColor, string? bgColor = null)
    {
        if (bgColor == null)
        {
            bgColor = BG_BLACK;
        }
        return $"{fgColor}{bgColor}{text}{ANSI_RESET}";
    }
}
