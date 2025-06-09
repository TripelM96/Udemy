using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produto_OOP
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Quantaty;

        public double ValorEmStock()
        {
            return Price * Quantaty; 
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantaty += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantaty -= quantidade;
        }

        public override string ToString()
        {
            return Name 
                + ", $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + "; " 
                + Quantaty 
                + "unidade, Total: $" 
                + ValorEmStock().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}
