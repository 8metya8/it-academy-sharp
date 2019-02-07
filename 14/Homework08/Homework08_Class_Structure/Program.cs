using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework08_Class_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //для инициализации сруктуры не обязательно явно вызывать конструктор,
            //достаточно просто ее объявить и уже будет вызван дефолтный конструктор и будет доступ к ее полям
            MyStruct myStruct;

            myClass.change = "noChanged";
            myStruct.change = "noChanged";

            //После вызова данного метода поле у экземляра класса MyClass будет изменнено 
            //т.к. передается ссылка и мы работает с тем объектом который передаем (классы это ссылочный тип) 
            ClassTaker(myClass);
            Console.WriteLine("myClass.change = {0}", myClass.change);

            //После вызова данного метода поле у экземляра структуры MyStruct НЕ будет изменнено 
            //т.к. при вызове данного метода создается копия структуры,и мы работает с новым экземпляром структы MyStruct
            StructTaker(myStruct);
            Console.WriteLine("myStruct.change = {0}", myStruct.change);

            //И для того чтобы изменить значение поля нужно передать ссылку на структуру
            StructTaker(ref myStruct);           
            Console.WriteLine("myStruct.change = {0}", myStruct.change);

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Changed.";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Changed.";
        }

        static void StructTaker(ref MyStruct myStruct)
        {
            myStruct.change = "Changed.";
        }
    }
}
