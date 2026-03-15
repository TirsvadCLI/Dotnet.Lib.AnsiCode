// Copyright (c) 2026 TirsvadWeb. All rights reserved. 
//  No warranty, explicit or implicit, provided.

namespace TirsvadCLI.AnsiCode;

/// <summary>
/// Provides ANSI escape code constants for terminal colors, formatting, and cursor control.
/// </summary>
/// <remarks>
/// Use these constants to format console output with colors, styles, and cursor movement.
/// </remarks>
/// <example>
/// <code language="csharp">
/// Console.Write(AnsiConstants.RED + "Error message" + AnsiConstants.ANSI_RESET);
/// </code>
/// </example>
public static class AnsiConstants
{
    #region Color Codes
    /// <summary>Gets the ANSI code for black text.</summary>
    public static readonly string BLACK = "\u001b[30m";
    /// <summary>Gets the ANSI code for red text.</summary>
    public static readonly string RED = "\u001b[31m";
    /// <summary>Gets the ANSI code for green text.</summary>
    public static readonly string GREEN = "\u001b[32m";
    /// <summary>Gets the ANSI code for yellow text.</summary>
    public static readonly string YELLOW = "\u001b[33m";
    /// <summary>Gets the ANSI code for blue text.</summary>
    public static readonly string BLUE = "\u001b[34m";
    /// <summary>Gets the ANSI code for magenta text.</summary>
    public static readonly string MAGENTA = "\u001b[35m";
    /// <summary>Gets the ANSI code for cyan text.</summary>
    public static readonly string CYAN = "\u001b[36m";
    /// <summary>Gets the ANSI code for white text.</summary>
    public static readonly string WHITE = "\u001b[37m";
    #endregion

    #region Bright Color Codes
    /// <summary>
    /// Gets the ANSI code for bright black text.
    /// </summary>
    public static readonly string BRIGHT_BLACK = "\u001b[90m";
    /// <summary>
    /// Gets the ANSI code for bright red text.
    /// </summary>
    public static readonly string BRIGHT_RED = "\u001b[91m";
    /// <summary>
    /// Gets the ANSI code for bright green text.
    /// </summary>
    public static readonly string BRIGHT_GREEN = "\u001b[92m";
    /// <summary>
    /// Gets the ANSI code for bright yellow text.
    /// </summary>
    public static readonly string BRIGHT_YELLOW = "\u001b[93m";
    /// <summary>
    /// Gets the ANSI code for bright blue text.
    /// </summary>
    public static readonly string BRIGHT_BLUE = "\u001b[94m";
    /// <summary>
    /// Gets the ANSI code for bright magenta text.
    /// </summary>
    public static readonly string BRIGHT_MAGENTA = "\u001b[95m";
    /// <summary>
    /// Gets the ANSI code for bright cyan text.
    /// </summary>
    public static readonly string BRIGHT_CYAN = "\u001b[96m";
    /// <summary>
    /// Gets the ANSI code for bright white text.
    /// </summary>
    public static readonly string BRIGHT_WHITE = "\u001b[97m";
    #endregion

    #region Background Color Codes
    /// <summary>
    /// Gets the ANSI code for black background.
    /// </summary>
    public static readonly string BG_BLACK = "\u001b[40m";
    /// <summary>
    /// Gets the ANSI code for red background.
    /// </summary>
    public static readonly string BG_RED = "\u001b[41m";
    /// <summary>
    /// Gets the ANSI code for green background.
    /// </summary>
    public static readonly string BG_GREEN = "\u001b[42m";
    /// <summary>
    /// Gets the ANSI code for yellow background.
    /// </summary>
    public static readonly string BG_YELLOW = "\u001b[43m";
    /// <summary>
    /// Gets the ANSI code for blue background.
    /// </summary>
    public static readonly string BG_BLUE = "\u001b[44m";
    /// <summary>
    /// Gets the ANSI code for magenta background.
    /// </summary>
    public static readonly string BG_MAGENTA = "\u001b[45m";
    /// <summary>
    /// Gets the ANSI code for cyan background.
    /// </summary>
    public static readonly string BG_CYAN = "\u001b[46m";
    /// <summary>
    /// Gets the ANSI code for white background.
    /// </summary>
    public static readonly string BG_WHITE = "\u001b[47m";
    #endregion

    #region Bright Background Color Codes
    /// <summary>
    /// Gets the ANSI code for bright black background.
    /// </summary>
    public static readonly string BG_BRIGHT_BLACK = "\u001b[100m";
    /// <summary>
    /// Gets the ANSI code for bright red background.
    /// </summary>
    public static readonly string BG_BRIGHT_RED = "\u001b[101m";
    /// <summary>
    /// Gets the ANSI code for bright green background.
    /// </summary>
    public static readonly string BG_BRIGHT_GREEN = "\u001b[102m";
    /// <summary>
    /// Gets the ANSI code for bright yellow background.
    /// </summary>
    public static readonly string BG_BRIGHT_YELLOW = "\u001b[103m";
    /// <summary>
    /// Gets the ANSI code for bright blue background.
    /// </summary>
    public static readonly string BG_BRIGHT_BLUE = "\u001b[104m";
    /// <summary>
    /// Gets the ANSI code for bright magenta background.
    /// </summary>
    public static readonly string BG_BRIGHT_MAGENTA = "\u001b[105m";
    /// <summary>
    /// Gets the ANSI code for bright cyan background.
    /// </summary>
    public static readonly string BG_BRIGHT_CYAN = "\u001b[106m";
    /// <summary>
    /// Gets the ANSI code for bright white background.
    /// </summary>
    public static readonly string BG_BRIGHT_WHITE = "\u001b[107m";
    #endregion

    #region Text Formatting Codes
    /// <summary>
    /// Gets the ANSI code for bold text.
    /// </summary>
    public static readonly string BOLD = "\u001b[1m";
    /// <summary>
    /// Gets the ANSI code for underlined text.
    /// </summary>
    public static readonly string UNDERLINE = "\u001b[4m";
    /// <summary>
    /// Gets the ANSI code for reversed text.
    /// </summary>
    public static readonly string REVERSE = "\u001b[7m";
    #endregion

    #region Cursor and Screen Control Codes
    /// <summary>
    /// Gets the ANSI code to clear the screen.
    /// </summary>
    public static readonly string CLEAR = "\u001b[2J";
    /// <summary>
    /// Gets the ANSI code to clear the current line.
    /// </summary>
    public static readonly string CLEAR_LINE = "\u001b[2K";
    /// <summary>
    /// ets the ANSI code to clear to the end of the line.
    /// </summary>
    public static readonly string CLEAR_END_LINE = "\u001b[K";
    /// <summary>
    /// Gets the ANSI code to clear to the start of the line.
    /// </summary>
    public static readonly string CLEAR_START_LINE = "\u001b[1K";
    /// <summary>
    /// Gets the ANSI code to clear down from the cursor.
    /// </summary>
    public static readonly string CLEAR_DOWN = "\u001b[J";
    /// <summary>
    /// Gets the ANSI code to clear up from the cursor.
    /// </summary>
    public static readonly string CLEAR_UP = "\u001b[1J";

    /// <summary>
    /// Gets the ANSI code to move the cursor up by a specified number of lines.
    /// </summary>
    /// <remarks>
    /// Use <c>string.Format(CURSOR_UP, lines)</c> to specify the number of lines.
    /// </remarks>
    public static readonly string CURSOR_UP = "\u001b[{0}A";
    /// <summary>
    /// Gets the ANSI code to move the cursor down by a specified number of lines.
    /// </summary>
    /// <remarks>
    /// Use <c>string.Format(CURSOR_DOWN, lines)</c> to specify the number of lines.
    /// </remarks>
    public static readonly string CURSOR_DOWN = "\u001b[{0}B";
    /// <summary>
    /// Gets the ANSI code to move the cursor right by a specified number of columns.
    /// </summary>
    /// <remarks>
    /// Use <c>string.Format(CURSOR_RIGHT, columns)</c> to specify the number of columns.
    /// </remarks>
    public static readonly string CURSOR_RIGHT = "\u001b[{0}C";
    /// <summary>
    /// Gets the ANSI code to move the cursor left by a specified number of columns.
    /// </summary>
    /// <remarks>
    /// Use <c>string.Format(CURSOR_LEFT, columns)</c> to specify the number of columns.
    /// </remarks>
    public static readonly string CURSOR_LEFT = "\u001b[{0}D";

    /// <summary>
    /// Gets the ANSI code to move the cursor to a specified position.
    /// </summary>
    /// <remarks>
    /// Use <c>string.Format(CURSOR_POS, row, column)</c> to specify the position.
    /// </remarks>
    public static readonly string CURSOR_POS = "\u001b[{0};{1}H";

    /// <summary>
    /// Gets the ANSI code to reset all formatting.
    /// </summary>
    public static readonly string ANSI_RESET = "\u001b[0m";
    #endregion
}
