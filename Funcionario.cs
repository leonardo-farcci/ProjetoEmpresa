using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Funcionario
    {
        string nome;
        string rg;
        double salarioMensal;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public double SalarioMensal
        {
            get
            {
                return salarioMensal;
            }

            set
            {
                salarioMensal = value;
            }
        }

        public Funcionario() { }

        public Funcionario(string nome, string rg, double salarioMensal)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.SalarioMensal = salarioMensal;
        }
        
        public virtual void imprimirSalario()
        {
            Console.WriteLine("Nome: " + Nome + "\nSalario: R$" + SalarioMensal);
        }

        public override string ToString()
        {
            return "\nNome: "+ Nome + "\nRG: "+ Rg + "\nSalário: R$"+SalarioMensal;
        }
    }
}
