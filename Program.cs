using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
          
        }
        static void Start(int tempoParada)
        {
            //Console.WriteLine("Tempo do cronometro");
            //int tempoParada = int.Parse(Console.ReadLine());
            int tempoInicio = 0;

            while(tempoInicio != tempoParada)
            {
                Console.Clear();
                Console.WriteLine($"{tempoParada}");
                tempoParada--;
                Thread.Sleep(1000); ///Tempo de execução do programa
            }
            Console.Clear();
            Console.WriteLine("Tempo Finalizado");
            Thread.Sleep(2500); //Tempo de execução do programa
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair ");
            Console.WriteLine("Quanto tempo deseja");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length-1, 1)); //Pegar o ultimo caracter
            int tempoParada = int.Parse(data.Substring(0, data.Length - 1)); //Pegar todos menos o ultimo

            int multiplicador = 1;
            if (tipo == 'm')
                multiplicador = 60;

            if (tempoParada == 0)
                System.Environment.Exit(0);

            PreStart(tempoParada * multiplicador);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set..");
            Thread.Sleep(1000);
            Console.WriteLine("Go");
            Thread.Sleep(2500);

            Start(time);
        }
    }
}
