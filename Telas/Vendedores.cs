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
    public partial class Vendedores : Form
    {
        List<Vendedor> vendedores;

        public Vendedores(List<Vendedor> vendedores)
        {
            InitializeComponent();
            this.vendedores = vendedores;
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            foreach (Vendedor vendedor in vendedores)
            {
                cbxVendedores.Items.Add(vendedor.Nome);
                vendedor.GetBonificacao();
            }
            btnRemover.Enabled = false;
        }

        private void cbxVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendedor vendedor = this.vendedores[cbxVendedores.SelectedIndex];
            lblNome.Text = vendedor.Nome;
            lblVendas.Text = $"R$ {vendedor.Vendas}";
            lblSalario.Text = $"R$ {vendedor.Salario}";
            lblBonificacao.Text = $"R$ {vendedor.Bonificacao}";
            lblTotal.Text = $"R$ {vendedor.Salario + vendedor.Bonificacao}";

            btnRemover.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string messagem = "Deseja mesmo remover?";
            string caption = "Confirmação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(messagem, caption, buttons);
            
            if (resultado == DialogResult.Yes)
            {
                VendedorRepository.RemoveVendedor(vendedores, cbxVendedores.SelectedIndex);
                refreshList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddVendedores addVendedor = new AddVendedores(vendedores);
            addVendedor.ShowDialog();
            refreshList();
        }

        internal void refreshList()
        {
            cbxVendedores.Items.Clear();
            foreach (Vendedor vendedor in vendedores)
            {
                cbxVendedores.Items.Add(vendedor.Nome);
            }
        }
    }
}
