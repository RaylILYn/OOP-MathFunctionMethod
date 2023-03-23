// Задание 1.4 [Вариант 2]
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double vvod(string s) //метод предназначенный для ввода 
        //с клавиатуры одного числа
        {
            Console.Write("Введите  число " + s + " = ");
            double chislo = double.Parse(Console.ReadLine());
            return chislo;

        }
        //метод, предназначенный для вычисления функции
        static double function_f(double xx, double zz)
        {

            return (Math.Log10(xx) + Math.Cos(Math.Abs(xx + 2 * zz))) / Math.Pow(Math.Cos(Math.Pow(xx, 3)), 2) - 1.7f;
        }
        static void Main(string[] args)
        {
            double x, z, b;
            for (int i = 0; i < 3; i++)
            {
                x = vvod("x");
                z = vvod("z");
                if (Math.Pow(Math.Cos(x), 2) * Math.Pow(x, 3) == 0)
                {
                    Console.Write("На ноль делить нельзя\n");
                    break;
                }
                b = function_f(x, z);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("x={0}\ta={1}\nf={2,8:f3}\n", x, z, b);
                Console.ReadKey();
            }
        }
    }
}