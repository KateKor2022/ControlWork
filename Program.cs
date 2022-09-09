string[] InputArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент из {size}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

Console.WriteLine("Пожалуйста, введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите максимальное количество символов элемента для отбора: ");
int max = Convert.ToInt32(Console.ReadLine());

string[] array = InputArray(size);
Console.WriteLine();