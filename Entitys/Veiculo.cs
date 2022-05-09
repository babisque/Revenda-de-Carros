using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevendaDeCarros.Entitys
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Motor { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }
        public string Placa { get; set; }

        public Veiculo(string marca, string modelo, int ano, string motor, string combustivel, string cor, decimal preco, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Motor = motor;
            Combustivel = combustivel;
            Cor = cor;
            Preco = preco;
            Placa = placa;
        }

        public override string ToString() => $"{Marca} {Modelo} -> R$ {Preco}";
    }
}

