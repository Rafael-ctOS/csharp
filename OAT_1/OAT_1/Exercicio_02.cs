using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_1

//2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).

{
    public class Exercicio_02
    {
        public void Exercicio2()
        {

            {
                Console.WriteLine("");
                Console.WriteLine("EXERCICIO 02");
                Console.WriteLine("");

                Console.WriteLine("Digite o seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo (M ou F):");
                char sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite o estado civil (SOLTEIRO, CASADO, DIVORCIADO, VIUVO):");
                string estadoCivil = Console.ReadLine().ToUpper();

                if (sexo == 'F' && estadoCivil == "CASADO")
                {
                    Console.WriteLine("Digite o tempo de casada em anos:");
                    int tempoCasada = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}, Tempo de casada: {tempoCasada} anos");
                }


                // ADICIONEI DEVIDO A UMA DIFICULDADE DE ENTENDER COMO FARIA JUNTAMENTE A O SUBSTANTIVO MASCULINO, achei mais facil criar outro ELSE IF com o mesmo objetivo voltado pro substantivo feminino.
                else if (sexo == 'F' && estadoCivil == "CASADA") 
                {
                    Console.WriteLine("Digite o tempo de casada em anos:");
                    int tempoCasada = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}, Tempo de casada: {tempoCasada} anos");
                }


                else if (sexo == 'M')
                {
                    Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}");
                }
                else
                {
                    Console.WriteLine("Informações inválidas");
                }

                Console.WriteLine("");
            }
        }
    }



}
  