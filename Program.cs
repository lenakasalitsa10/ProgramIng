namespace Zadanie5;

class Program
{
    static void Main(string[] args)
    {
        int time = 0;       //задаём изначальное значение для переменной time
        Console.Write($"Требуется ввести ФИО спортсмена:  ");   //выведение сообщения о введении ФИО
        string namesportsman = Console.ReadLine();   //вводим в консоль ФИО
        Console.Write($"Требуется ввести время спортсмена:  ");   //выведение сообщения о введении времени
        var inputTime = Console.ReadLine();    //вводим в консоль значение времени
        try
        {
            if (string.Compare(inputTime, "0") == 0)   //проверка условия: сравнение введённого времени с 0
            {
                throw new Problem();    
            }
            else     //если условие не выполнено, конвертировать введенное время в целочисленное значение
            {
                time = Convert.ToInt32(inputTime);
            }
        }
        catch (Problem e)
        {
            Console.WriteLine(e.Message); //обработка исключения при 0
        }
        catch (FormatException e) 
        {
            Console.WriteLine($"Введён некорректный формат времени!  "); //Обработка исключения при невозможности преобразовать в число
        }
    }
}