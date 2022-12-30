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
}
