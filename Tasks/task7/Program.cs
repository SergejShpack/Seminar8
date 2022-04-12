// 7. Максимальный элемент, расположенный на главной диагонали матрицы

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

int MaxElArrayMainDiagonal(int[,] arr)
{
    int maxElDiagonal = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i, i] > maxElDiagonal) maxElDiagonal = arr[i, i];
    }
    return maxElDiagonal;
}

int n = 5, m = 5;   //Размер матрицы
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данная матрица: ");
PrintArray(array);

if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Максимальный элемент диагонали: {MaxElArrayMainDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");