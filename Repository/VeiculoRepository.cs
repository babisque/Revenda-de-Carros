using System;
using System.Collections.Generic;
using RevendaDeCarros.Entitys;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendaDeCarros.Repository
{
    public class VeiculoRepository
    {
        public static List<Veiculo> VeiculoInitiazlize()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            {
                veiculos.Add(new Veiculo("Toyota", "Corolla", 2020, "2.0", "Flex", "Cinza", 149990.00m, "MRW7291"));
                veiculos.Add(new Veiculo("Volkswagen", "Golf", 2014, "2.0 GTI", "Gasolina", "Preto", 125000.00m, "OVK7893"));
                veiculos.Add(new Veiculo("Toyota", "Supra", 1993, "3.0", "Gasolina", "Vermelho", 1280000.00m, "CSV1596"));

                return veiculos;
            }
        }

        public static void StoreVeiculo(List<Veiculo> veiculos, string marca, string modelo, int ano, string motor, string combustivel, string cor, decimal preco, string placa)
        {
            veiculos.Add(new Veiculo(marca, modelo, ano, motor, combustivel, cor, preco, placa));
        }

        public static void RemoveVeiculo(List<Veiculo> veiculos, int index)
        {
            veiculos.RemoveAt(index);
        }
    }
}
