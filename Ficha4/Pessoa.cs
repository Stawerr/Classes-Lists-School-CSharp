using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Altura { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, DateTime dataNascimento, int altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }
        public Pessoa(Pessoa p)
        {
            Nome = p.Nome;
            DataNascimento = p.DataNascimento;
            Altura = p.Altura;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
