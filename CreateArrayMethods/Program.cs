// Создание массива с использованием методов

// 1. Первый способ
int[] CreateArray (int length) // создаем массив, вводя размер массива
{
    int[] array = new int[length];
    Random rnd = new Random(); // вынесен отдельно, чтобы не выделять память под это
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next();
    }
    return array; // возвращает массив
}

int[] arr1 = CreateArray(5); // вызов метода


// 2. Второй способ
void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next();
    }
}

int[] arr2 = new int[5]; // создание массива размером 5 ячеек
FillArray(arr2); // вызов метода
