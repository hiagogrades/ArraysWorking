using System;
using System.Threading;

namespace PercorrendoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[2];
            meuArray[0] = 12;

            Console.WriteLine(meuArray.Length);

            //Utilizando o método for
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine($"For: {meuArray[index]}");
            }

            //Utilizando o método foreach (Para cada), faça...
            foreach (var item in meuArray)
            {
                Console.WriteLine($"Foreach: {item}");
            }

            //Utilizando Struct
            //Implementando uma struct para criar um array de funcionários
            var funcionarios = new Funcionario[5];

            //Atribuindo valor ao array funcionários
            funcionarios[0] = new Funcionario()
            {
                Id = 2579,
                Nome = "André"
            };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id + funcionario.Nome);
            }
            
        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
