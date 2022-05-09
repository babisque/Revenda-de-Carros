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
    public partial class Clientes : Form
    {
        List<Cliente> clientes;
        public Clientes(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            refreshList();
            btnRemove.Enabled = false;
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = this.clientes[cbxClientes.SelectedIndex];
            lblNome.Text = cliente.Nome;
            lblNascimento.Text = cliente.Nascimento;
            lblCPF.Text = cliente.CPF;

            btnRemove.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddClientes addClientes = new AddClientes(clientes);
            addClientes.ShowDialog();
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
                ClienteRepository.RemoveCliente(clientes, cbxClientes.SelectedIndex);
                refreshList();
            }
        }

        private void refreshList()
        {
            cbxClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                cbxClientes.Items.Add(cliente.Nome);
            }
        }
    }
}
