// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, определяющее размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] FillArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите название {i+1} элемента массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int CountLessThenThree(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count += 1;
    }
    return count;
}

string[] NewArray(string[] arr, int num)
{
    string[] arr2 = new string[num];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arr2[j] = arr[i];
            j++;
        }
    }
    return arr2;
}

string[] firstarray = FillArray(size);
PrintArray(firstarray);
int count = CountLessThenThree(firstarray);
Console.WriteLine();
string[] newarr = NewArray(firstarray, count);
PrintArray(newarr);