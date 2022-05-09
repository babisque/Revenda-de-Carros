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
    public partial class AddClientes : Form
    {
        List<Cliente> clientes;

        public AddClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteRepository.StoreCliente(clientes, txtNome.Text, txtNascimento.Text, txtCPF.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
