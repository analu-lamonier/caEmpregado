using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregado
{
    class EmpregadoHORISTA : Empregado
    {
        // atributos
        private double preco_hora;
        private int nro_horas;
        private double descontoINSS;

        // métodos
        public EmpregadoHORISTA() : base()
        {
         
        }

        public EmpregadoHORISTA(string _nome, string _cpf,
                   double _preco_hora, int _nro_horas,
                   double _descontoINSS) : 
            base(_nome, _cpf)
        {
            preco_hora = _preco_hora;
            nro_horas = _nro_horas;
            descontoINSS = _descontoINSS;
        }


        // getters & setters
        public double Preco_hora { get => preco_hora; set => preco_hora = value; }
        public int Nro_horas { get => nro_horas; set => nro_horas = value; }
        public double DescontoINSS { get => descontoINSS; set => descontoINSS = value; }

        public override double sal_liquido()
        {
            double sal_liquido;
            double sal_bruto = Preco_hora * Nro_horas;

            sal_liquido = sal_bruto * (1 - DescontoINSS / 100.0);

            return (sal_liquido);
        }

    } // fim da classe EmpregadoHORISTA
}
