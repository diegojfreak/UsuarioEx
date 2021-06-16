using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSaula4ex
{
    public partial class frmCadastro : Form
    {
        public Usuario UsuarioInserido = null;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool erros = false;

            if(txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, "Campo obrigatorio");
                erros = true;
            }

            if(txtSenha.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSenha, "Campo obrigatorio");
                erros = true;
            }

            if(rdoAtivo.Checked == false && rdoInativo.Checked == false)
            {
                errorProvider1.SetError(rdoInativo, "Campo obrigatorio");
                erros = true;
            }

            if(erros == false)
            {
                //Cadastro
                Usuario user = new Usuario();
                
                user.Nome = txtNome.Text.Trim();

                user.Senha = txtSenha.Text.Trim();

                if(rdoAtivo.Checked == true)
                {
                    user.Ativo = "A";
                }

                if(rdoInativo.Checked == true)
                {
                    user.Ativo = "I";
                }

                UsuarioInserido = user;

                MessageBox.Show("Usuario Cadastrado!");
            }
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioInserido == null)
            {
                if (MessageBox.Show("Deseja fechar?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
