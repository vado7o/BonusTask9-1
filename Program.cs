// Задача со звёздочкой1: Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями 
// и сдвинуть элементы массива влево, или вправо на 1 позицию.

Console.Clear();
Console.WriteLine("Программа, сдвигающая элементы массива влево или вправо на 1 позицию.");

int size = 0;
string str = "";

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов массива!\n");
}

while (true)
{
    Console.Write("\nНапишите куда нужно двигать массив - влево или вправо? : ");
    string input = Console.ReadLine();
    if (input == "влево") {
        str = "влево";
        break;
    } 
    else if (input == "вправо") {
        str = "вправо";
        break;
    } 
    else Console.WriteLine("Некорректно указано куда необходимо давигать массив!\n");
}

int[] array = FillArray(size, 0, 10);

Console.Write("\nCгенерированный массив - ");
PrintArray(array);

if(str == "влево") {
    Console.WriteLine("\nСдвинутый влево массив: ");
    moveArrayLeft(array);
}
else {
    Console.WriteLine("\nСдвинутый вправо массив: ");
    moveArrayRight(array);
}
PrintArray(array);

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

int[] moveArrayLeft(int[] array)
{
    int memory = array[0];
    for(int index = 0; index < size - 1; index++)
    {
        array[index] = array[index + 1];
    }
    array[size - 1] = memory;
    return array;
}

int[] moveArrayRight(int[] array)
{
    int memory = array[size - 1];
    for(int index = size - 1; index >= 1; index--)
    {
        array[index] = array[index - 1];
    }
    array[0] = memory;
    return array;
}