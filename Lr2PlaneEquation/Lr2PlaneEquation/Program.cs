using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2PlaneEquation
{
    
    class Program
    {
           static void Main()
        {
            Console.WriteLine("Введiть iндекси A, B, C, D через пробiл. Один з перших трьох має бути вiдмiним вiд нуля, iнакше буде взято 1");
            int[] array = new int[4];
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            PlaneEquation pe = new PlaneEquation(array);
            Console.WriteLine("iндекси рiвняння площини");
            Console.WriteLine(pe.Output());
            pe.Crossing();

            Console.WriteLine("Введiть три цілі значення точки x,y,z через пробiл для перевiрки належностi до площини");
            int[] array2 = new int[3];
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            pe.IsBelong(array2);
            Console.ReadKey();
        }
    }
}
