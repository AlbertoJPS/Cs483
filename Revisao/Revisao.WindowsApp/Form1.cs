using Revisao.Domain.Entities;
using Revisao.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao.WindowsApp
{
    public partial class Form1 : Form
    {
        PessoaFisicaRepository repositorio = new PessoaFisicaRepository();
        public Form1()
        {
            InitializeComponent();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            dvgPessoas.DataSource = repositorio.ListAll();
        }


        private void Limpar()
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
        }
      
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.Nome = txtNome.Text;
            pessoaFisica.CPF = txtCpf.Text;
            repositorio.Insert(pessoaFisica);
            this.Limpar();
            CarregarGrid();
        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            this.Limpar();
        }
    }
}
