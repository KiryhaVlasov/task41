﻿//Задача 43.Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
//пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 =
//9-> (-0, 5; 5,5)
Console.WriteLine("введите b1");
double b1= int.Parse(Console.ReadLine());
Console.WriteLine("введите k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите b2");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите k2");
double k2 = int.Parse(Console.ReadLine());
double x = (b2-b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"{x};{y}");