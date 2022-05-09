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
    public partial class AddVendedores : Form
    {
        List<Vendedor> vendedores;

        public AddVendedores(List<Vendedor> vendedores)
        {
            InitializeComponent();
            this.vendedores = vendedores;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VendedorRepository.StoreVendedor(vendedores, txtNome.Text, Decimal.Parse(txtSalario.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Você precisa preencher todos os campos", "Atenção");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSalario.Text = "";
        }
    }
}
