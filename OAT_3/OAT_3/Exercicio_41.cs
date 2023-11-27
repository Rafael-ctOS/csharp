using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    public class Exercicio_41
    {
        public void Exercicio41()
        {
            Console.WriteLine("");
            Console.WriteLine("EXERCICIO 41");
            Console.WriteLine("");

            char resposta;

            do
            {
                Console.Clear();
                ClassificarNadador();

                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadKey().KeyChar;

            } while (resposta != 'S' && resposta != 's');
        }

        static void ClassificarNadador()
        {
            Console.Write("Informe a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            string categoria;

            if (idade >= 5 && idade <= 7)
            {
                categoria = "Infantil A";
            }
            else if (idade >= 8 && idade <= 11)
            {
                categoria = "Infantil B";
            }
            else if (idade >= 12 && idade <= 13)
            {
                categoria = "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                categoria = "Juvenil B";
            }
            else if (idade >= 18)
            {
                categoria = "Adultos";
            }
            else
            {
                categoria = "Idade não correspondente a nenhuma categoria.";
            }

            Console.WriteLine($"O nadador está na categoria: {categoria}");
            Console.WriteLine("");
        }
    }
}