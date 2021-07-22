using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchUsing
{

    class Area
    {
        public static double Quad(double bas, double alt)
        {
            if (bas == 0.0 || alt == 0.0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return bas * alt;
        }
    }



    class UserException
    {
        static void Main(string[] args)
        {
            double area = 0.0;
            try
            {
                area = Area.Quad(15.0, 20.0); // if some parameter is 0, will be thrown an exception by user previously coded..
                Console.WriteLine("Area do quadrado é: {0}", area);
            }
            catch(Exception e)// or DivideByZeroException for more specific exception
            {
                Console.WriteLine("Erro!");
                Console.WriteLine("Conteudo do e:"+e);
                Console.WriteLine("Conteudo do e.Message: "+ e.Message);
                Console.WriteLine("Conteudo do e.GetType(): " + e.GetType());
            }
            finally
            {
                Console.WriteLine("Fim do processo, sempre executa!");
            }
            
            Console.ReadKey();
        }
    }
}
