﻿Напишем код


int[] arr = {1, 2, 3, 4}

void PtintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
{
minPosition = j;
}
}
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
