using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{

    class PruebaVector
    {
        private string[] Nombres;
        private float[] Salarios; 
        public void Cargar()
        {
            Nombres = new string[5];
            Salarios = new float[5];

            for (int X = 0; X < Nombres.Length; X++)
            {
                Console.Write("Ingrese el nombre del empleado " + (X + 1) + ": ");
                Nombres[X] = Console.ReadLine();
                Console.Write("Ingrese el sueldo " + (X + 1) + ": ");
                string sueldo;
                sueldo = Console.ReadLine();
                Salarios[X] = float.Parse(sueldo);
            }
        }
        public void SalarioMayor()
        {
            float Mayor;
            int Y;
            Mayor = Salarios[0];
            Y = 0;
            for (int f = 1; f < Nombres.Length; f++)
            {
                if (Salarios[f] > Mayor)
                {
                    Mayor = Salarios[f];
                    Y = f;
                }
            }
            Console.WriteLine("El empleado con salario mayor es :" + Nombres[Y]);
            Console.WriteLine("Con un salario de: " + Mayor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.SalarioMayor();
        }
    }
}