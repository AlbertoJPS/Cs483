using Revisao.Domain.Entities;
using Revisao.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Revisao.WebForms
{
    public partial class Pessoa : System.Web.UI.Page
    {
        PessoaFisicaRepository repositorio = new PessoaFisicaRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvPessoa.DataSource = repositorio.ListAll();
            dgvPessoa.DataBind();
        }

        private void Limpar()
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            PessoaFisica p = new PessoaFisica();
            p.Nome = txtNome.Text;
            p.CPF = txtCpf.Text;
            repositorio.Insert(p);
            this.Limpar();
            this.CarregarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }
    }
}
