void PrintArray(string[] arr)
{   
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {   
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("]");
}

string[] CreateArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input array element: ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}