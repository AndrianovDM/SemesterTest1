void PrintArray(string[] arr)
{   
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {   
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("]");
}