using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OAT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int validador = 0;

            do
            {
                Console.WriteLine("}-------------------------------------{");
                Console.WriteLine("| Escolha o programa que deseja rodar |");
                Console.WriteLine("|   Programas disponiveis: 1 ao 64    |");
                Console.WriteLine("|  Para fechar o programa digite -1   |");
                Console.WriteLine("|    Digite -2 para limpar a tela     |");
                Console.WriteLine("}-------------------------------------{");

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

                    case 13:
                        Exercicio_13 exercicio_13 = new Exercicio_13();
                        exercicio_13.Exercicio13();
                        break;

                    case 14:
                        Exercicio_14 exercicio_14 = new Exercicio_14();
                        exercicio_14.Exercicio14();
                        break;

                    case 15:
                        Exercicio_15 exercicio_15 = new Exercicio_15();
                        exercicio_15.Exercicio15();
                        break;

                    case 16:
                        Exercicio_16 exercicio_16 = new Exercicio_16();
                        exercicio_16.Exercicio16();
                        break;

                    case 17:
                        Exercicio_17 exercicio_17 = new Exercicio_17();
                        exercicio_17.Exercicio17();
                        break;

                    case 18:
                        Exercicio_18 exercicio_18 = new Exercicio_18();
                        exercicio_18.Exercicio18();
                        break;

                    case 19:
                        Exercicio_19 exercicio_19 = new Exercicio_19();
                        exercicio_19.Exercicio19();
                        break;

                    case 20:
                        Exercicio_20 exercicio_20 = new Exercicio_20();
                        exercicio_20.Exercicio20();
                        break;

                    case 21:
                        Exercicio_21 exercicio_21 = new Exercicio_21();
                        exercicio_21.Exercicio21();
                        break;

                    case 22:
                        Exercicio_22 exercicio_22 = new Exercicio_22();
                        exercicio_22.Exercicio22();
                        break;

                    case 23:
                        Exercicio_23 exercicio_23 = new Exercicio_23();
                        exercicio_23.Exercicio23();
                        break;

                    case 24:
                        Exercicio_24 exercicio_24 = new Exercicio_24();
                        exercicio_24.Exercicio24();
                        break;

                    case 25:
                        Exercicio_25 exercicio_25 = new Exercicio_25();
                        exercicio_25.Exercicio25();
                        break;

                    case 26:
                        Exercicio_26 exercicio_26 = new Exercicio_26();
                        exercicio_26.Exercicio26();
                        break;

                    case 27:
                        Exercicio_27 exercicio_27 = new Exercicio_27();
                        exercicio_27.Exercicio27();
                        break;

                    case 28:
                        Exercicio_28 exercicio_28 = new Exercicio_28();
                        exercicio_28.Exercicio28();
                        break;

                    case 29:
                        Exercicio_29 exercicio_29 = new Exercicio_29();
                        exercicio_29.Exercicio29();
                        break;

                    case 30:
                        Exercicio_30 exercicio_30 = new Exercicio_30();
                        exercicio_30.Exercicio30();
                        break;

                    case 31:
                        Exercicio_31 exercicio_31 = new Exercicio_31();
                        exercicio_31.Exercicio31();
                        break;

                    case 32:
                        Exercicio_32 exercicio_32 = new Exercicio_32();
                        exercicio_32.Exercicio32();
                        break;

                    case 33:
                        Exercicio_33 exercicio_33 = new Exercicio_33();
                        exercicio_33.Exercicio33();
                        break;

                    case 34:
                        Exercicio_34 exercicio_34 = new Exercicio_34();
                        exercicio_34.Exercicio34();
                        break;

                    case 35:
                        Exercicio_35 exercicio_35 = new Exercicio_35();
                        exercicio_35.Exercicio35();
                        break;

                    case 36:
                        Exercicio_36 exercicio_36 = new Exercicio_36();
                        exercicio_36.Exercicio36();
                        break;

                    case 37:
                        Exercicio_37 exercicio_37 = new Exercicio_37();
                        exercicio_37.Exercicio37();
                        break;

                    case 38:
                        Exercicio_38 exercicio_38 = new Exercicio_38();
                        exercicio_38.Exercicio38();
                        break;

                    case 39:
                        Exercicio_39 exercicio_39 = new Exercicio_39();
                        exercicio_39.Exercicio39();
                        break;

                    case 40:
                        Exercicio_40 exercicio_40 = new Exercicio_40();
                        exercicio_40.Exercicio40();
                        break;

                    case 41:
                        Exercicio_41 exercicio_41 = new Exercicio_41();
                        exercicio_41.Exercicio41();
                        break;

                    case 42:
                        Exercicio_42 exercicio_42 = new Exercicio_42();
                        exercicio_42.Exercicio42();
                        break;

                    case 43:
                        Exercicio_43 exercicio_43 = new Exercicio_43();
                        exercicio_43.Exercicio43();
                        break;

                    case 44:
                        Exercicio_44 exercicio_44 = new Exercicio_44();
                        exercicio_44.Exercicio44();
                        break;

                    case 45:
                        Exercicio_45 exercicio_45 = new Exercicio_45();
                        exercicio_45.Exercicio45();
                        break;

                    case 46:
                        Exercicio_46 exercicio_46 = new Exercicio_46();
                        exercicio_46.Exercicio46();
                        break;

                    case 47:
                        Exercicio_47 exercicio_47 = new Exercicio_47();
                        exercicio_47.Exercicio47();
                        break;

                    case 48:
                        Exercicio_48 exercicio_48 = new Exercicio_48();
                        exercicio_48.Exercicio48();
                        break;

                    case 49:
                        Exercicio_49 exercicio_49 = new Exercicio_49();
                        exercicio_49.Exercicio49();
                        break;

                    case 50:
                        Exercicio_50 exercicio_50 = new Exercicio_50();
                        exercicio_50.Exercicio50();
                        break;

                    case 51:
                        Exercicio_51 exercicio_51 = new Exercicio_51();
                        exercicio_51.Exercicio51();
                        break;

                    case 52:
                        Exercicio_52 exercicio_52 = new Exercicio_52();
                        exercicio_52.Exercicio52();
                        break;

                    case 53:
                        Exercicio_53 exercicio_53 = new Exercicio_53();
                        exercicio_53.Exercicio53();
                        break;

                    case 54:
                        Exercicio_54 exercicio_54 = new Exercicio_54();
                        exercicio_54.Exercicio54();
                        break;

                    case 55:
                        Exercicio_55 exercicio_55 = new Exercicio_55();
                        exercicio_55.Exercicio55();
                        break;

                    case 56:
                        Exercicio_56 exercicio_56 = new Exercicio_56();
                        exercicio_56.Exercicio56();
                        break;

                    case 57:
                        Exercicio_57 exercicio_57 = new Exercicio_57();
                        exercicio_57.Exercicio57();
                        break;

                    case 58:
                        Exercicio_58 exercicio_58 = new Exercicio_58();
                        exercicio_58.Exercicio58();
                        break;

                    case 59:
                        Exercicio_59 exercicio_59 = new Exercicio_59();
                        exercicio_59.Exercicio59();
                        break;

                    case 60:
                        Exercicio_60 exercicio_60 = new Exercicio_60();
                        exercicio_60.Exercicio60();
                        break;

                    case 61:
                        Exercicio_61 exercicio_61 = new Exercicio_61();
                        exercicio_61.Exercicio61();
                        break;

                    case 62:
                        Exercicio_62 exercicio_62 = new Exercicio_62();
                        exercicio_62.Exercicio62();
                        break;

                    case 63:
                        Exercicio_63 exercicio_63 = new Exercicio_63();
                        exercicio_63.Exercicio63();
                        break;

                    case 64:
                        Exercicio_64 exercicio_64 = new Exercicio_64();
                        exercicio_64.Exercicio64();
                        break;


                    case -1:
                        Console.WriteLine("Fechando o programa...");
                        Console.Read();
                        validador = -1;
                        break;

                    case -2:
                        Console.Clear();
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