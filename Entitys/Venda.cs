using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevendaDeCarros.Repository;

namespace RevendaDeCarros.Entitys
{
    public class Venda
    {
        public static int NumVendas = 0;
        public static decimal TotalVendas = 0.00m;

        /*public bool VenderCarro(Veiculo veiculo, Cliente cliente, Vendedor vendedor)
        {
            if (MetodoPagamento == "Financiamento")
            {
                if (!cliente.VerificarPagamento())
                {
                    return false;
                }
            }
            // remover carro do estoque/repositorio
            // adicionar o preco do carro no total de vendas e no total de vendas do Vendedor

            vendedor.Vendas += veiculo.Preco;
            TotalVendas += veiculo.Preco;
            NumVendas++;

            return true;
        }*/

        public static bool VenderCarro(Veiculo veiculo, Cliente cliente, Vendedor vendedor)
        {
            if (cliente.Idade < 21)
            {
                return false;
            }

            vendedor.Vendas += veiculo.Preco;
            TotalVendas = veiculo.Preco;
            NumVendas++;
            return true;
        }
    }
}