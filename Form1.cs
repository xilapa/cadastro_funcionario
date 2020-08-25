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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Pesquisar()
        {
            Funcionario funcionario = new Funcionario();
            
            int matricula = 0;
            Int32.TryParse(txtbx_matricula.Text, out matricula);
            // valida se a matrícula esta vazia ou não
                        
            funcionario.Matricula = matricula;
            funcionario.Cpf = txtbx_cpf.Text;
            funcionario.Nome = "%" + txtbx_nome.Text + "%";
            // % adicionado no input do user pois ao ser adicionado os valores do objeto funcionario na query é passado o input entre aspas
            funcionario.DataNascimento = txtbx_dn.Text;
            funcionario.Endereco = txtbx_endereco.Text;


            dataGridViewFuncionarios.DataSource = funcionario.Pesquisar();
        }

        private void Salvar()
        {
            Funcionario funcionario = new Funcionario();

            int matricula = 0;
            Int32.TryParse(txtbx_matricula.Text, out matricula);
            // valida se a matrícula esta vazia ou não

            if ((String.IsNullOrEmpty(txtbx_cpf.Text)) || (String.IsNullOrEmpty(txtbx_nome.Text)) || (String.IsNullOrEmpty(txtbx_dn.Text)) || (String.IsNullOrEmpty(txtbx_endereco.Text)))
            {
                MessageBox.Show("Preencha todos os campos","Erro");
                
            }
            else
            {
                funcionario.Matricula = matricula;
                funcionario.Cpf = txtbx_cpf.Text;
                funcionario.Nome = txtbx_nome.Text;
                funcionario.DataNascimento = txtbx_dn.Text;
                funcionario.Endereco = txtbx_endereco.Text;
                funcionario.Salvar();
            }

        }

        private void Excluir()
        {
            Funcionario funcionario = new Funcionario();

            int matricula = 0;
            Int32.TryParse(txtbx_matricula.Text, out matricula);
            // valida se a matrícula esta vazia ou não

            if (matricula == 0)
            {
                MessageBox.Show("Escolha um funcionário para excluir", "Erro");

            }
            else
            {
                funcionario.Matricula = matricula;
                funcionario.Cpf = txtbx_cpf.Text;
                funcionario.Nome = txtbx_nome.Text;
                funcionario.DataNascimento = txtbx_dn.Text;
                funcionario.Endereco = txtbx_endereco.Text;
                funcionario.Excluir();
                Limpar();
                funcionario.Pesquisar();
            }
        }

        private void Limpar()
        {
            txtbx_matricula.Text = "";
            txtbx_cpf.Text = "";
            txtbx_nome.Text = "";
            txtbx_dn.Text = "";
            txtbx_endereco.Text = "";
        }

        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_matricula.Text = dataGridViewFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbx_cpf.Text = dataGridViewFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbx_nome.Text = dataGridViewFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbx_dn.Text = dataGridViewFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbx_endereco.Text = dataGridViewFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
        }


    }
}
