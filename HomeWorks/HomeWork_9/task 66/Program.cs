// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = 1;
int numberN = 15;
void Perechislenie(int LastNumber, int FirstNumber, int sum)
{
    if (LastNumber > FirstNumber ) 
    {
    Console.WriteLine(sum); 
    return;
    }
    sum = sum + (numberM++);
   Perechislenie(numberM, numberN, sum);
}

Perechislenie(numberM, numberN, 0); 
    

