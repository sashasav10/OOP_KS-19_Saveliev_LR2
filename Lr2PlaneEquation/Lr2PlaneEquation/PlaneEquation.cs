using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2PlaneEquation
{
    public class PlaneEquation
    {
        private int[] abcd;


        public PlaneEquation(int [] param)
        {
            this.abcd = new int[4];
            for(int i=0;i<4;i++)
            {
                this[i] = param[i];
            }
        }
        public int this[int i]
        {
            get
            {
                return abcd[i];
            }
            set
            {
                //Проверяем, чтобы хоть один из первых трьох коэфицентов отличался от нуля
                //если А=0, B=0,С=0, то присваем С=1 
                if (abcd[0] == 0 && abcd[1] == 0 && abcd[2] == 0)
                { abcd[2] = 1; }
                abcd[i] = value;
                

            }

        }

        //методы:
        public string Output()
        {
            return abcd[0] + "x+" + abcd[1] + "y+" + abcd[2] + "z+" + abcd[3] + "=0";
        }

        public void Crossing()
        {
            //так как могут быть разные вариации размещения плоскости прийдется рассмотреть каждый вариант
            if (abcd[0] != 0 && abcd[1] != 0 && abcd[2] != 0 && abcd[3] != 0)
            {
                Console.WriteLine("Перетин вiсi Ох у точцi ({0};0;0)", (double)abcd[3] / abcd[0]);
                Console.WriteLine("Перетин вiсi Оy у точцi (0;{0};0)", (double)abcd[3] / abcd[1]);
                Console.WriteLine("Перетин вiсi Оz у точцi (0;0;{0})", (double)abcd[3] / abcd[2]);
            }
            else if (abcd[0] != 0 && abcd[1] != 0 && abcd[2] != 0 && abcd[3] == 0)
            {
                Console.WriteLine("Проходить через початок координат О(0;0;0), не перетинаючи вiсi");
            }
            else if ((abcd[0] == 0 && abcd[1] != 0 && abcd[2] != 0) || (abcd[0] != 0 && abcd[1] == 0 && abcd[2] != 0) || (abcd[0] != 0 && abcd[1] != 0 && abcd[2] == 0) && abcd[3] != 0)
            {
                if (abcd[0] == 0)
                {
                    Console.WriteLine("Перетин вiсi Оy у точцi (0;{0};0)", (double)abcd[3] / abcd[1]);
                    Console.WriteLine("Перетин вiсi Оz у точцi (0;0;{0})", (double)abcd[3] / abcd[2]);
                }
                else if (abcd[1] == 0)
                {
                    Console.WriteLine("Перетин вiсi Ох у точцi ({0};0;0)", (double)abcd[3] / abcd[0]);
                    Console.WriteLine("Перетин вiсi Оz у точцi (0;0;{0})", (double)abcd[3] / abcd[2]);
                }
                else if (abcd[2] == 0)
                {
                    Console.WriteLine("Перетин вiсi Ох у точцi ({0};0;0)", (double)abcd[3] / abcd[0]);
                    Console.WriteLine("Перетин вiсi Оу у точцi (0;{0};0)", (double)abcd[3] / abcd[1]);
                }
            }
            else if ((abcd[0] == 0 && abcd[1] == 0 && abcd[2] != 0) || (abcd[0] != 0 && abcd[1] == 0 && abcd[2] == 0) || (abcd[0] == 0 && abcd[1] != 0 && abcd[2] == 0) && abcd[3] != 0)
            {
                if (abcd[0] != 0)
                {
                    Console.WriteLine("Перетин вiсi Ох у точцi ({0};0;0)", (double)abcd[3] / abcd[0]);
                }
                else if (abcd[1] != 0)
                {
                    Console.WriteLine("Перетин вiсi Оу у точцi (0;{0};0)", (double)abcd[3] / abcd[1]);
                }
                else if (abcd[2] != 0)
                {
                    Console.WriteLine("Перетин вiсi Оz у точцi (0;0;{0})", (double)abcd[3] / abcd[2]);
                }
            }
            else if ((abcd[0] == 0 && abcd[1] != 0 && abcd[2] != 0) || (abcd[0] != 0 && abcd[1] == 0 && abcd[2] != 0) || (abcd[0] != 0 && abcd[1] != 0 && abcd[2] == 0) && abcd[3] == 0)

            {
                if (abcd[0] == 0)
                {
                    Console.WriteLine("Площина проходить через початок координат i вiсь x");
                }
                else if (abcd[1] == 0)
                {
                    Console.WriteLine("Площина проходить через початок координат i вiсь y");
                }
                else if (abcd[2] == 0)
                {
                    Console.WriteLine("Площина проходить через початок координат i вiсь z");
                }
            }
        }

        public void IsBelong(int[] par)
        {
            if (abcd[0] * par[0] + abcd[1] * par[1] + abcd[2] * par[2] + abcd[0] == 0)
            { Console.WriteLine("Точка належить площинi"); }
            else Console.WriteLine("Точка не належить площинi");
        }
    }

}
