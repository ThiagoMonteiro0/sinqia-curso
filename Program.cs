using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int x = 10;
            //float z =1.5f;
            //double a = 1.5; //suporta mais valores, sendo ',' no padão BR e '.' no padão US
            //bool b =true\false;
            //string y ="cadeia de caracteres" ;
            //char c ='c';

            Console.WriteLine("bem vindo ao codigo da aula.");
            Console.WriteLine("escolha a opção abaixo");
            Console.WriteLine("1 - digite um texto");
            Console.WriteLine("2 - escolher uma letra");
            Console.WriteLine("3 - verdadeiro ou falso");
            Console.WriteLine("4 - um valor com decimal");
            Console.Write("opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Write($"você escolheu a opção{opcao}\n");

        }
    }
}
