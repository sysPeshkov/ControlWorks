using static Common.Class1;
Console.Clear();

Tests(1);
Tests(2);
Tests(3);

int arraySize = InputNumber("Введите размер массива");
string[] array = FillStringArray(arraySize);
Console.WriteLine("Ваш массив:");
PrintStringArray(array);

bool IsLongMoreThanNumber(string text, int number){
bool result = false;
int length = text.Length;

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
    else
    {
        Console.WriteLine("Тесты не были запущены");
    }
}