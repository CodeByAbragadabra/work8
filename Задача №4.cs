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


// Заполнаяем массив рандомными значениями
Random rand = new Random();

int[,] MegaArray = new int[1, 10];


for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        MegaArray[i, j] = rand.Next(2, 6);
    }
}

// Выводим массив в виде таблицы
Console.WriteLine("Исходный массив: \n");
OutputArray(MegaArray);

int BadMark = 0, NotBadMark = 0, GoodMark = 0, ExellentMark = 0;

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        switch (MegaArray[i, j])
        {
            case 2:
                BadMark++;
                break;
            case 3:
                NotBadMark++;
                break;
            case 4:
                GoodMark++;
                break;
            case 5:
                ExellentMark++;
                break;
        }
    }
}

Console.WriteLine
    (
        $"\nОтличная оценка: {ExellentMark}шт, " +
        $"Хорошая оценка: {GoodMark}шт, " +
        $"Неплохая оценка: {NotBadMark}шт, " +
        $"Плохая оценка: {BadMark}шт"
    );
