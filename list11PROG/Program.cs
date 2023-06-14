using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list11PROG
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet;
            int n;


            vet = new int[1000];
            Random rand = new Random();



            for (int i = 0; i < 1000; i++)
            {




                vet[i] = rand.Next(1, 1000);



            }
            Console.WriteLine("digite um número: ");
            n = int.Parse(Console.ReadLine());



            for (int i = 0; i < 1000; i++)
            {
                if (n == vet[i])
                {
                    Console.WriteLine("o número digitado esta no vetor.");
                    break;
                }
            }
        }
        public static void Exercicio2()
        {
            int[] vet1;
            int contador = 0;
            vet1 = new int[20000];
            Random rand = new Random();



            for (int i = 0; i < 1000; i++)
            {




                vet1[i] = rand.Next(1, 20000);



            }

            Console.WriteLine("digite um numero para comparação");
            int nu = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (nu == vet1[i])
                {
                    contador++;
                }
            }
            Console.WriteLine("o numero digitado apareceu: {0}", contador);



        }
        public static void Exercicio3()
        {


            int[] vet4;

            int[] vet5;

            int[] vet6;

            vet4 = new int[10];

            vet5 = new int[10];

            vet6 = new int[10];

            Random rand = new Random();



            for (int i = 0; i < 10; i++)

            {

                vet5[i] = rand.Next(1, 1000);

            }

            for (int i = 0; i < 10; i++)

            {

                if (vet5[i] % 2 == 0)

                {

                    vet4[i] = vet5[i] / 2;

                }

                else

                {

                    vet6[i] = vet5[i] * 3;

                }

            }

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine("numeros pares {0}", vet4[i]);

                Console.WriteLine("numeros impares {0}", vet6[i]);



            }


        }
        public static void Exercicio4()
        {
            int[] numeros = new int[5000];
            Random random = new Random();

           
            for (int i = 0; i < 5000; i++)
            {
                numeros[i] = random.Next(1, 10000);
            }

            
            Console.WriteLine("Números primos encontrados:");
            for (int i = 0; i < 5000; i++)
            {
                int numero = numeros[i];
                int divisores = 0;

                if (numero < 2)
                {
                    divisores = 1;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(numero); j++)
                    {
                        if (numero % j == 0)
                        {
                            divisores++;
                            break;
                        }
                    }
                }

                if (divisores == 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.ReadLine();
        }


    }
    static void Main(string[] args)
    {
        
        int opcao;

        do
        {
            Console.WriteLine("=========MENU===========");
            Console.WriteLine("para SAIR DIGITE - 0 ");
            Console.WriteLine("EXERCICIO 1 ");
            Console.WriteLine("EXERCICIO 2 ");
            Console.WriteLine("EXERCICIO 3 ");
            Console.WriteLine("EXERCICIO 4 ");

            Console.WriteLine("===========================");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("obrigado por usar");
                    break;

                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;



                default:
                    Console.WriteLine("essa opção não existe");
                    break;
            }
            Console.ReadKey();




        } while (opcao != 0);
    }



}

