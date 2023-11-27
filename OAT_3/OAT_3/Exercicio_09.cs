using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_09
    {
        public void Exercicio9()
        {

            Console.Write("Informe a idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.Write("Informe a idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.Write("Informe a idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int idadeEmDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("A idade total em dias é: " + idadeEmDias);

            Console.WriteLine("");
        }
    }
}