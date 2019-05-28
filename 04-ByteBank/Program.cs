using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            

            //* Podemos expressaro código numa expressão booleana


            ContaCorrente contaDoArthur = new ContaCorrente();

            contaDoBruno.titular = "Arthur";

            Console.WriteLine(contaDoArthur.saldo);

            bool resultadoSaque = contaDoArthur.Sacar(50);

            Console.WriteLine(contaDoArthur.saldo);
            Console.WriteLine(resultadoSaque);

            Console.Read();
        }
    }
}
