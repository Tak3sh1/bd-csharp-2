using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContar
{
    public partial class frmFornecedor : Form
    {
        private void Habilita1()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }
        private void Desabilita1()
        {
            cd_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void cd_cpfLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorbindingSource1.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorbindingSource1.MoveNext();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_fornecedorbindingSource1.AddNew();
            Habilita1();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita1();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_fornecedorbindingSource1.RemoveCurrent();
            tb_fornecedorTableAdapter1.Update(bDcontasDataSet1.tb_fornecedor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita1();
            Validate();
            tb_fornecedorbindingSource1.EndEdit();
            tb_fornecedorTableAdapter1.Update(bDcontasDataSet1.tb_fornecedor);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita1();
            tb_fornecedorbindingSource1.CancelEdit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
