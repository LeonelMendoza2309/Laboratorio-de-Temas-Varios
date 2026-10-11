using System;
using System.Collections.Generic;
using System.Text;

namespace sobrecargado
{
    public class SobreCargaMetodos
    {
        public class SobreCarga
        {
            public void ProbarMetodosSobreCargados()
            {
                Console.WriteLine("El cuadrado del integer 7 es {0}", cuadrado(7));
                Console.WriteLine("El cuadrado del double 7.5 es {0}", cuadrado(7.5));
            }

            public int cuadrado(int ValInt)
            {
                Console.WriteLine("Se invoca el método cuadrado con argumento int: {0}", ValInt);
                return ValInt * ValInt;
            }

            public double cuadrado(double ValDouble)
            {
                Console.WriteLine("Se invoca el método cuadrado con argumento double: {0}", ValDouble);
                return ValDouble * ValDouble;
            }
        }
    }
}
