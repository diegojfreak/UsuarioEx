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
    public partial class frmConsulta : FormBase
    {
        private List<Usuario> ListaDados;
        public frmConsulta(List<Usuario> lista)
        {
            InitializeComponent();

            ListaDados = lista;
            dataGridView1.DataSource = ListaDados;

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = ListaDados;
                    break;
                case 1:
                    dataGridView1.DataSource = ListaDados.FindAll(x => x.Ativo == "A");
                    break;
                case 2:
                    dataGridView1.DataSource = ListaDados.FindAll(x => x.Ativo == "I");
                    break;
            }
        }
    }
}
