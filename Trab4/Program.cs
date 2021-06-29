using System;
using System.Collections.Generic;
namespace Trab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> lista = new();
            int opcao;
            do
            {
                Console.WriteLine("1 - Inserir aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Selecione opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        //opção 1
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Introduza nome do aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Introduza idade do aluno: ");
                        aluno.Idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduza morada do aluno: ");
                        aluno.Morada = Console.ReadLine();
                        Console.WriteLine("Introduza telemóvel do aluno: ");
                        aluno.Telemovel = Convert.ToInt32(Console.ReadLine());
                        lista.Add(aluno);
                        //opção 2
                        /*Console.WriteLine("Introduza nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Introduza nome do aluno: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduza nome do aluno: ");
                        string morada = Console.ReadLine();
                        Console.WriteLine("Introduza nome do aluno: ");
                        int telemovel = Convert.ToInt32(Console.ReadLine());
                        lista.Add(new Aluno(nome, idade, morada, telemovel));*/
                        break;
                    case 2:
                        foreach (Aluno a in lista)
                        {
                            Console.WriteLine($"Nome: {a.Nome} - Morada: { a.Morada} - Idade: { a.Idade} - Telemóvel: { a.Telemovel}");
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 3);
        }
    }
}
