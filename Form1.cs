using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario
{
    public partial class cad_func : Form
    {
        public cad_func()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            Funcionario funcionario = new Funcionario();
            
            int matricula = 0;
            bool n = Int32.TryParse(txtbx_matricula.Text, out matricula);
                        
            funcionario.Matricula = matricula;
            funcionario.Cpf = txtbx_cpf.Text;
            funcionario.Nome = txtbx_nome.Text;
            funcionario.DataNascimento = txtbx_dn.Text;

            dataGridView1.DataSource = funcionario.Pesquisar();



        }
    }
}
