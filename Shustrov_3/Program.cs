using System;

namespace Shustrov_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим данные в таком же порядке,как и в задании
            Console.Write("a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("B0=");
            float B0 = float.Parse(Console.ReadLine());
            Console.Write("Bk=");
            float Bk = float.Parse(Console.ReadLine());
            Console.Write("deltaB=");
            float deltaB = float.Parse(Console.ReadLine());

            //Запускаем цикл for для расчета каждого элемента
            for (float i = B0; i < Bk; i += deltaB)
            {
                float V = (float)((Math.Cos(Math.Sqrt(a * a + Math.Tan(a) + i))) / (x * x - i));//расчет элемента с помощью формулы из задания при определенном B
                Console.WriteLine("При B" + i + " V=" + V);//Вывод результата в консоль
            }
        }
    }
}
