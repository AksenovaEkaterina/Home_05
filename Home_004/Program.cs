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

void Quest(int[] arr)
{
    int size = arr.Length;
    
    int [] NewArr = new int [size/2];

    if (size % 2 == 1)
    {
        NewArr = new int[size / 2 + 1];
        NewArr[NewArr.Length - 1] = arr[size / 2];
    }

    for (int i = 0; i < size/2; i++)
    {
        
        NewArr[i] = arr[i] * arr[size-i-1];
         Console.Write($"{NewArr[i]} ");
    
    }
   
}

int[] arr_1 = MassNum(12);
Print(arr_1);
Quest(arr_1);


