
/*
int GetNumber(string message)
{
	int result = 0;

	while (true)
	{
		Console.WriteLine(message);

		if (int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else
		{
			Console.WriteLine("Ввели не число");
		}

	}
	return result;
}

int[,] InitMatrix(int rows, int colums)
{
	int[,] arrMatrix = new int[rows, colums];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < colums; j++)
			arrMatrix[i, j] = i + j;
	}
	return arrMatrix;
}
// Вывод на печать матрицы
void PrintMatrix(int[,] arrMatrix)
{
	for (int i = 0; i < arrMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < arrMatrix.GetLength(0); j++)
			Console.Write($"{arrMatrix[i, j]} ");
		Console.WriteLine();
	}
}
int rows = GetNumber("введите количество строк");
int colums = GetNumber("введите количество столбцов");
int[,] arrMatrix = InitMatrix(rows, colums);

PrintMatrix(arrMatrix);

*/

/*

int[,] array = {
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 }
};

var dim0 = array.GetLength(0);
var dim1 = array.GetLength(1);

for (int i = 0; i < dim0; i++)
	for (int j = 0; j < dim1; j++)
		if (((i+1) % 2) == 0) && ((j+1) % 2 == 0) arr[i, j] = array[i, j];


Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < dim0; i++)

Console.WriteLine(array);


*/


