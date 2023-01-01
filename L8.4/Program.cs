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

int[,,] InitMatrix(int m, int n, int b)
{
    int[,,] matrix = new int[m, n, b];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = 0;
            while (k < matrix.GetLength(2))
            {
                int element = new Random().Next(10, 100);
                if (FindElement(matrix, element)) continue;
                matrix[i, j, k] = element;
                k++;
            }
        }
    }

    return matrix;
}

bool FindElement(int[,,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i, j, z]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArrayIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i, j, z]}({i}, {j}, {z}) ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = GetNumber("Введите m");
int n = GetNumber("Введите n");
int b = GetNumber("Введите b");
int[,,] matrix = InitMatrix(m, n, b);
PrintArray(matrix);
PrintArrayIndex(matrix);
