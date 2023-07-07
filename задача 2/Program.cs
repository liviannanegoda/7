//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
using System;
using static System.Console;
Clear();

Write("Введите индекс строки: ");
int rows = int.Parse(ReadLine());
Write("Введите индекс столбца: ");
int columns = int.Parse(ReadLine());

int[,] numbers = new int[6, 8];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1)) WriteLine(numbers[rows, columns]);
else WriteLine($"числа с индексами [{rows};{columns}] нет в данном массиве");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
    Console.WriteLine();
}

