// Метод для вывода массива в виде таблицы
void OutputArray(int[,] SrcArray)
{
    for (int i = 0; i < SrcArray.GetLength(0); i++)
    {
        for (int j = 0; j < SrcArray.GetLength(1); j++)
        {
            Console.Write(SrcArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите длину строки: ");
int Line = int.Parse(Console.ReadLine());

Console.Write("Введите длину столбца: ");
int Column = int.Parse(Console.ReadLine());

Random rand = new Random();

int[,] MegaArray = new int[Line, Column];

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        MegaArray[i, j] = rand.Next(0, 100);
    }
}

// Выводим массив в виде таблицы
Console.WriteLine("\nИсходный массив: ");
OutputArray(MegaArray);

int min = MegaArray.Cast<int>().Min();
int max = MegaArray.Cast<int>().Max();

Console.WriteLine($"\nМинимальное: {min}");
Console.WriteLine($"Максимальное: {max} \n");

int L = 0;
int C = 0;
int L1 = 0;
int C1 = 0;

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        if (MegaArray[i, j] == min)
        {
            L = i;
            C = j;
        }
        else if (MegaArray[i, j] == max)
        {
            L1 = i;
            C1 = j;
        }

    }
}
int tempVar = 0;
tempVar = MegaArray[L, C];
MegaArray[L, C] = MegaArray[L1, C1];
MegaArray[L1, C1] = tempVar;

Console.WriteLine("Замененный массив: ");
OutputArray(MegaArray);