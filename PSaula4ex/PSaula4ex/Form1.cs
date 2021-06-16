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
    public partial class frmEscolha : FormBase
    {

        private List<Usuario> dados = new List<Usuario>();
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();

            if(cadastro != null)
            {
                dados.Add(cadastro.UsuarioInserido);
                MessageBox.Show("Usuario inserido com sucesso!", "" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(dados);
            consulta.ShowDialog();


        }
    }
}
