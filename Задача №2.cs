// Метод, для вывода массива в виде таблицы
void OutputArray(double[,] SrcArray)
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


// Заполняем массив рандомными значениями:
Random rand = new Random();

double[,] MegaArray = new double[10, 10];

for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    for (int j = 0; j < MegaArray.GetLength(1); j++)
    {
        MegaArray[i, j] = rand.Next(0, 10);
    }
}

// Выводим массив в виде таблицы
Console.WriteLine("Исходный массив: ");
OutputArray(MegaArray);

// Делаем сумма главной диагонали
double Sum = 0;
for (int i = 0; i < MegaArray.GetLength(0); i++)
{
    Sum += MegaArray[i, i];
}

// Если сумма больше 10, то прибавляем к каждому элементу 13.5 и выводим
if (Sum > 10)
{
    for (int i = 0; i < MegaArray.GetLength(0); i++)
    {
        for (int j = 0; j < MegaArray.GetLength(1); j++)
        {
            MegaArray[i, j] = MegaArray[i, j] + 13.5;
        }
    }

    Console.WriteLine($"\nСумма элементов главной диагонали = {Sum}. Преобразованный массив:");
    OutputArray(MegaArray);
}

// Если сумма меньше 10, то умножаем на 2 и вычитаем 1.5 у каждого элемента, и выводим
else if (Sum < 10)
{
    for (int i = 0; i < MegaArray.GetLength(0); i++)
    {
        for (int j = 0; j < MegaArray.GetLength(1); j++)
        {
            MegaArray[i, j] = MegaArray[i, j] * 2 - 1.5;
        }
    }

    Console.WriteLine($"Сумма элементов главной диагонали = {Sum}. Преобразованная матрица:");
    OutputArray(MegaArray);
}