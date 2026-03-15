// Copyright (c) 2026 TirsvadWeb. All rights reserved. 
//  No warranty, explicit or implicit, provided.

namespace TirsvadCLI.AnsiCode;

/// <summary>
/// Provides ANSI escape codes for terminal colors and formatting.
/// </summary>
/// <remarks>
/// This class contains static methods for colorizing terminal output using ANSI escape codes.
/// </remarks>
/// <example>
/// <code language="csharp">
/// string colored = AnsiCode.Colorize("Hello", "\u001b[31m", "\u001b[47m");
/// </code>
/// </example>
public class AnsiCode
{
    /// <summary>
    /// Colorizes a string with the given foreground and background colors.
    /// </summary>
    /// <param name="text">A string to colorize.</param>
    /// <param name="fgColor">An ANSI escape code for the foreground color.</param>
    /// <param name="bgColor">An optional ANSI escape code for the background color. If <see langword="null"/>, uses <see cref="AnsiConstants.BG_BLACK"/>.</param>
    /// <returns>
    /// A string containing the ANSI escape codes for the specified colors, the text, and the reset code.
    /// </returns>
    /// <example>
    /// <code language="csharp">
    /// string result = AnsiCode.Colorize("World", "\u001b[32m");
    /// </code>
    /// </example>
    public static string Colorize(string text, string fgColor, string? bgColor = null)
    {
        bgColor ??= AnsiConstants.BG_BLACK;
        return $"{fgColor}{bgColor}{text}{AnsiConstants.ANSI_RESET}";
    }
}