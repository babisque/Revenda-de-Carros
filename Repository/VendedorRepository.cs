using System;
using System.Collections.Generic;
using System.Linq;
using RevendaDeCarros.Entitys;
using System.Text;
using System.Threading.Tasks;

namespace RevendaDeCarros.Repository
{
    public class VendedorRepository
    {
        public static List<Vendedor> InitializeVendedor()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            {
                vendedores.Add(new Vendedor("Pietro Bazoni", 2100));
                vendedores.Add(new Vendedor("José Júnior", 2100));

                return vendedores;
            }
        }

        public static void StoreVendedor(List<Vendedor> vendedores, string nome, decimal salario)
        {
            vendedores.Add(new Vendedor(nome, salario));
        }

        public static void RemoveVendedor(List<Vendedor> vendedores, int index)
        {
            vendedores.RemoveAt(index);
        }        
    }
}
