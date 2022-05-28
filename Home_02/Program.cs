void Print(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNum(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}

void SumIndexNum(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i= i+2) sum = sum + arr[i];
    
    Console.WriteLine(sum);

}

int[] arr_1 = MassNum(12);
Print(arr_1);
SumIndexNum(arr_1);
