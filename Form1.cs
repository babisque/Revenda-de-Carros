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
using RevendaDeCarros.Telas;

namespace RevendaDeCarros
{
    public partial class Menu : Form
    {
        List<Vendedor> vendedores = VendedorRepository.InitializeVendedor();
        List<Cliente> clientes = ClienteRepository.ClienteInitialize();
        List<Veiculo> veiculos = VeiculoRepository.VeiculoInitiazlize();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Vendedores vendedoresTela = new Vendedores(vendedores);
            vendedoresTela.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes clientesTela = new Clientes(clientes);
            clientesTela.ShowDialog();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carros carrosTela = new Carros(veiculos);
            carrosTela.ShowDialog();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vender venderTela = new Vender(vendedores, clientes, veiculos);
            venderTela.ShowDialog();

        }
    }
}
