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

void modifiedArray(string[] arr)
 {  
    int count = 0;
    string[] arrMod = new string[arr.Length];
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
        arrMod[count] = arr[i];
        Console.Write(arrMod[count]+ ',');
        count++;
        }
    }
    Console.Write(" ]");
 }

Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
Console.WriteLine("Input array: ");
PrintArray(array);
Console.WriteLine("New array where (element <= 3): ");
modifiedArray(array);