
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
void PrintArray(int[] array)
{
    int count = array.Length;

for(int i = 0; i < count; i++)
  {
    Console.Write($"{string.Join(", ", array[i])}");

  }

}

PrintArray(array);
