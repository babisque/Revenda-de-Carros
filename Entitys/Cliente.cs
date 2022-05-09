using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RevendaDeCarros.Entitys
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome, string dataNascimento, string cpf)
        {
            Nome = nome;
            Nascimento = dataNascimento;
            CPF = cpf;
            Idade = IdadeCalculator();
        }

        private int IdadeCalculator()
        {
            CultureInfo cultura = CultureInfo.CreateSpecificCulture("pt-BR");
            DateTime dataAual = DateTime.Now;
            DateTime nascimento = DateTime.Parse(Nascimento, cultura);
            decimal diasDiff = (dataAual.Date - nascimento.Date).Days;
            decimal anos = Math.Floor(diasDiff / 365.2m);

            return Decimal.ToInt32(anos);
        }

        public bool VerificarPagamento()
        {
            if (Idade <= 21)
            {
                return false;
            }

            return true;
        }
    }
}
