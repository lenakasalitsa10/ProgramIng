namespace ListContact    //  
{
    public class ContactList : List<Contact>   //созаем наследник класса лист с объектами контак
    {
        public void SortByFIO()  //функция сортирующая по методу фио
        {
            this.Sort((el1, el2) => string.Compare(el1.GetFullName(), el2.GetFullName()));   
        }

        public void ContactPrint()  // метод печает в се элементы списка в консоль
        {
            foreach (var contact in this)
            {
                Console.WriteLine(contact);
            }
        }
    }
}