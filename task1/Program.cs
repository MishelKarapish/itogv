Console.Write("Enter an array of strings separated by a space: ");
string text = Console.ReadLine();
       
string[] data = text.Split(' ');

string[] CheckElemLenght(string[] arr)
{
    int count = 0;
    int newTextLenght = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3) newTextLenght++;
    }
    string[] newText = new string[newTextLenght];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newText[count] = arr[i];
            count++;
        }
        else continue;
    }
    return newText;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {        
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

string[] result = CheckElemLenght(data);
PrintArray(data);
Console.Write(" => ");
PrintArray(result);