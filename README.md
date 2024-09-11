# ArabicToPersianConverter

A simple utility for converting Arabic script characters to Persian script characters. This tool is designed to facilitate text processing tasks by providing an easy way to normalize or translate Arabic text into its Persian script equivalents. Ideal for developers working with multilingual text data, this converter helps in maintaining consistency and readability when dealing with different script systems. Whether you are developing a localization application, text editor, or any software that requires script conversion, this utility simplifies the process, ensuring accurate and efficient text transformation.

## Keywords

- Arabic to Persian script conversion
- Text normalization
- Multilingual text processing
- .NET text utilities
- Script translation tool
- Arabic script normalization
- Persian script characters
- Localization tool
- Text processing utility

## Overview

This project provides a straightforward way to convert Arabic script characters to their Persian script equivalents. It can be useful for applications involving text processing where Arabic script needs to be normalized or converted into Persian script.

## Features

- Converts Arabic script characters to Persian script characters.
- Supports a wide range of Arabic characters.
- Easy to integrate into .NET applications.

## Installation

To use this utility, you need to add the `Normalizer` class to your project. 

### Via NuGet Package  

1. Search for `ArabicToPersianConverter` on NuGet and install it using the package manager console:

   ```bash
   Install-Package ArabicToPersianConverter
Certainly! Continuing from where you left off:

2. Add a reference to the package in your project.

### Manual Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/ArabicToPersianConverter.git
   ```

2. Add the `Normalizer.cs` file to your project.

## Usage

To use the `Normalizer` class for converting Arabic text to Persian, follow these steps:

1. **Add Namespace**

   Ensure you include the namespace where the `Normalizer` class is defined:

   ```csharp
   using YourNamespace;
   ```

2. **Convert Text**

   Use the `ConvertArabicToPersian` method to convert Arabic text:

   ```csharp
   string arabicText = "Some Arabic text here";
   string persianText = Normalizer.ConvertArabicToPersian(arabicText);
   Console.WriteLine(persianText);
   ```

## Examples

```csharp
string arabicText = "مرحبا";
string persianText = Normalizer.ConvertArabicToPersian(arabicText);
Console.WriteLine(persianText); // Outputs the Persian equivalent
```

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (e.g., `git commit -am 'Add new feature'`).
5. Push to the branch (e.g., `git push origin feature-branch`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or issues, please contact [jouya.m@gmail.com](mailto:jouya.m@gmail.com).

Thank you for using the ArabicToPersianConverter!

Feel free to customize any section to fit your needs better.

