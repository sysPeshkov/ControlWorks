namespace Common;
public class Class1
{
    public static int InputNumber(string name)
    {
        Console.WriteLine(name);
        string number = Console.ReadLine();
        bool isParsed = int.TryParse(number, out int result);

        if (!isParsed)
        {
            Console.WriteLine($"Вы ввели некорректное число, ожидается целое число, вы ввели {number}");
            return -1;
        }
        return result;
    }

    public static string InputString(string name)
    {
        Console.WriteLine(name);
        string element = Console.ReadLine();

        return element;
    }

    public static string[] FillStringArray(int arraySize)
    {
        string[] arrayResult = new string[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine($"Введите элемент с индексом {i}");
            arrayResult[i] = Console.ReadLine();
        }

        return arrayResult;
    }

    public static void Print2DStringArray(string[,] array)
    {
        int numberRows = array.GetLength(0);
        int numberColumns = array.GetLength(1);
        for (int i = 0; i < numberRows; i++)
        {
            for (int j = 0; j < numberColumns; j++)
            {
                Console.Write($"{array[i, j]}");
            }
            Console.WriteLine();
        }

    }
}
