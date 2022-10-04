//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] array = new int[5];

void GetArray()
{
    int count = 1;
    int i = 0;
    while (array.Length > i)
    {
        Console.WriteLine($"Enter the {count} element for the array: ");
        int arrayElement = Convert.ToInt32(Console.ReadLine());
        array[i] = arrayElement;
        i++;
        count++;
    }
}
GetArray();

void PrintArray()
{
    int i = 0;
    while (array.Length > i)
    {
        Console.Write($"|{array[i]}|");
        i++;
    }
    return;
}
PrintArray();

void EvenCount()
{
    int count = 0;
    int i = 0;
    while (array.Length > i)
    {
        if (array[i] > 0) count++;
        i++;
    }
    Console.WriteLine();
    Console.WriteLine(count);
    return;
}

EvenCount();
