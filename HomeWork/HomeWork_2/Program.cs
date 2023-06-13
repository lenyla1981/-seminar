// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22




 Console.WriteLine("Введите три числа:");
 
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;


if (a > b) 
 {
    max = a;
 }
else
 {
      max = b;
 }
if (b > c)
 {
     max = b;
 }
else
 {
     max = c;
 }
if (c > a)
 {
     max = c;
 }
else
 {
     max = a;
 }
Console.Write("max=" +max);