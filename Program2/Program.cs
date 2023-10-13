namespace ListContact       //помещаем в пространство имён
{
    abstract class Program     //создаём абстрактный класс
    {
        static void Main(string[] args)    //начало программы
        {
            Contact zarina = new Contact("Измайлова", "Зарина", "Генадьевна", "89999999");    //создаём контакты
            Contact katerina = new Contact("Иванова", "Катерина", "Ивановна", "89999999");
            Contact irina = new Contact("Панова", "Ирина", "Александровна", "89999999");
            Contact marina = new Contact("Краймова", "Марина", "Андреевна", "89999999");
            Contact oktyabrina = new Contact("Сокол", "Октябрина", "Никитична", "89999999");

            Console.WriteLine("Выводим результаты работы методов для класса Contact");    // заголовок
            Console.WriteLine(zarina.ToString());      //выод результата работы метода ту стринг
            Console.WriteLine(zarina.GetFullName());
            Console.WriteLine(katerina.ToString());
            Console.WriteLine(katerina.GetFullName());
            Console.WriteLine(irina.ToString());
            Console.WriteLine(irina.GetFullName());
            Console.WriteLine(marina.ToString());
            Console.WriteLine(marina.GetFullName());
            Console.WriteLine(oktyabrina.ToString());
            Console.WriteLine(oktyabrina.GetFullName());
            ContactList list = new ContactList{         //создаём лист контактов и туда добляем людей
                 zarina, katerina, irina, marina, oktyabrina,
            };
            Console.WriteLine("Выводим все контакты");   //заголовок
            list.ContactPrint();   //вызываем метод для вызова всех контактов
            list.SortByFIO();      //сортируем лист по результатам работы метода гетфул нейм 
            Console.WriteLine("Выводим лист после сортировки");  //заголовок
            list.ContactPrint();     //выводим лист после сортировки
        }
    }
}