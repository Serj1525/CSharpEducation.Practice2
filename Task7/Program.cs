using System.Globalization;
using System;

namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введи чё-нить - ");
        string sentence = Console.ReadLine();
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine(ti.ToTitleCase(sentence));
        
        Console.WriteLine("Введи заглавный символ - ");
        string symbol = Console.ReadLine();;
        symbol = symbol.ToUpper();
        Console.WriteLine(symbol);
        
        Console.WriteLine("И наоборот - ");
        symbol = Console.ReadLine();;
        symbol = symbol.ToLower();
        Console.WriteLine(symbol);
    }
}