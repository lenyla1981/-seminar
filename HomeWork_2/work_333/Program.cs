// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

using System;

Console.WriteLine("Введите день недели от 1 до 7:");
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

if (numberInt ==1)
{
    Console.WriteLine("нет");
}
if (numberInt ==2)
{
    Console.WriteLine("нет");
}
     if (numberInt ==3)
{
    Console.WriteLine("нет");
}
if (numberInt ==4)
{
    Console.WriteLine("нет");
}
if (numberInt ==5)
{
    Console.WriteLine("нет");
}
if (numberInt ==6)
{
    Console.WriteLine("Да");
}
if (numberInt ==7)
{
        Console.WriteLine("Да");
}
if (numberInt > 8)
{
Console.WriteLine("Такого ещё не придумали"); 
}   