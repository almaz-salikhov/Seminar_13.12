// Программа заполняет массив четными цифрами 
// случайно сгенерированного от 1 000 до 1000 000 целого числа

// получить случайное число 
// заполнение массива с проверкой на четность

// int[] FillArrayWithEven(int val, int arr) // Метод while 
// {
//     int i = 0; // иначе в цикле ш постоянно будет обнуляться 
//     while (val > 0)
//     {
//         int digit = val % 10;
//         if(digit % 2 == 0)
//         {
//             // YES
//             arr[i] = digit;
//             i++;
//         }
//         val = val / 10;
//     }
// }

// int GetLengthOfNumber(int val)
// {
//     int count = 0; // количество цифр
//     while(val > 0) // сначала определись с действием, потом услови 
//     {   
//         val = val / 10;
//         count++;
//     }
//     return count;
// }

int CountOfEven(int val) // метод подсчета четных цифр в числе
{
    int count = 0;
    while(val > 0)
    {
        int digit = val % 10;
        if(digit % 2 == 0)
        {
            count++;
        }
        val = val / 10;
    }
    return count; 
    // возвращает количество четных, чтобы использовать его как размер нужного массива
    // чтобы не получилось, что массив больше, чем количество четных цифр
}

int[] FillArrayWithEven(int val, int length) // создаем массив, вводя размер массива
{
    int[] arr = new int[length];
    int i = 0; 
    while (val > 0)
    {
        int digit = val % 10;
        if(digit % 2 == 0)
        {
            arr[i] = digit;
            Console.Write(arr[i] + " ");
        }
        val = val / 10;
    }
    return arr; // возвращает массив
}

int number = new Random().Next(1000, 1000000);
Console.WriteLine("Случайное число: " + number);
Console.WriteLine("Четных цифр в числе: " + CountOfEven(number));
if(CountOfEven(number) == 0)
{
    Console.WriteLine("Во введенном числе отсутствуют четные цифры");
}
else
{
    Console.Write("Четные цифры введенного числа: ");
    int[] array = FillArrayWithEven(number, CountOfEven(number));
}
