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



void GetSortingMatrix(int[,] matrix)
{
    //int[,] newMartix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1])
                {
                    int temp = matrix[i, z + 1];
                    matrix[i, z + 1] = matrix[i, z];
                    matrix[i, z] = temp;
                }
            }
        }
    }
}


int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");

int[,] matrix = InitMatrix(m, n);
PrintArray(matrix);

GetSortingMatrix(matrix);
PrintArray(matrix);
