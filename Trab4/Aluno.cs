using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trab4
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Morada { get; set; }
        public int Telemovel { get; set; }
        public Aluno() { }
        public Aluno(string n, int i, string m, int t)
        {
            Nome = n;
            Idade = i;
            Morada = m;
            Telemovel = t;
        }
    }
}

