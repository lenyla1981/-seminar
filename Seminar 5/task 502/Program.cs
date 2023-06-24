//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] GetRandomArray()
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    { 
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}
int[] array = GetRandomArray() ;
 
 Console.WriteLine("Начальный массив это");
Console.WriteLine(String.Join(", ", array));

  for (int i= 0; i < array.Length; i++)
  {
    array[i] = -array[i];
  }
  Console.WriteLine("Изменённый массив это");
Console.WriteLine(String.Join(", ", array));