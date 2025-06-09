using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccao04_Ex02_Funcionario
{
    class Funcionario
    {
        public string Name;
        public double Salary;
        public double Tax;
       


        public double Taxes()
        {
            return Salary - Tax;
        }

        public void Raise(double percentagem)
        {
            Salary = Salary + (Salary * percentagem / 100.0);

        }
        public override string ToString()
        {
            return Name + " $" + Taxes().ToString();
        }
    }
}
