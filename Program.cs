//1.Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
//    Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе
using Задание_11;
Console.WriteLine("Введите значение k");
double k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b");
double b = Convert.ToInt32(Console.ReadLine());
Func c = new Func(k, b);
Console.WriteLine(c.Root());

