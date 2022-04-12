// 10. Произведение элементов побочной диагонали матрицы

void FillArray(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(startEl, endEl + 1);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MultArrayMinorDiagonal(int[,] arr)
{
    int multMinorDiagonal = 1;
    int maxIndex = arr.GetLength(0) - 1;

    for (int i = maxIndex; i >= 0; i--)
    {
        multMinorDiagonal *= arr[i, maxIndex - i];
    }
    return multMinorDiagonal;
}

int n = 3, m = 3;   //Размер матрицы
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данная матрица: ");
PrintArray(array);

if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Произведение побочной диагонали матрицы: {MultArrayMinorDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");