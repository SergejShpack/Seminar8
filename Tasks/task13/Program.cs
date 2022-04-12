// 13. Поиска минимального из максимальных элементов матрицы, то есть найти максимальный элемент в каждой из строк матрицы и из них выбрать минимальный

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

int MinFromMaxRowArray(int[,] arr)
{
    int minMax = 0; 

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int maxRow = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
            if (arr[i, j] > maxRow) maxRow = arr[i, j];
        if (i == 0) minMax = maxRow;
        else
        {
            if (minMax > maxRow) minMax = maxRow;
        }
    }
    return minMax;
}

int n = 5, m = 5; // Размер массива
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данный массив: ");
PrintArray(array);


Console.WriteLine($"Минимальный из максимальных элементов: {MinFromMaxRowArray(array)}.");
