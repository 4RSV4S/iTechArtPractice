using System;

namespace Pract2
{
    class Program
    {
        private class Overload
        {
            public void DisplayOverload(int a)
            {
                Console.WriteLine($"DisplayOverload: {a}");
            }
            public void DisplayOverload(string a)
            {
                Console.WriteLine($"DisplayOverload: {a}");
            }
            public void DisplayOverload(string a, int b)
            {
                Console.WriteLine($"DisplayOverload: {a} {b}");
            }
            /*public void DispalyOverload() { } Метод идентифицируется по параметрам и (или) по его имени, а не по возвращаемому типу 
            public int DisplayOverload() { }
            static void DispalyOverload(int a) { } модификаторы типа publuic/static не идентифицируют метод
            public void DisplayOverload(int a) { }
            public void DisplayOverload(string a) { } */

            /*public void DisplayOverload(int a) модификаторы доступа ref/out  также не идентифицируют метод
            {
                Console.WriteLine($"DisplayOverload: {a}");
            }
            private void DisplayOverload(out int a)
            {
                a = 100;
            }
            private void DisplayOverload(ref int a) { } */

            /*public void DisplayOverload(int a, string a) { } имена параметров должны быть уникальны 
            public void Display(int a) { string a; } имя параметра метода не должно совпадать с именем перменной, созданной в этом же методе */
            public void DisplayOverload(int a, string b) { }
            public void Display(int a) { string b; }
        }

        private class Overload1
        {
            private string name = "Akhil";

            public void Display()
            {
                Display2(ref name, ref name);
                Console.WriteLine(name);
            }

            private void Display2(ref string x, ref string y)
            {
                Console.WriteLine(name);
                x = "Akhil 1";
                Console.WriteLine(name);
                y = "Akhil 2";
                Console.WriteLine(name);
                name = "Akhil 3";

            }
        }

        public class Overload2
        {
            public void Display()
            {
                DisplayOverload(100, "Akhil", "Mittal", "OOP");
                DisplayOverload(200, "Akhil");
                /*DisplayOverload(300);*/
                string[] names = { "Akhil", "Ekta", "Arsh" };
                DisplayOverload(200, names);
            }

            private void DisplayOverload(int a, params int[] parameterArray)
            {
                foreach (var i in parameterArray)
                    Console.WriteLine(i + " " + a);
            }
            private void DisplayOverload(int a, params string[] parameterArray)
            {
                foreach (var i in parameterArray)
                    Console.WriteLine(i + " " + a);
            }
            /*массив параметров должен быть одномерным*/
        }

        public class Overload3 
        {
            public void Display()
            {
                int[] numbers = { 10, 20, 20 };
                DisplayOverload(40, numbers); //при таком синтаксисе массив передается по ссылке
                Console.WriteLine(numbers);
            }

            private void DisplayOverload(int a, params int[] parameterArray)
            {
                parameterArray[1] = 3000;
            }
        }
        public class Overload4
        {
            public void Display()
            {
                int number = 102;
                DisplayOverload(40, 1000, number, 4000); //из переданных параметров C# автоматически формирует новый, временный массив и элементы передаются по значению
                Console.WriteLine(number);
            }

            private void DisplayOverload(int a, params int[] parameterArray)
            {
                parameterArray[1] = 3000;
            }
        }

        /*C# рассматривает методы с массивом параметров последними. Ключевое слово params может быть применено только к последнему
аргументу метода.*/

        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);
            var overload1 = new Overload1();
            overload1.Display();
            var overload2 = new Overload1();
            overload1.Display();
            var overload3 = new Overload1();
            overload1.Display();
            var overload4 = new Overload1();
            overload1.Display();

            ClassA a = new ClassA();
            a.Display1();
            ClassB b = new ClassB();
            /*b.Display2(); наследованиен не работает в обратном направлении*/

            /*ClassC abstr = new ClassC(); невозможно создать объект абстрактного класса*/

            ClassD d = new ClassD();
        }
    }
}
