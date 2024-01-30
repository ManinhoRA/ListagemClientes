using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemClientes
{    
    public partial class frmPrincipal : Form
    {
        private List<string> ListaClientes = new List<string>();

        public frmPrincipal()
        {
            InitializeComponent();                       
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCad = new frmCadastroCliente();

            var dResult = frmCad.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                cliente.NomeCliente = frmCad.txtNome.Text;
                cliente.Cpf = frmCad.txtCpf.Text;
                cliente.Rg = Convert.ToInt64(frmCad.txtRg.Text);
                cliente.InscricaoEst = frmCad.txtInscEst.Text;
                cliente.EstadoCivil = frmCad.cmbEstCiv.Text;
                cliente.DataNascimento = DateTime.Parse(frmCad.txtDataNasc.Text);
                cliente.Uf = frmCad.txtUf.Text;
                cliente.Cidade = frmCad.txtCidade.Text;

                ListaClientes.Add(item: cliente.NomeCliente);
                ListaClientes.Add(item: cliente.Cpf.ToString());
                ListaClientes.Add(item: cliente.Rg.ToString());
                ListaClientes.Add(item: cliente.InscricaoEst.ToString());
                ListaClientes.Add(item: cliente.Cidade.ToString());
                ListaClientes.Add(item: cliente.EstadoCivil.ToString());
                ListaClientes.Add(item: cliente.DataNascimento.ToString("dd/MM/yyyy"));
                ListaClientes.Add(item: cliente.Uf.ToString());                

                foreach (string ListaClientes in ListaClientes)
                    lstResultado.Items.Add(ListaClientes);
            }           
        }
    }
}
