/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int[,] arr = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 }
};

var str = arr.GetLength(0);
var sto = arr.GetLength(1);
double a = 0;
double b = 0;
double c = 0;
double d = 0;

for (int i = 0; i < str; i++)
{
	a += arr[i, 0];
	b += arr[i, 1];
	c += arr[i, 2];
	d += arr[i, 3];
}

double sum1 = a / 3;
double sum2 = b / 3;
double sum3 = c / 3;
double sum4 = d / 3;

Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
	for (int j = 0; j < arr.GetLength(1); j++)
		Console.Write(String.Format("{0,4:0.#}", arr[i, j]));
	Console.WriteLine();
}
Console.WriteLine($"Среднее арифметическое каждого столбца:{Math.Round(sum1, 1)}, {Math.Round(sum2, 1)}, {Math.Round(sum3, 1)}, {Math.Round(sum4, 1)}");