

namespace ListContact     //помещаем класс в пространство имён
{

    public class Contact      //создаём класс контакт
    {
        public string Surname { get; set; }      //свойство класса фамилия
        public string Name { get; set; }          //свойство класса имя
        public string Middlename { get; set; }    //свойство класса отчество
        public string Number { get; set; }       //свойство класса номер

        public Contact(string surname, string name, string middlename, string number)     // конструктор класса
        {
            this.Surname = surname;
            this.Name = name;
            this.Middlename = middlename;
            this.Number = number;
        }


        public override string ToString()    //Метод ToString()
        {
            return $"{Name}: {Number}";      // возвращаем имя и номер в нужном формате
        }

        public string GetFullName()        //метод ФИО
        {
            return $"{Surname} {Name} {Middlename}";         //возвращаем ФИО 
        }
    }
}



//главный класс
//    public class Contact{  
//           public string Surname{get; set;}    //поле фамилия
//         public string Name{get; set;}   //поле имя
//         public string Middlename{get; set;}  //поле отчество
//         public string Number{get; set;}  //поле номер
//             public override  string ToString(){     //применили метод tostring
//                 return "Имя: " + Name +  " " + "Номер: " + " " + Number;   //вывод имени и номера
//              }
//     public string GetFullName(){

//     }
//    } // класс контакт

