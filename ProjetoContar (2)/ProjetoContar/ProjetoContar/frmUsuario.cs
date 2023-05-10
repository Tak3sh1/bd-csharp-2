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
    public partial class frmUsuario : Form
    {
        private void HabilitaEdicao()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairoTextBox.Enabled = true;
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
        private void DesabilitaEdicao()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairoTextBox.Enabled = false;
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
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.tb_usuarioTableAdapter.Fill(this.bDcontasDataSet.tb_usuario);
            DesabilitaEdicao();
        }

        private void Cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sg_nivelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nm_loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cd_usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tb_usuarioBindingSource.EndEdit();
            tb_usuarioTableAdapter.Update(bDcontasDataSet.tb_usuario);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tb_usuarioBindingSource.CancelEdit();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.MoveNext();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tb_usuarioBindingSource.RemoveCurrent();
            tb_usuarioTableAdapter.Update(bDcontasDataSet.tb_usuario);
        }

        private void Cd_senhaTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cd_usuarioTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void nm_usuarioTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
