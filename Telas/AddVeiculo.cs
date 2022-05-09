using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevendaDeCarros.Entitys;
using RevendaDeCarros.Repository;

namespace RevendaDeCarros.Telas
{
    public partial class AddVeiculo : Form
    {
        List<Veiculo> veiculos;

        public AddVeiculo(List<Veiculo> veiculos)
        {
            InitializeComponent();
            this.veiculos = veiculos;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int ano = int.Parse(txtAno.Text);
                string motor = txtMotor.Text;
                string combustivel = txtComb.Text;
                string cor = txtCor.Text;
                decimal preco = Decimal.Parse(txtPreco.Text);
                string placa = txtPlaca.Text;

                VeiculoRepository.StoreVeiculo(veiculos, marca, modelo, ano, motor, combustivel, cor, preco, placa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção");
            }
        }
    }
}
