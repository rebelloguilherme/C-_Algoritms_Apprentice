using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingOutput
{
    class FormatingOutput
    {
        static void Main()
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto..........:{0,5}", produto); //{0} é o índice da variável, 5 é o espaçamento entre a string e o valor da variável
            Console.WriteLine("Val. Compra......:{0,5:c}", valorCompra); // :c serve para formatar como currency(moeda)
            Console.WriteLine("Lucro............:{0,5:p}", lucro); // :p para formatar como percentage %
            Console.WriteLine("Val. Venda.......:{0,5:c}", valorVenda);
            Console.ReadKey();
        }
    }
}
