using System;

namespace Lesson_28
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod();

            void MathMethod()
            {
                float a = 5.5f;
                var a1 = Math.Ceiling(a); //Округление в большую сторону
                var a2 = Math.Round(a); //Округление в меньшую сторону
                Console.WriteLine("Ceiling" + a1);
                Console.WriteLine("Round" + a2);

                var b = Convert.ToInt32(Console.ReadLine());
                float b1 = 12;
                float b2 = Math.Max(b, b1);
                float b3 = Math.Min(b, b1);
                Console.WriteLine("Max" + b2);
                Console.WriteLine("Min" + b3);

                float c1 = 12;
                float c2 = 2;
                var c3 = Math.Pow(c1, c2); //Возведение в степень
                var c4 = Math.Sqrt(c1); // Возврат значения из корня
                Console.WriteLine("Pow" + c3);
                Console.WriteLine("Sqrt" + c4);

                float d = 7;
                float d1 = 12;
                float d2 = Convert.ToInt32(Console.ReadLine());
                //float d3 = MathF.Lerp(d, d1, d2) //Интерполяция, перемещение из точки d в точку d1 за дельту d2 
            }
        }
    }
}
