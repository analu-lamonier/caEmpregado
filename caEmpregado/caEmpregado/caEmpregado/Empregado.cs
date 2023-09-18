using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class Empregado
    {
        // atributos
        protected string nome;
        protected string cpf;

        
        // métodos
        public Empregado()
        {

        }

        public Empregado(string  _nome, string _cpf)
        {
            nome = _nome;
            cpf = _cpf;
        }

        // getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public virtual double sal_liquido()
        {
            return 1000.00;
        }

    } // fim da classe Empregado
}
