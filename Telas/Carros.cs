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
    public partial class Carros : Form
    {
        List<Veiculo> veiculos;

        public Carros(List<Veiculo> veiculos)
        {
            InitializeComponent();
            this.veiculos = veiculos;
            btnRemove.Enabled = false;
        }

        private void Carros_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void cbxVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Veiculo veiculo = veiculos[cbxVeiculos.SelectedIndex];
            lblMarca.Text = veiculo.Marca;
            lblModelo.Text = veiculo.Modelo;
            lblAno.Text = veiculo.Ano.ToString();
            lblMotor.Text = veiculo.Motor;
            lblCombust.Text = veiculo.Combustivel;
            lblCor.Text = veiculo.Cor;
            lblPreco.Text = $"R$ {veiculo.Preco}";
            lblPlaca.Text = veiculo.Placa;

            btnRemove.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddVeiculo addVeiculo = new AddVeiculo(veiculos);
            addVeiculo.ShowDialog();
            refreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string messagem = "Deseja mesmo remover?";
            string caption = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(messagem, caption, buttons);

            if (resultado == DialogResult.Yes)
            {
                VeiculoRepository.RemoveVeiculo(veiculos, cbxVeiculos.SelectedIndex);
                refreshList();
            }
        }

        private void refreshList()
        {
            cbxVeiculos.Items.Clear();
            foreach (Veiculo veiculo in veiculos)
            {
                cbxVeiculos.Items.Add(veiculo);
            }
        }
    }
}
