// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Массив чисел: [ ");

int[] array = new int[length];
int sum = 0; // сумма элементов на нечетных позициях
int sumEven = 0; // сумма ЧЕТНЫХ элементов на нечетных позициях
Random rnd = new Random(); 
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(10, 1000); // случайные числа 
    Console.Write($"{array[i]} ");  
}
Console.WriteLine("]");

for (int i = 1; i < length; i = i + 2)
{
    sum = sum + array[i];
    if(array[i] % 2 == 0) 
    {
        sumEven = sumEven + array[i];
    }
}  
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
Console.WriteLine($"Сумма четных элементов, стоящих на нечентных позициях: {sumEven}");
