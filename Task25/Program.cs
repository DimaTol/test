﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA < 0 || numB < 0)
    Console.Write("Введите положительное число");

else
{
    int Degree(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < numB; i++)
        {
            result = result * numA;
        }
        return result;

    }
    int degr = Degree(numA, numB);

    Console.WriteLine($"Число {numA} в степени {numB} -> {degr}");
}