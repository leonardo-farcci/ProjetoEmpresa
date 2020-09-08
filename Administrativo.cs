using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Administrativo : Funcionario
    {
        int horasExtras;

        public int HorasExtras
        {
            get
            {
                return this.horasExtras = HorasExtras;
            }

            set
            {
                horasExtras = value;
            }
        }

        public Administrativo() : base() { }

        public Administrativo(string nome, string rg, double salarioMensal, int horasExtras)
            : base(nome, rg, salarioMensal)
        {
            this.HorasExtras = horasExtras;
        }

        public override void imprimirSalario()
        {
            double salarioFinal = SalarioMensal + horasExtras * (SalarioMensal/100);
            horasExtras = 0;
            Console.WriteLine("Nome: " + Nome + "\nSalário: R$" + salarioFinal);
        }

        public override string ToString()
        {
            return base.ToString() + "\nHoras extras: "+horasExtras;
        }
    }
}
