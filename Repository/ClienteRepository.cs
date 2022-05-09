using System;
using System.Collections.Generic;
using RevendaDeCarros.Entitys;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendaDeCarros.Repository
{
    public class ClienteRepository
    {
        public static List<Cliente> ClienteInitialize()
        {
            List<Cliente> clientes = new List<Cliente>();
            {
                clientes.Add(new Cliente("Rodrigo Babisque", "25/01/2000", "123.456.789-15"));
                clientes.Add(new Cliente("Edson Babisque", "22/06/1971", "326.159.487-01"));
                clientes.Add(new Cliente("Giovana Ramos", "01/02/1978", "784.951.623-10"));

                return clientes;
            }
        }

        public static void StoreCliente(List<Cliente> clientes, string nome, string dataNascimento, string cpf)
        {
            clientes.Add(new Cliente(nome, dataNascimento, cpf));
        }

        public static void RemoveCliente(List<Cliente> clientes, int index)
        {
            clientes.RemoveAt(index);
        }
    }
}
