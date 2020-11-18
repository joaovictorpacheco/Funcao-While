using System;

namespace FuncaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Aprendendo WHILE");

            // Console.WriteLine("Digite um número");
            // decimal numero = decimal.Parse(Console.ReadLine());

            // decimal i = 0;

            // Console.WriteLine("--------------------");

            // //While repete enquanto a condição for verdadeira
            // while (i <= numero)
            // {
            //     Console.WriteLine(i);
            //     i = i + 0.01m;// incremento
            // };//fim do while
            // string resposta = "";
            // do{
            //     Console.WriteLine("Digite seu email");
            //     resposta = Console.ReadLine();
            // }while(resposta != "joaovictorspzo@gmail.com");

            // Console.WriteLine("E-Mail confirmado");

            // Console.WriteLine("Digite a idade do ator");
            // int idade = int.Parse(Console.ReadLine());

            //     while(idade != 47)
            //     {
            //         Console.WriteLine("Errou!");
            //         Console.WriteLine("Digite a idade o ator novamente");
            //         idade = int.Parse(Console.ReadLine());
            //     }
            //         Console.WriteLine("Acertou miseravi");

                
                int idade;
            do{
                Console.WriteLine("Digite a idade do ator");
                idade = int.Parse(Console.ReadLine());
            }while(idade != 47);
            Console.WriteLine("Acertou miseravi");

            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            int contadorw = 0;
            while (contadorw <= numero)
            {
                Console.WriteLine(contadorw);
                contadorw++;
            }
            // Com for

                Console.WriteLine("Digite um valor");
                int numerof = int.Parse(Console.ReadLine());

                for (var contador = 0; contador <= numerof; contador++)
                {
                    Console.WriteLine(contador);
                }
            
        }
    }
}
