﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    System.Console.Write(Math.Pow((i), 3) + ",");

}

System.Console.Write(Math.Pow((N), 3) + ".");