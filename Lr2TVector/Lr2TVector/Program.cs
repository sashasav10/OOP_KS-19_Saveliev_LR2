using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть першу координату вектора:");
            double temp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу координату вектора:");
            double temp2 = double.Parse(Console.ReadLine());
            TVector2D inp1 = new TVector2D(temp1,temp2);
            Console.WriteLine("Отриманий вектор:");
            Console.WriteLine(inp1.ToString());
            Console.WriteLine("Довжина вектора:");
            Console.WriteLine(inp1.VectorLength());
            Console.WriteLine("Нормований вектор:");
            Console.WriteLine(inp1.ToNormVector());
            Console.WriteLine("Генеруємо новий вектор рандомно:");
            TVector2D ran2 = new TVector2D();
            Console.WriteLine(ran2);
            Console.WriteLine("Перевіримо чи рівний попередьньому:");
            if (inp1.IsTheSame(ran2)) Console.WriteLine("Вектори рівні");
            else Console.WriteLine("Вектори не рівні");
            Console.WriteLine("Додамо два ветора:");
            TVector2D sum = new TVector2D(inp1 + ran2);
            Console.WriteLine(sum);
            Console.WriteLine("Віднімимо два ветора:");
            TVector2D abs = new TVector2D(inp1 - ran2);
            Console.WriteLine(abs);
            Console.WriteLine("Помножимо два ветора:");
            TVector2D mul = new TVector2D(inp1 * ran2);
            Console.WriteLine(mul);


            Console.WriteLine("-----------------");
            Console.WriteLine("Попрацюємо з тривімірним вектором");
           Console.WriteLine("Введіть першу координату вектора:");
            double tem1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу координату вектора:");
            double tem2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть третю координату вектора:");
            double tem3 = double.Parse(Console.ReadLine());
            TVector3D inp21 = new TVector3D(tem1, tem2,tem3);
            Console.WriteLine("Отриманий вектор:");
            Console.WriteLine(inp21.ToString());
            Console.WriteLine("Довжина вектора:");
            Console.WriteLine(inp21.VectorLength());
            Console.WriteLine("Нормований вектор:");
            Console.WriteLine(inp21.ToNormVector());
            Console.WriteLine("Генеруємо новий вектор рандомно:");
            TVector3D ran22 = new TVector3D();
            Console.WriteLine(ran22);
            Console.WriteLine("Перевіримо чи рівний попередьньому:");
            if (inp21.IsTheSame(ran22)) Console.WriteLine("Вектори рівні");
            else Console.WriteLine("Вектори не рівні");
            Console.WriteLine("Додамо два ветора:");
            Console.WriteLine(inp21 + ran22);
            Console.WriteLine("Віднімимо два ветора:");
            Console.WriteLine(inp21 - ran22);
            Console.WriteLine("Помножимо два ветора:");
            Console.WriteLine(inp21 * ran22);


            Console.ReadKey();
        }
    }
}
