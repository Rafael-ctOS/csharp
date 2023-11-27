using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                int validador = 0;

                do
                {
                    Console.WriteLine("Escolha o programa que deseja rodar");
                    Console.WriteLine("Programas disponiveis: 1 ao 12");
                    Console.WriteLine("Para fechar o programa Digite -1");
                    Console.WriteLine("");

                int numeroPrograma = int.Parse(Console.ReadLine());

                    switch (numeroPrograma)
                    {
                        case 1:
                            Exercicio_01 exercicio_01 = new Exercicio_01();
                            exercicio_01.Exercicio1();
                            break;

                        case 2:
                            Exercicio_02 exercicio_02 = new Exercicio_02();
                            exercicio_02.Exercicio2();
                            break;

                        case 3:
                            Exercicio_03 exercicio_03 = new Exercicio_03();
                            exercicio_03.Exercicio3();
                            break;

                        case 4:
                            Exercicio_04 exercicio_04 = new Exercicio_04();
                            exercicio_04.Exercicio4();
                            break;

                        case 5:
                            Exercicio_05 exercicio_05 = new Exercicio_05();
                            exercicio_05.Exercicio5();
                            break;

                        case 6:
                            Exercicio_06 exercicio_06 = new Exercicio_06();
                            exercicio_06.Exercicio6();
                            break;

                        case 7:
                            Exercicio_07 exercicio_07 = new Exercicio_07();
                            exercicio_07.Exercicio7();
                            break;

                        case 8:
                            Exercicio_08 exercicio_08 = new Exercicio_08();
                            exercicio_08.Exercicio8();
                            break;

                        case 9:
                            Exercicio_09 exercicio_09 = new Exercicio_09();
                            exercicio_09.Exercicio9();
                            break;

                        case 10:
                            Exercicio_10 exercicio_10 = new Exercicio_10();
                            exercicio_10.Exercicio10();
                            break;

                        case 11:
                            Exercicio_11 exercicio_11 = new Exercicio_11();
                            exercicio_11.Exercicio11();
                            break;

                        case 12:
                            Exercicio_12 exercicio_12 = new Exercicio_12();
                            exercicio_12.Exercicio12();
                            break;



                        case -1:
                            Console.WriteLine("Fechando o programa...");
                            Console.Read();
                            validador = -1;
                            break;

                        default:
                            Console.WriteLine("Digito inválido, digite novamente");
                            Console.WriteLine("");
                            break;
                    }


                } while (validador != -1);
     
                     
        }
    }
}