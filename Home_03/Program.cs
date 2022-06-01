void Print(double[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNum(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void MinMaxNum (double[] arr)
{
    double SumNum = 0;
    double MaxPosition = arr[0];
    double MinPosition = arr[0];
    for (int i = 0; i < arr.Length; i++) 
    {
       {
       if (arr[i]>MaxPosition) MaxPosition = arr[i];
       }

       for (int j = 0; j < arr.Length; j++)
       {
        if (arr[j]<MinPosition) MinPosition = arr[j];
       }
       
       SumNum = MaxPosition - MinPosition;
    }

    Console.WriteLine(SumNum);
}

double[] arr_1 = MassNum(12);
Print(arr_1);
MinMaxNum(arr_1);
