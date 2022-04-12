// 9. Сумма элементов побочной диагонали матрицы

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

int SumArrayMinorDiagonal(int[,] arr)
{
    int sumMinorDiagonal = 0;
    int maxIndex = arr.GetLength(0) - 1;
    for (int i = maxIndex; i >= 0; i--)
    {
        sumMinorDiagonal += arr[i, maxIndex - i];
    }
    return sumMinorDiagonal;
}

int n = 4, m = 4;   //Размер матрицы
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данная матрица: ");
PrintArray(array);

if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Сумма побочной диагонали матрицы: {SumArrayMinorDiagonal(array)}");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");