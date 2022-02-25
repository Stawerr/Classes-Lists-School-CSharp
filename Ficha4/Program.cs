using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    class Program
    {
        static List<Alunos> listaAlunos;
        static List<Professores> listaProfessores;
        static void Main(string[] args)
        {
            listaAlunos = new List<Alunos>();
            listaProfessores = new List<Professores>();

            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das seguintes opções");
                Console.WriteLine("1-Inserir Professor");
                Console.WriteLine("2-Inserir Aluno");
                Console.WriteLine("3-Calcular idade media Professores");
                Console.WriteLine("4-Calcular idade media Alunos");
                Console.WriteLine("5-Listar Alunos");
                Console.WriteLine("6-Listar Professores");
                Console.WriteLine("7-Alterar Curso Alunos");
                Console.WriteLine("0-Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                    break;
                else if (op == 1)
                    InserirProfessor();
                else if (op == 2)
                    InserirAluno();
                else if (op == 3)
                    MediaProfessores();
                else if (op == 4)
                    MediaAlunos();
                else if (op == 5)
                    ListarAlunos();
                else if (op == 6)
                    ListarProfessores();
                else if (op == 7)
                    AlterarCursoAlunos();
                else
                    Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadKey();
            }
        }

        private static void AlterarCursoAlunos()
        {
            listaAlunos = listaAlunos.OrderBy(x => x.Numero).ToList();

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                Console.WriteLine(listaAlunos[i].ToString());
            }
            Console.WriteLine("-----------------------------");

            int numero = 0;
            Console.WriteLine("Insira o Numero de aluno a editar: ");
            numero= int.Parse(Console.ReadLine());
            for (int i = 0; i < listaAlunos.Count; i++)
            {
                if (listaAlunos[i].Numero == numero)
                {
                    Console.WriteLine("Digite o novo curso: ");
                    listaAlunos[i].Curso = Console.ReadLine();
                }
            }
        }

        private static void ListarProfessores()
        {
            {
                for (int i = 0; i < listaProfessores.Count; i++)
                {
                    Console.WriteLine(listaProfessores[i].ToString());
                }
                Console.WriteLine("-----------------------------");
            }
        }

        private static void ListarAlunos()
        {
            listaAlunos = listaAlunos.OrderBy(x => x.Curso).ToList();

            for (int i = 0; i < listaAlunos.Count; i++)
            {
               Console.WriteLine(listaAlunos[i].ToString());
            }
            Console.WriteLine("-----------------------------");
        }

        private static void MediaAlunos()
        {
            double soma = 0;
            double media = 0;

            for (int i = 0; i < listaAlunos.Count; i++)
            {
                soma = soma + listaAlunos[i].calcularIdade();
            }
            media = soma / listaAlunos.Count;

            Console.WriteLine("A média de idade dos alunos é: " + media);
        }

        private static void MediaProfessores()
        {
            double soma = 0;
            double media = 0;

            for (int i = 0; i < listaProfessores.Count; i++)
            {
                soma = soma + listaProfessores[i].calcularIdade();
            }
            media = soma / listaProfessores.Count;

            Console.WriteLine("A média de idade dos alunos é: " + media);
        }

        private static void InserirAluno()
        {
            listaAlunos.Add(Alunos.CriarAluno());
        }

        private static void InserirProfessor()
        {
            listaProfessores.Add(Professores.CriarProfessor());
        }
    }
}
