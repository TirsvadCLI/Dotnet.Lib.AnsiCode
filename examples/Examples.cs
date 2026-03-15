// Copyright (c) 2026 TirsvadWeb. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using TirsvadCLI.AnsiCode;

using static TirsvadCLI.AnsiCode.AnsiConstants;

namespace Example;

internal class Examples
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AnsiCode.Colorize("Hello, World!", BLUE));
        Console.WriteLine(AnsiCode.Colorize("Hello, World!", BRIGHT_YELLOW, BG_BRIGHT_BLUE));
        Console.WriteLine(AnsiCode.Colorize("Error message!", RED));
        Console.WriteLine(AnsiCode.Colorize("Error message!", BLACK, BG_RED));
    }
}
