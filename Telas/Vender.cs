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
    public partial class Vender : Form
    {
        List<Vendedor> vendedores;
        List<Cliente> clientes;
        List<Veiculo> veiculos;

        public Vender(List<Vendedor> vendedores, List<Cliente> clientes, List<Veiculo> veiculos)
        {
            InitializeComponent();
            this.vendedores = vendedores;
            this.clientes = clientes;
            this.veiculos = veiculos;
        }
        
        private void Vender_Load(object sender, EventArgs e)
        {
            refreshListVeiculo();

            foreach (Vendedor vendedor in vendedores)
            {
                cbxVendedor.Items.Add(vendedor.Nome);
            }

            foreach (Cliente cliente in clientes)
            {
                cbxCliente.Items.Add(cliente.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = veiculos[cbxVeiculo.SelectedIndex];
                Vendedor vendedor = vendedores[cbxVendedor.SelectedIndex];
                Cliente cliente = clientes[cbxCliente.SelectedIndex];

                Venda.VenderCarro(veiculo, cliente, vendedor);
                VeiculoRepository.RemoveVeiculo(veiculos, cbxVeiculo.SelectedIndex);
                refreshListVeiculo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção");
            }
        }

        private void refreshListVeiculo()
        {
            cbxVeiculo.Items.Clear();
            foreach (Veiculo veiculo in veiculos)
            {
                cbxVeiculo.Items.Add(veiculo);
            }
        }
    }
}
