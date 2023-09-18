using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class EmpregadoCLT : Empregado
    {
        // atributos 
        private double sal_bruto;
        private double descontoINSS;

        // getters & setters
        public double Sal_bruto { get => sal_bruto; set => sal_bruto = value; }
        public double DescontoINSS { get => descontoINSS; set => descontoINSS = value; }

        // métodos
        public EmpregadoCLT() : base()
        {

        }

        public EmpregadoCLT(string _nome, string _cpf,
                   double _sal_bruto, double _descontoINSS) :
            base(_nome, _cpf)
        {
            sal_bruto = _sal_bruto;
            descontoINSS = _descontoINSS;
        }

        

        public override double sal_liquido()
        {
            double sal_liquido;
            sal_liquido = sal_bruto * (1 - DescontoINSS / 100.0);

            return (sal_liquido);
        }

    } // fim da classe EmpregadoCLT
}
