using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    class Alunos
    {

        public string NomeAluno { get ; set ; }
        public int AlturaAluno { get; set; }
        public DateTime DataNascimento { get; set ; }
        public int Numero { get; set; }
        public string Curso { get; set; }
        

        public Alunos()
        {
            
        }

        public Alunos(string nome, int altura, DateTime datanascimento, int numero, string curso)
        {
            NomeAluno = nome;
            AlturaAluno = altura;
            DataNascimento = datanascimento;
            Numero = numero;
            Curso = curso;
        }
        public Alunos(Alunos a)
        {
            NomeAluno = a.NomeAluno;
            AlturaAluno = a.AlturaAluno;
            DataNascimento = a.DataNascimento;
            Numero = a.Numero;
            Curso = a.Curso;

        }
        public int calcularIdade()
        {
            if (DataNascimento.DayOfYear > DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - DataNascimento.Year - 1;
            }
            return DateTime.Now.Year - DataNascimento.Year;
        }
        public override string ToString()
        {
            return "Nome: " + NomeAluno + "\nAltura: " + AlturaAluno + "\nIdade: " + calcularIdade()+"\nNumero: "+Numero+"\nCurso: "+Curso+"\n";
        }
        public static Alunos CriarAluno()
        {
            Console.Clear();
            Alunos alunos = new Alunos();

            Console.WriteLine("Insira o nome do aluno: ");
            alunos.NomeAluno = Console.ReadLine();
            Console.WriteLine("Insira a altura do aluno: ");
            alunos.AlturaAluno = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a data de nascimento YYYY/MM/DD: ");
            alunos.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de aluno: ");
            alunos.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o curso do aluno: ");
            alunos.Curso = Console.ReadLine();

            return alunos;
        }
        
    }
}
