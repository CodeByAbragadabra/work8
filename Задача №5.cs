// Метод для вывода массива в виде таблицы
void OutputArray(int[,] SrcArray)
{
    for (int i = 0; i < SrcArray.GetLength(0); i++)
    {
        for (int j = 0; j < SrcArray.GetLength(1); j++)
        {
            Console.Write(SrcArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Получаем от пользователя длинну строки и столбца для массива 
Console.Write("Введите длину строки: ");
int Line = int.Parse(Console.ReadLine());

Console.Write("Введите длину столбца: ");
int Column = int.Parse(Console.ReadLine());

// Заполняем массив рандомными значениями
Random rand = new Random();

int[,] MegaArray = new int[Line, Column];

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        MegaArray[i, j] = rand.Next(0, 10);
    }
}

// Выводим массив в виде таблицы
Console.WriteLine("\nИсходный массив: ");
OutputArray(MegaArray);
Console.WriteLine("");

// Перебор массива и проверка того, чтобы координаты были четные, а элемент не четный. Также, чтобы не было нулей
for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        if (MegaArray[i, j] % 2 != 0)
        {
            if ((i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0))
            {
                Console.Write("Ответ: ");
                Console.WriteLine(MegaArray[i, j] + $". Координаты ({i}, {j})");
            }
        }
    }
}
