using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Vendedor : Funcionario
    {
        double vendas;

        public double Vendas
        {
            get
            {
                return this.vendas;
            }

            set
            {
                vendas = value;
            }
        }

        public Vendedor() : base() { }

        public Vendedor(string nome, string rg, double salarioMensal, double vendas) 
            : base(nome, rg, salarioMensal)
        {
            this.Vendas = vendas;
        }

        public override void imprimirSalario()
        {
            double salarioFinal = SalarioMensal + 0.05 * vendas;
            vendas = 0;
            Console.WriteLine("Nome: " + Nome + "\nSalário: R$" + salarioFinal);
        }

        public override string ToString()
        {
            return base.ToString() + "\nVendas: " + vendas;
        }
    }
}
