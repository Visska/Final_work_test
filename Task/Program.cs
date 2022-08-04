Console.Clear();
Console.WriteLine("Имеющийся массив строк: ");
string[] arrayString = {"hello", "2", "world", ":-)"};
printArray(arrayString);
int resultArrayLegth = lengthNewArray(arrayString);
string[] resultArray = new string[resultArrayLegth];
resultArray = createArrayLengthThree(arrayString, resultArray);
Console.WriteLine("\nПолучившийся массив строк: ");
printArray(resultArray);


int lengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] createArrayLengthThree(string[] array, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[index] = array[i];
            index++;
        }
    }
    return array2;
}


void printArray(string[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
