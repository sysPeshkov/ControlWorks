using static Common.Class1;
Console.Clear();

Tests(1);
Tests(2);
Tests(3);

int arraySize = InputNumber("Введите размер массива");
string[] array = FillStringArray(arraySize);
Console.WriteLine("Ваш массив:");
PrintStringArray(array);
Console.WriteLine();
int amountSymbols = InputNumber("Относительно какого количества символов будем проверять:");
Console.WriteLine();
int isMore = InputNumber("Введите 0 или 1. 0 - вывести елементы с размером меньше или равно. 1 - больше");
if (isMore != 0 && isMore != 1)
{
    isMore = 0;
}
string[,] arrayWithMark = GetMoreOrLessElementsFromArray(array, amountSymbols);

//Первый вариант решения
PrintResultArray(arrayWithMark, isMore);

//Второй вариант решения
GetArrayWithParthElement(arrayWithMark, isMore);

void GetArrayWithParthElement(string[,] array, int isMore)
{
    Console.WriteLine("Второй вариант решения");
    int amountElement = 0;
    int k = 0;
    int length = array.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        if (int.Parse(array[1, i]) == isMore)
        {
            amountElement = amountElement + 1;
        }
    }
    string[] resultArray = new string[amountElement];

    for (int i = 0; i < length; i++)
    {

        if (int.Parse(array[1, i]) == isMore)
        {

            resultArray[k] = array[0, i];
            k = k+1;
        }

    }

    PrintStringArray(resultArray);

}




void PrintResultArray(string[,] array, int isMore)
{
    Console.WriteLine("Первый вариант решения");
    int amountColumns = array.GetLength(1);

    for (int i = 0; i < amountColumns; i++)
    {
        if (int.Parse(array[1, i]) == isMore)
        {
            Console.Write($"{array[0, i]} ");
        }
    }
    Console.WriteLine();
}


string[,] GetMoreOrLessElementsFromArray(string[] array, int amountSymbols)
{
    int isAmountLess = 0;
    int isAmountMore = 1;
    int amountColumns = array.Length;
    string[,] resultArray = new string[2, amountColumns];
    bool moreThanamountSymbols = false;
    for (int i = 0; i < amountColumns; i++)
    {
        resultArray[0, i] = array[i];
        moreThanamountSymbols = IsLongMoreThanNumber(array[i], amountSymbols);
        if (!moreThanamountSymbols)
        {
            resultArray[1, i] = isAmountLess.ToString();
        }
        else
        {
            resultArray[1, i] = isAmountMore.ToString();
        }
    }
    return resultArray;
}


//Функция "Длина текста строго больше чем заданное число?"
bool IsLongMoreThanNumber(string text, int number)
{
    bool result = false;
    //Длина входящего текста
    int length = text.Length;
    //Если длина текста больше чем заданное число,
    // то результат true
    if (length > number)
    {
        result = true;
    }
    return result;
}



void Tests(int numberTest = 1)
{
    string[] array = null;
    string[,] expectedResult = null;
    int isAmountMore = 3;
    int isContinue = 1;
    if (numberTest == 1)
    {
        array = new string[4] { "hello", "2", "world", ":-)" };
        expectedResult = new string[2, 4] { { "hello", "2", "world", ":-)" }, { "1", "0", "1", "0" } };
    }
    if (numberTest == 2)
    {
        array = new string[4] { "1234", "1567", "-2", "computer since" };
        expectedResult = new string[2, 4] { { "1234", "1567", "-2", "computer since" }, { "1", "1", "0", "1" } };
    }
    if (numberTest == 3)
    {
        array = new string[3] { "Russia", "Denmark", "Kazan" };
        expectedResult = new string[2, 3] { { "Russia", "Denmark", "Kazan" }, { "1", "1", "1" } };
    }
    if (numberTest != 1 && numberTest != 2 && numberTest != 3)
    {
        Console.WriteLine("Тесты не были запущены");
        isContinue = 0;
    }

    if (isContinue == 1)
    {
        string[,] resultArray = GetMoreOrLessElementsFromArray(array, isAmountMore);

        //Проверка
        int amountRows = resultArray.GetLength(0);
        int amountColumns = resultArray.GetLength(1);


        for (int i = 0; i < amountRows; i++)
        {
            for (int j = 0; j < amountColumns; j++)
            {
                if (resultArray[i, j] != expectedResult[i, j])
                {
                    Console.WriteLine($"Тест {numberTest} упал. Ожидается значение {expectedResult[i, j]}, фактический результат {resultArray[i, j]}");
                }
            }
        }
    }
}