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
    public partial class frmCliente : Form
    {
        private void Habilita()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            nm_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
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
        private void Desabilita()
        {
            cd_clienteTextBox.Enabled = true;
            nm_clienteTextBox.Enabled = false;
            nm_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
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
        public partial class fmr : Form
        {

            

            private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void nm_usuarioTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void sg_nivelTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void nm_loginTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void cd_senhaTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnAnterior_Click(object sender, EventArgs e)
            {

            }

            private void btnProximo_Click(object sender, EventArgs e)
            {

            }

            private void btnNovo_Click(object sender, EventArgs e)
            {

            }

            private void btnAlterar_Click(object sender, EventArgs e)
            {

            }

            private void btnExcluir_Click(object sender, EventArgs e)
            {

            }

            private void btnSalvar_Click(object sender, EventArgs e)
            {

            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {

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

            private void frmCliente_Load(object sender, EventArgs e)
            {

            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label ds_emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.cd_rgTextBox = new System.Windows.Forms.TextBox();
            this.cd_cpfTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.ds_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.tb_clienteTableAdapter1 = new ProjetoContar.BDcontasDataSetTableAdapters.tb_clienteTableAdapter();
            this.tb_clientetableAdapterManager1 = new ProjetoContar.BDcontasDataSetTableAdapters.TableAdapterManager();
            this.bDcontasDataSet1 = new ProjetoContar.BDcontasDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDcontasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingNavigator)).BeginInit();
            this.tb_clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clienteLabel.Location = new System.Drawing.Point(284, 37);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(63, 20);
            cd_clienteLabel.TabIndex = 40;
            cd_clienteLabel.Text = "Código:";
            cd_clienteLabel.Click += new System.EventHandler(this.cd_clienteLabel_Click);
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_clienteTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cd_clienteTextBox.Location = new System.Drawing.Point(372, 37);
            this.cd_clienteTextBox.MaxLength = 15;
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(111, 21);
            this.cd_clienteTextBox.TabIndex = 41;
            this.cd_clienteTextBox.TextChanged += new System.EventHandler(this.cd_clienteTextBox_TextChanged);
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_clienteLabel.Location = new System.Drawing.Point(284, 62);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(55, 20);
            nm_clienteLabel.TabIndex = 42;
            nm_clienteLabel.Text = "Nome:";
            nm_clienteLabel.Click += new System.EventHandler(this.nm_clienteLabel_Click);
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_clienteTextBox.Location = new System.Drawing.Point(372, 62);
            this.nm_clienteTextBox.MaxLength = 40;
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(291, 21);
            this.nm_clienteTextBox.TabIndex = 43;
            this.nm_clienteTextBox.TextChanged += new System.EventHandler(this.nm_clienteTextBox_TextChanged);
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.Location = new System.Drawing.Point(284, 87);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(82, 20);
            nm_enderecoLabel.TabIndex = 44;
            nm_enderecoLabel.Text = "Endereço:";
            nm_enderecoLabel.Click += new System.EventHandler(this.nm_enderecoLabel_Click);
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_numeroLabel.Location = new System.Drawing.Point(284, 112);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(69, 20);
            cd_numeroLabel.TabIndex = 46;
            cd_numeroLabel.Text = "Número:";
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(372, 87);
            this.nm_enderecoTextBox.MaxLength = 20;
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_enderecoTextBox.TabIndex = 47;
            this.nm_enderecoTextBox.TextChanged += new System.EventHandler(this.cd_numeroTextBox_TextChanged);
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(284, 137);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 48;
            nm_bairroLabel.Text = "Bairro:";
            nm_bairroLabel.Click += new System.EventHandler(this.nm_bairroLabel_Click);
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_numeroTextBox.Location = new System.Drawing.Point(372, 112);
            this.cd_numeroTextBox.MaxLength = 13;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_numeroTextBox.TabIndex = 49;
            this.cd_numeroTextBox.TextChanged += new System.EventHandler(this.nm_bairoTextBox_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(650, 424);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 39;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(521, 424);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(392, 424);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 37;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(263, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(134, 424);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(650, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(521, 368);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(392, 368);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 32;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(263, 368);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(100, 30);
            this.btnProximo.TabIndex = 31;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(134, 368);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnterior.Size = new System.Drawing.Size(100, 32);
            this.btnAnterior.TabIndex = 30;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sg_estadoTextBox.Location = new System.Drawing.Point(372, 187);
            this.sg_estadoTextBox.MaxLength = 15;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(140, 21);
            this.sg_estadoTextBox.TabIndex = 51;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ds_emailTextBox.Location = new System.Drawing.Point(372, 315);
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(140, 21);
            this.ds_emailTextBox.TabIndex = 52;
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_rgTextBox.Location = new System.Drawing.Point(372, 288);
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_rgTextBox.TabIndex = 53;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_cpfTextBox.Location = new System.Drawing.Point(372, 261);
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_cpfTextBox.TabIndex = 54;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_bairroTextBox.Location = new System.Drawing.Point(372, 137);
            this.nm_bairroTextBox.MaxLength = 10;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_bairroTextBox.TabIndex = 55;
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(372, 237);
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(140, 21);
            this.ds_telefoneTextBox.TabIndex = 56;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_cepTextBox.Location = new System.Drawing.Point(372, 212);
            this.cd_cepTextBox.MaxLength = 8;
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(67, 21);
            this.cd_cepTextBox.TabIndex = 57;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(372, 162);
            this.nm_cidadeTextBox.MaxLength = 15;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_cidadeTextBox.TabIndex = 58;
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(284, 162);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_cidadeLabel.TabIndex = 59;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(284, 187);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_estadoLabel.TabIndex = 60;
            sg_estadoLabel.Text = "Estado:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(284, 212);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 61;
            cd_cepLabel.Text = "CEP:";
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(284, 237);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(75, 20);
            ds_telefoneLabel.TabIndex = 62;
            ds_telefoneLabel.Text = "Telefone:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Location = new System.Drawing.Point(284, 262);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(44, 20);
            cd_cpfLabel.TabIndex = 63;
            cd_cpfLabel.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(284, 287);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 20);
            label6.TabIndex = 64;
            label6.Text = "RG:";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Location = new System.Drawing.Point(284, 312);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(57, 20);
            ds_emailLabel.TabIndex = 65;
            ds_emailLabel.Text = "E-mail:";
            // 
            // tb_clienteTableAdapter1
            // 
            this.tb_clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // tb_clientetableAdapterManager1
            // 
            this.tb_clientetableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tb_clientetableAdapterManager1.tb_clienteTableAdapter = this.tb_clienteTableAdapter1;
            this.tb_clientetableAdapterManager1.tb_conta_pagarTableAdapter = null;
            this.tb_clientetableAdapterManager1.tb_contapagarTableAdapter = null;
            this.tb_clientetableAdapterManager1.tb_contas___pagarTableAdapter = null;
            this.tb_clientetableAdapterManager1.tb_contas_receberTableAdapter = null;
            this.tb_clientetableAdapterManager1.tb_fornecedorTableAdapter = null;
            this.tb_clientetableAdapterManager1.tb_usuarioTableAdapter = null;
            this.tb_clientetableAdapterManager1.UpdateOrder = ProjetoContar.BDcontasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bDcontasDataSet1
            // 
            this.bDcontasDataSet1.DataSetName = "BDcontasDataSet";
            this.bDcontasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.bDcontasDataSet1;
            // 
            // tb_clienteBindingNavigator
            // 
            this.tb_clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_clienteBindingNavigator.BindingSource = this.tb_clienteBindingSource;
            this.tb_clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_clienteBindingNavigatorSaveItem});
            this.tb_clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_clienteBindingNavigator.Name = "tb_clienteBindingNavigator";
            this.tb_clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_clienteBindingNavigator.Size = new System.Drawing.Size(910, 25);
            this.tb_clienteBindingNavigator.TabIndex = 66;
            this.tb_clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_clienteBindingNavigatorSaveItem
            // 
            this.tb_clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_clienteBindingNavigatorSaveItem.Image")));
            this.tb_clienteBindingNavigatorSaveItem.Name = "tb_clienteBindingNavigatorSaveItem";
            this.tb_clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_clienteBindingNavigatorSaveItem_Click);
            // 
            // frmCliente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(910, 498);
            this.Controls.Add(this.tb_clienteBindingNavigator);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(label6);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(this.ds_telefoneTextBox);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(this.cd_rgTextBox);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(nm_enderecoLabel);
            this.Controls.Add(cd_numeroLabel);
            this.Controls.Add(this.nm_enderecoTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.cd_numeroTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmCliente";
            this.Text = "41";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDcontasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingNavigator)).EndInit();
            this.tb_clienteBindingNavigator.ResumeLayout(false);
            this.tb_clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox cd_clienteTextBox;
        private TextBox nm_clienteTextBox;
        private TextBox nm_enderecoTextBox;
        private TextBox cd_numeroTextBox;
        private Button btnSair;
        private Button btnImprimir;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnNovo;
        private Button btnProximo;
        private Button btnAnterior;

        private void cd_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_bairoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private TextBox sg_estadoTextBox;
        private TextBox ds_emailTextBox;
        private TextBox cd_rgTextBox;
        private TextBox cd_cpfTextBox;
        private TextBox nm_bairroTextBox;
        private TextBox ds_telefoneTextBox;
        private TextBox cd_cepTextBox;
        private TextBox nm_cidadeTextBox;

        private void cd_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nm_bairroLabel_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void nm_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private BDcontasDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter1;
        private BDcontasDataSetTableAdapters.TableAdapterManager tb_clientetableAdapterManager1;
        private BDcontasDataSet bDcontasDataSet1;

        private void btnAnterior_Click(object sender, EventArgs e)
        {
           tb_clienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.RemoveCurrent();
            tb_clienteTableAdapter1.Update(bDcontasDataSet1.tb_cliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_clienteBindingSource.EndEdit();
            tb_clienteTableAdapter1.Update(bDcontasDataSet1.tb_cliente);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_clienteBindingSource.CancelEdit();
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

        private BindingSource tb_clienteBindingSource;
        private IContainer components;
        private BindingNavigator tb_clienteBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton tb_clienteBindingNavigatorSaveItem;

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tb_clientetableAdapterManager1.UpdateAll(this.bDcontasDataSet1);

        }
    }
}

