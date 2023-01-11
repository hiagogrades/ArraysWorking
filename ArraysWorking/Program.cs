using System;

namespace ArraysWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Módulo para trabalho de arrays
            //Definindo um array (duas maneiras de definir um array)
            var meuArray = new int[5];
            //int[] meuArray2 = new int[5];
            //var meuArray = new Teste[1];
            //var meuArray = new Teste[1]{ new Teste() };
            var meuArrayStruct = new Teste[1]{new Teste()};

            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArrayStruct[0].Id);

        }

        struct Teste
        {
            public int Id { get; set; }
        }
    }
}
