using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    class Professores
    {
        public string Nome { get; set; }
        public int Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Area { get; set; }

        public Professores()
        {

        }

        public Professores(string nome, int altura, DateTime dataNascimento, string area)
        {
            Nome = nome;
            Altura = altura;
            DataNascimento = dataNascimento;
            Area = area;
        }
        public Professores(Professores p)
        {
            Nome = p.Nome;
            Altura = p.Altura;
            DataNascimento = p.DataNascimento;
            Area = p.Area;
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
            return "Nome: " + Nome + "\nAltura: " + Altura + "\nIdade: " + calcularIdade() + "\nArea: " + Area;
        }
        public static Professores CriarProfessor()
        {
            Console.Clear();
            Professores professores = new Professores();

            Console.WriteLine("Insira o nome do professor: ");
            professores.Nome = Console.ReadLine();
            Console.WriteLine("Insira a altura do professor: ");
            professores.Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a data de nascimento YYYY/MM/DD: ");
            professores.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira a área do professor: ");
            professores.Area = Console.ReadLine();

            return professores;
        }
    }
}
