//-Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
//3, 5 -> 243 (3⁵)
//2, 4 -> 16



int Prompt (string message)
{
   System.Console.Write(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
int power (int x, int p)
{
  int power = 1;
  for (int i = 1; i <= p; i++)
  {
  power *=x;
  }
  return power;
} 
bool ValidateExponent (int p)
{
  if (p < 0)
  {
    System.Console.WriteLine("Показатель не должен быть меньше нуля");
    return false;
  }
  return true;
 }

int x = Prompt("Введите основание ");
int p = Prompt("Введите показатель ");
if (ValidateExponent (p))
{
System.Console.WriteLine($"Число {x} в степени {p} равно {power (x, p)}");
}

  