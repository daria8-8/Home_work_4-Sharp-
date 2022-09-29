
int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] Fill1DArr(int len, int lowBord, int highBord)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(lowBord, highBord+1);
    }
    return array;
}

void Print1DArray(int[] arr)
{
    System.Console.Write("[");
    for ( int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write(arr[i] + ", ");

    }
    System.Console.WriteLine(arr[arr.Length - 1] + "]");
}

int arrLen = ReadData(" Введите длину массива: ");
int lowBord = ReadData(" Введите min значение элемента массива: ");
int highBord = ReadData(" Введите max значение элемента массива: ");
int [] arr = Fill1DArr(arrLen, lowBord, highBord);
Print1DArray(arr);

