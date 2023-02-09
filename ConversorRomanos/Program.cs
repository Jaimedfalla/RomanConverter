// See https://aka.ms/new-console-template for more information

using ConversorRomanos;

int number = 264;
string? numberConverted = RomanConverter.ConvertNumber(number);
Console.WriteLine($"number:{numberConverted}");