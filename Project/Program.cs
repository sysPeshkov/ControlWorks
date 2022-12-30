using static Common.Class1;
Console.Clear();

Tests(1);
Tests(2);
Tests(3);

int arraySize = InputNumber("Введите размер массива");
//string[] array = FillStringArray(arraySize);
//Console.WriteLine("Ваш массив:");
//PrintStringArray(array);

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



bool test = IsLongMoreThanNumber("TestProverka", 3);
Console.WriteLine(test);
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



void Tests(int numberTest)
{
    if (numberTest == 1)
    {
        string[] array = new string[4] { "hello", "2", "world", ":-)" };
        string[,] expectedResult = new string[2, 4] { { "hello", "2", "world", ":-)" }, { "1", "0", "1", "0" } };
    }
    if (numberTest == 2)
    {
        string[] array = new string[4] { "1234", "1567", "-2", "computer since" };
        string[,] expectedResult = new string[2, 4] { { "1234", "1567", "-2", "computer since" }, { "1", "1", "0", "1" } };
    }
    if (numberTest == 3)
    {
        string[] array = new string[3] { "Russia", "Denmark", "Kazan" };
        string[,] expectedResult = new string[2, 3] { { "Russia", "Denmark", "Kazan" }, { "1", "1", "1" } };
    }
    if (numberTest != 1 && numberTest != 2 && numberTest != 3)
    {
        Console.WriteLine("Тесты не были запущены");
    }
}