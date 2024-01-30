using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemClientes
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha o Nome!");
                DialogResult = DialogResult.None;
                txtNome.Focus();
            }
            if (!txtCpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o CPF!");
                DialogResult = DialogResult.None;
                txtCpf.Focus();
            }
            if (string.IsNullOrEmpty(txtRg.Text))
            {
                MessageBox.Show("Preencha o RG!");
                DialogResult = DialogResult.None;
                txtRg.Focus();
            }
            if (string.IsNullOrEmpty(txtInscEst.Text))
            {
                MessageBox.Show("Preencha a IE!");
                DialogResult = DialogResult.None;
                txtInscEst.Focus();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtInscEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtDataNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtInscEst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
