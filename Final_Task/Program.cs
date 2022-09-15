string[] CreateFirstArray(int length)
{
    string[] firstArray = new string[length];

    for (int i = 0; i < firstArray.Length; i++)
    {
        Console.WriteLine("Введите строку:");
        firstArray[i] = Console.ReadLine();
    }
    return firstArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] CreateSecondArray(string[] firstArray)
{
    int count = 0;
    string[] secondArray = new string[firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3) 
        secondArray[count] = firstArray[i];
        count++;
    }
    return secondArray;
}

string[] firstArray = CreateFirstArray(5);
PrintArray(firstArray);
string[] secondArray = CreateSecondArray(firstArray);
PrintArray(secondArray);