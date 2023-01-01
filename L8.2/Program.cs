int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
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

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetSunLine(int[,] matrix, int i)
{
    int sumLine = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = InitMatrix(m, n);

int minSumLine = 0;
int sumLine = GetSunLine(matrix, 0);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int tempSumLine = GetSunLine(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

PrintArray(matrix);

Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой {sumLine} элементов ");
