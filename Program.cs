﻿// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double [rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] =Math.Round(new Random().Next(-10, 11) * new Random().NextDouble(), 1);
//         Console.Write(array[i, j]+ " ");
//     }
//     Console.WriteLine();
// }



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int [rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] =new Random().Next(0, 10);
//         Console.Write(array[i, j]+ " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите номер элемента строки");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер элемента столбца");
// int b = Convert.ToInt32(Console.ReadLine());

// if ((a < rows) && (b < columns))
//      {
//         Console.WriteLine(array[a, b]);
//     }
//     else
//     {
//         Console.WriteLine("Такого числа в массиве нет");
//     }



// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] =new Random().Next(0, 10);
        Console.Write(array[i, j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("___________");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i,j];
    }
    Console.Write($"{sum / array.GetLength(0)} ");
}