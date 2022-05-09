using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendaDeCarros.Entitys
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonificacao { get; set; }
        public decimal Vendas { get; set; }

        public Vendedor(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public void GetBonificacao()
        {
            Bonificacao = Vendas * 0.01m;
        }
    }
}