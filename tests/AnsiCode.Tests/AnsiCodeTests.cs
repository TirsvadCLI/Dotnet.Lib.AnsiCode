// Copyright (c) 2026 TirsvadWeb. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using TirsvadCLI.AnsiCode;

using static TirsvadCLI.AnsiCode.AnsiConstants;

using AnsiCodeClass = TirsvadCLI.AnsiCode.AnsiCode;

namespace AnsiCode.Tests;

/// <summary>
/// Unit tests for AnsiCode class
/// </summary>
public class AnsiCodeTests
{
    [Fact]
    public void Colorize_WithFgAndBg_ReturnsCorrectAnsiString()
    {
        // Arrange
        string text = "Hello";
        string fgColor = "\u001b[31m"; // Red
        string bgColor = "\u001b[47m"; // White background
        string expected = $"{fgColor}{bgColor}{text}{ANSI_RESET}";

        // Act
        string result = AnsiCodeClass.Colorize(text, fgColor, bgColor);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Colorize_WithNullBgColor_UsesDefaultBlackBackground()
    {
        // Arrange
        string text = "World";
        string fgColor = "\u001b[32m"; // Green
        string expected = $"{fgColor}{AnsiConstants.BG_BLACK}{text}{AnsiConstants.ANSI_RESET}";

        // Act
        string result = AnsiCodeClass.Colorize(text, fgColor);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Test", "\u001b[34m", "\u001b[43m")]
    [InlineData("Sample", "\u001b[35m", "\u001b[40m")]
    public void Colorize_DataDriven_ReturnsExpectedFormat(string text, string fgColor, string bgColor)
    {
        // Arrange
        string expected = $"{fgColor}{bgColor}{text}{AnsiConstants.ANSI_RESET}";

        // Act
        string result = AnsiCodeClass.Colorize(text, fgColor, bgColor);

        // Assert
        Assert.Equal(expected, result);
    }
}
