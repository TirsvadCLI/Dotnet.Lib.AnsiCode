[![NuGet Downloads][nuget-shield]][nuget-url][![Contributors][contributors-shield]][contributors-url][![Forks][forks-shield]][forks-url][![Stargazers][stars-shield]][stars-url][![Issues][issues-shield]][issues-url][![License][license-shield]][license-url][![LinkedIn][linkedin-shield]][linkedin-url]

# ![logo][logo] Ansi Code
Ansi codes library for console applications.

[![Screenshot 1][screenshot1]][screenshot1-url]

## Table of Contents
- [About the Project](#about-the-project)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
    - [Install via NuGet Package Manager Console](#install-via-nuget-package-manager-console)
    - [Install via Visual Studio NuGet Package Manager](#install-via-visual-studio-nuget-package-manager)
    - [Install via .NET CLI](#install-via-dotnet-cli)
    - [Clone the repo](#clone-the-repo)
- [Example](#example)
- [Contributing](#contributing)
- [Bug / Issue Reporting](#bug--issue-reporting)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)

## Overview
The AnsiCode library is a .NET library that provides a simple and efficient way to work with ANSI escape codes in console applications.
It allows developers to easily format text, change colors, and create visually appealing command-line interfaces.

## Features
- **Text Formatting**: Apply various text formatting options such as bold, underline, and italics.
- **Color Support**: Change text and background colors using ANSI escape codes. 

## Getting Started
To get started with the AnsiCode library, follow the instructions below to install it in your .NET project.

### Prerequisites
- .NET 10.0 or later

### Installation

#### Install via NuGet Package Manager Console
You can install the AnsiCode library using the NuGet Package Manager Console. Open the console and run the following command:
```bash
Install-Package TirsvadCLI.AnsiCode
```

#### Install via Visual Studio NuGet Package Manager
1. Open your project in Visual Studio.
2. Right-click on your project in the Solution Explorer and select "Manage NuGet Packages".
3. Search for "TirsvadCLI.AnsiCode" in the NuGet Package Manager.
4. Click "Install" to add the library to your project. 

#### Install via .NET CLI
You can also install the AnsiCode library using the .NET CLI. Open a terminal and run the following command:
```bash
dotnet add package TirsvadCLI.AnsiCode
```

#### Clone the repo
![Repo size][repos-size-shield]

If you want to clone the repository and build the library from source, you can do so using Git. Make sure you have Git installed on your machine. Then, run the following command in your terminal:

```bash
git clone git@github.com:TirsvadCLI/Dotnet.Lib.AnsiCode.git
```

## Example
In the [example][example-url] you can see how to use the AnsiCode class.

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Bug / Issue Reporting  
If you encounter a bug or have an issue to report, please follow these steps:  

1. **Go to the Issues Page**  
  Navigate to the [GitHub Issues page](https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/issues).  

2. **Click "New Issue"**  
  Click the green **"New Issue"** button to create a new issue.  

3. **Provide Details**  
  - **Title**: Write a concise and descriptive title for the issue.  
  - **Description**: Include the following details:  
    - Steps to reproduce the issue.  
    - Expected behavior.  
    - Actual behavior.  
    - Environment details (e.g., OS, .NET version, etc.).  
  - **Attachments**: Add screenshots, logs, or any other relevant files if applicable.  

4. **Submit the Issue**  
  Once all details are filled in, click **"Submit new issue"** to report it.  

## License
Distributed under the GPL-3.0 [License][license-url].

## Contact
Jens Tirsvad Nielsen - [LinkedIn][linkedin-url]

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badge
[contributors-url]: https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badge
[forks-url]: https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/network/members
[stars-shield]: https://img.shields.io/github/stars/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badge
[stars-url]: https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/stargazers
[issues-shield]: https://img.shields.io/github/issues/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badge
[issues-url]: https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/issues
[license-shield]: https://img.shields.io/github/license/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badge
[license-url]: https://github.com/TirsvadCLI/Dotnet.Lib.AnsiCode/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/
[githubIssue-url]: https://github.com/TirsvadCLI/Dotnet.AnsiCode/issues/
[repos-size-shield]: https://img.shields.io/github/repo-size/TirsvadCLI/Dotnet.Lib.AnsiCode?style=for-the-badg

[logo]: https://raw.githubusercontent.com/TirsvadCLI/Dotnet.Lib.AnsiCode/main/image/logo/32x32/logo.png

[nuget-shield]: https://img.shields.io/nuget/dt/TirsvadCLI.AnsiCode?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/TirsvadCLI.AnsiCode/

[screenshot1]: https://raw.githubusercontent.com/TirsvadCLI/Dotnet.Lib.AnsiCode/main/image/small/Screenshot1.png
[screenshot1-url]: https://raw.githubusercontent.com/TirsvadCLI/Dotnet.Lib.AnsiCode/main/image/Screenshot1.png

[example-url]: https://raw.githubusercontent.com/TirsvadCLI/Dotnet.Lib.AnsiCode/master/src/Example/Examples.cs
