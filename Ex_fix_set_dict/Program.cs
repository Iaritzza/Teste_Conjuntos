using System;
using System.Collections.Generic;

namespace Ex_fix_set_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursA = new HashSet<int>();
            HashSet<int> cursB = new HashSet<int>();
            HashSet<int> cursC = new HashSet<int>();

            Console.WriteLine("Quantos alunos fazem o curso A?: ");
            int quant = int.Parse(Console.ReadLine());

            for(int i=0; i<quant; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursA.Add(cod);
            }

            Console.WriteLine("Quantos alunos fazem o curso B?: ");
            quant = int.Parse(Console.ReadLine());

            for(int i=0; i<quant; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursB.Add(cod);
            }

            Console.WriteLine("Quantos alunos fazem o curso C?: ");
            quant = int.Parse(Console.ReadLine());

            for(int i=0; i<quant; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursC.Add(cod);
            }

            HashSet<int> aux = new HashSet<int>(cursA);
            aux.UnionWith(cursB);
            aux.UnionWith(cursC);

            Console.WriteLine("Total de alunos: " + aux.Count);

            Console.Write("APENAS ALTERANDOO");
        }

        


    }
}
