namespace Zadanie5;

public class Problem : Exception    //конструктор  //объявление класса Problem, который наследуется от класса Exception
{
    public Problem() : base("Время не может равняться 0")
    {
    }
}