﻿//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
//нечётных индексах.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



int[] arr = { 3, 7, 23, 12 };
 int sum = 0;
for (int i = 1; i < arr.Length; i += 1)
 {
   if(i%2!=0)  sum += arr[i];
 }             
Console.WriteLine($"сумма =" + sum);
