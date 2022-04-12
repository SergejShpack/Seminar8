// 15. Сумма двух матриц одинаковых размерностей.

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

int[,] SumTwoArrays(int[,] arr1, int[,] arr2)
{
    int[,] sumArr = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < sumArr.GetLength(0); i++)
        for (int j = 0; j < sumArr.GetLength(1); j++)
            sumArr[i, j] = arr1[i, j] + arr2[i, j];
    return sumArr;
}

int n = 5, m = 7; // Размер матрицы
int minArrayElement = -10, maxArrayElement = 10;

int[,] array1 = new int[n, m];
int[,] array2 = new int[n, m];

FillArray(array1, minArrayElement, maxArrayElement);
FillArray(array2, minArrayElement, maxArrayElement);

Console.WriteLine("Данная матрица 1: ");
PrintArray(array1);
Console.WriteLine("Данная матрица 2: ");
PrintArray(array2);

Console.WriteLine("Сумма 2 матриц: ");
PrintArray(SumTwoArrays(array1, array2));