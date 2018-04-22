using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_o_notacion
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Exponential exponential = new Exponential();
            //exponential.Function(45);
            //Logarithmic logarithmic = new Logarithmic();
            //logarithmic.Function(64);

            //Quadratic quadratic = new Quadratic();
            //quadratic.Function(20);

            Lineal lineal = new Lineal();
            lineal.Function();

            Console.ReadLine();

        }
    }
}
