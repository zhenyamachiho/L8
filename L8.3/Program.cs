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

void matrixProd(int[,] matrixFirst, int[,] matrixSecond, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixSecond.GetLength(1); k++)
            {
                sum += matrixFirst[i, k] * matrixSecond[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrixFirst = InitMatrix(m, n);
int[,] matrixSecond = InitMatrix(m, n);
int[,] matrixResult = new int[m, n];

matrixProd(matrixFirst, matrixSecond, matrixResult);

PrintArray(matrixFirst);
PrintArray(matrixSecond);
PrintArray(matrixResult);
