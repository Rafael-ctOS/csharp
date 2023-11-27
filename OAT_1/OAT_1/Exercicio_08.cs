using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Program
{
    static void Main()
    {
        int num1, num2, num3;

        Console.Write("Digite o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        if (num1 > num3)
        {
            int temp = num1;
            num1 = num3;
            num3 = temp;
        }

        if (num2 > num3)
        {
            int temp = num2;
            num2 = num3;
            num3 = temp;
        }

        Console.WriteLine("Os números em ordem decrescente são: " + num3 + ", " + num2 + ", " + num1);
    }
}
