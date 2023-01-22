// Заполняем массив рандомными числами
Random rand = new Random();

int[,] MegaArray = new int[3, 4];

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        MegaArray[i, j] = rand.Next(0, 100);
    }
}

// Выводим массив в виде таблицы
Console.WriteLine("Исходный массив в виде таблицы: ");
for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        Console.Write(MegaArray[i, j] + "\t");
    }
    Console.WriteLine();
}

// Перебор массива и нахождение минимального числа в каждой строке

for(int i = 0; i < MegaArray.GetLength(0); i++)
{
    int min = MegaArray[0, i];
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        if (MegaArray[i, j] < min)
        {
            min = MegaArray[i, j];
        }
    }
    Console.WriteLine($"Минимальное число в каджой строке: {min}");
}
 
