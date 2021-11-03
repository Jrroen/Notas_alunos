using System;

namespace Notas_alunos
{
    class Alunos
    {
        static void Main(string[] args)
        {
            Notas aluno = new Notas();

            inicio:
            Console.Clear();

            Console.Write("Escreva o nome do aluno: ");
            aluno.Nome = (Console.ReadLine());
            Console.WriteLine("Digite as notas: Atividade, teste ou simulado e prova: ");
            Console.Write("Nota da atividade: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota do teste ou simulado: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota da prova: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Nota final de " + aluno.Nome + " é " + aluno.NotaFinal());
            Console.WriteLine();
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.WriteLine("ALUNO REPROVADO");
                Console.WriteLine("FALTAM " + aluno.NotaRestante() + " PONTOS PARA " + aluno.Nome + " ALCANÇAR A MÉDIA");
                Console.WriteLine();
            }

            double escolha;
            Console.WriteLine("Deseja verificar a nota de outro aluno? Aperte 1 para Sim e 2 para Não");
            escolha = double.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Até a proxima");
            }
        }
    }
}
