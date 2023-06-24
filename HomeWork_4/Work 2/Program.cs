//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int Sum(int number)
{
			
    int colvo = 0;
    while (number > 0)
    {
        colvo += number % 10;
        number = number /10;
    }
    return colvo;
}
int number = ReadInt();
int summa = Sum(number);
Console.WriteLine($"Сумма всух чисел в цифре {number} = {Sum(number)}");