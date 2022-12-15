// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// 1. создаем массив из вещественных чисел
// 2. находим максимальный 
// 3. находим минимальный 
// 4. находим разницу
// 5. выводим на экран 


double[] array = new double[] {3.3, 897.76, 22, 52, 8.67};
Console.WriteLine();
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}

double diff = max - min;
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) числами массива = {diff}");