using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            res = n1 = n2 = 0;
            n1 = 10;
            n2 = 2;// if 2 will be no error, if 0 that's impossible to divide causing exception..
            try
            {
                res = n1 / n2;
                Console.WriteLine("{0}/{1}={2}", n1, n2, res);
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
