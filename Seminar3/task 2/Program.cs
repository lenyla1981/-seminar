﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


    Console.WriteLine("Введите координату по оси x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату по оси Y");
    int y = Convert.ToInt32(Console.ReadLine());

    if (quater == 1)
    {
        Console.WriteLine("x>0, y>0");
    }
    else if (quater == 2)
    {
        Console.WriteLine("x<0, y>0");
    }
    else if (quater == 3)
    {
        Console.WriteLine("x,o, y,0");
                        
    }
    else if (quater == 4)
    {
        Console.WriteLine("x>0, y<0");
    }
    else 
    {
    Console.WriteLine("Непонятно");
    }

