using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSomaArray
{
    internal class Program
    {

        public int Soma(int[] vetor)
        {
            return SomaRecursiva(vetor, 0, 0);
        }
        public int SomaRecursiva(int[] vetor, int soma, int count)
        {
            if (vetor.Length == count)
            {
                return soma;
            }
            return SomaRecursiva(vetor, soma + vetor[count], count + 1);

        }
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] array = { 1, 2, 3, 4 ,5};

            Console.WriteLine(program.Soma(array));



        }
    }
}
