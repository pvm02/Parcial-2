using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        class PruebaVector
        {

            private string[] Sueldo;
            private float[] Empleados;
            public void Cargar()
            {
                Sueldo = new string[2];
                Empleados = new float[2];

                for (int X = 0; X < Sueldo.Length; X++)
                {
                    Console.Write("Ingrese el salario " + (X + 1) + ": ");
                    string sueldo;
                    sueldo = Console.ReadLine();
                    Empleados[X] = float.Parse(sueldo);
                }
            }
            public void Mostrar()
            {
                float Salario1;
                int Salario2;
                Salario1 = Empleados[1];
                Salario2 = 0;

                for (int f = 1; f < Sueldo.Length; f++)
                {
                    if (Empleados[1] > Salario1)
                    {
                        Salario1 = Empleados[f];
                        Salario2 = f;
                    }
                }
                Console.WriteLine("Salario 1 :" + Empleados[Salario2]);
                Console.WriteLine("Salario 2: " + Salario1);
                Console.ReadKey();
            }
            static void Main(string[] args)
            {
                PruebaVector pv = new PruebaVector();
                pv.Cargar();
                pv.Mostrar();

            }
        }
    }
 }

