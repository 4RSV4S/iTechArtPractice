using System;

namespace Pract1
{
    class A
    {
        public int a;
    }
    class B : A
    {
        public int b;
    }
    class Program
    {
        static int PostIncrement(int var1) //Метод, возвращающий постфиксный инкремент
        {
            return var1++;
        }
        static int PreIncrement(int var1) //Метод, возвращающий префиксный инкремент
        {
            return ++var1;
        }
        static int PostDecrement(int var1) //Метод, возвращающий постфиксный декремент
        {
            return var1--;
        }
        static int PreDecrement(int var1) //Метод, возвращающий префиксный декремент
        {
            return --var1;
        }
        static int AdditionAndSubtraction(int var1, int var2, int var3) //Метод, возвращающий результат сложения и вычитания (a + b - c)
        {
            return var1 + var2 - var3;
        }
        static int MultiplicationAndDivisionInt(int var1, int var2, int var3) //Метод, возвращающий результат умножения и деления целых чисел (a * b / c)
        {
            return var1 * var2 / var3;
        }
        static double MultiplicationAndDivisionDouble(double var1, double var2, double var3) //Метод, возвращающий результат умножения и деления чисел с плавающей запятой (a * b / c)
        {
            return var1 * var2 / var3;
        }
        static int SurplusInt(int var1, int var2) //Метод, возвращающий остаток от деления целых чисел
        {
            return var1 % var2;
        }
        static double SurplusDouble(double var1, double var2) //Метод, возвращающий остаток от деления чисел с плавающей запятой
        {
            return var1 % var2;
        }
        static bool Negation(bool var1) //Метод, возвращающий отрицание
        {
            return !var1;
        }
        static bool And(bool var1, bool var2) //Метод, возвращающий логическое И
        {
            return var1 & var2;
        }
        static bool ExcepOr(bool var1, bool var2) //Метод, возвращающий логическое исключение ИЛИ 
        {
            return var1 ^ var2;
        }
        static bool Or(bool var1, bool var2) //Метод, возвращающий логическое ИЛИ
        {
            return var1 | var2;
        }
        static bool ConditionalAnd(bool var1, bool var2) //Метод, возвращающий условное логическое И
        {
            return var1 && var2;
        }
        static bool ConditionalOr(bool var1, bool var2) //Метод, возвращающий условное логическое ИЛИ
        {
            return var1 || var2;
        }
        static bool Equal(int var1, int var2) //Метод, возвращающий результат сравнения чисел (равенство)
        {
            return var1 == var2;
        }
        static void Main(string[] args)
        {

            //1. Проинициализировать переменные всех типов.
            bool a = true;
            bool a1 = false;
            byte b = 255;
            sbyte c = -128;
            char d = 'd';
            decimal e = 1223;
            double f = 3;
            double f1 = 4;
            double f2 = 2;
            float @float = 33234; //спецсимвол @
            int h = -2;
            int h1 = 5;
            int h2 = 8;
            uint i = 3;
            long j = -32423324;
            ulong k = 21318234;
            short l = -5;
            ushort m = 5;
            object n = 1;
            string o = "abcdefg";
            dynamic p = "abc123";
            dynamic p1 = 123;
            l = (short)f; //явное преобразование типов


            //2.Написать примеры использования всех операторов.

            Console.Write($"1 + (-2) = {PreIncrement(h)}\n"); //Инкремент
            Console.Write($"-1 + (-2) = {PreDecrement(h)}\n"); //Декремент
            Console.Write($"-2 + 5 - 8 = {AdditionAndSubtraction(h, h1, h2)}\n"); //Сложение и вычитание
            Console.Write($"3 * 4 / 2 = {MultiplicationAndDivisionDouble(f, f1, f2)}\n"); //Умножение и деление
            Console.Write($"8 % 5 = {SurplusInt(h2, h1)}\n"); //Деление с остатком
            Console.Write($"!true = {Negation(a)}\n"); //Отрицание
            Console.Write($"true & true = {And(a, a)}\n"); //Логическое И
            Console.Write($"true ^ true = {ExcepOr(a, a)}\n"); //Логическое исключение ИЛИ
            Console.Write($"true | false = {Or(a, a1)}\n"); //Логическое ИЛИ
            Console.Write($"-2 == -2 {Equal(h, h)}\n"); //Равенство
            Console.Write($"true == false {(a == a1 ? a : a1)}\n"); //Тернарный оператор ?:

            //ОПЕРАТОРЫ ПРОВЕРКИ ТИПА И ВЫРАЖЕНИЯ ПРИВЕДЕНИЯ
            if (h is int)
                Console.Write($"Переменная h = {h} есть типа int");
            else
                Console.Write($"Переменная h = {h} не имеет типа int");

            A objA = new A();
            B objB = new B();
            if (objB == null)
                Console.Write("Невозможно привести objA к типу B");
            else
                objB = objA as B;

        }
    }
}

