// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] ElementsSizes(string[] array)
{
    int[] ArrayOfSizes = new int[array.Length];
    for (int i = 0; i < array.Length; ++i)
    {
        ArrayOfSizes[i] = array[i].Length;
    }
    return ArrayOfSizes;
}

string[] NewArray(int[] ArrayOfSizes, string[] array)
{
    int count = 0;
    for (int i = 0; i < ArrayOfSizes.Length; ++i)
    {
        if (ArrayOfSizes[i] <= 3)
            ++count;
    }

    string[] result = new string[count];
    count = 0;

    for (int i = 0; i < ArrayOfSizes.Length; ++i)
        if (ArrayOfSizes[i] <= 3)
            result[count++] = array[i];

    return result;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Сформирован новый массив: ");
    for (int i = 0; i < array.Length; ++i)
    {
        Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Сколько элементов в вашем массиве?");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];
string[] result;

Console.WriteLine();

Console.WriteLine("Введите элементы массива");

for (int i = 0; i < n; ++i)
{
    Console.WriteLine($"Элемент {i}:");
    array[i] = Console.ReadLine();
}

Console.WriteLine();
result = NewArray(ElementsSizes(array), array);

PrintArray(result);