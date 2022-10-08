// See https://aka.ms/new-console-template for more information
using ConversorRomanos;

int number = 264;
string numberConverted = string.Empty;
Converter.ConvertNumber(number, ref numberConverted);
Console.WriteLine($"number:{numberConverted}");