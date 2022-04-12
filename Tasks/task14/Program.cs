// 14. Транспонирование для квадратной матрицы, то есть переворот матрицы относительно главной диагонали

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

int[,] ArrayTransposition(int[,] arr)
{
    int[,] arrTrans = new int[arr.GetLength(1), arr.GetLength(0)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            arrTrans[j, i] = arr[i, j];
    }
    return arrTrans;
}

int n = 5, m = 7;  // Размер массива
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данная матрица: ");
PrintArray(array);

Console.WriteLine($"Перевернутая матрица:");
PrintArray(ArrayTransposition(array));