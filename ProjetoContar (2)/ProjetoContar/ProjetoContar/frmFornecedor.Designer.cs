namespace ProjetoContar
{
    partial class frmFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            System.Windows.Forms.Label ds_emailLabel;
            System.Windows.Forms.Label cd_ielabel6;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            this.tb_fornecedorTableAdapter1 = new ProjetoContar.BDcontasDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.bDcontasDataSet1 = new ProjetoContar.BDcontasDataSet();
            this.tb_fornecedorbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorbindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_fornecedortableAdapterManager1 = new ProjetoContar.BDcontasDataSetTableAdapters.TableAdapterManager();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.ds_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.cd_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.cd_ieTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
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
            ds_emailLabel = new System.Windows.Forms.Label();
            cd_ielabel6 = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDcontasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorbindingNavigator1)).BeginInit();
            this.tb_fornecedorbindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fornecedorTableAdapter1
            // 
            this.tb_fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // bDcontasDataSet1
            // 
            this.bDcontasDataSet1.DataSetName = "BDcontasDataSet";
            this.bDcontasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorbindingNavigator1
            // 
            this.tb_fornecedorbindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_fornecedorbindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.tb_fornecedorbindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_fornecedorbindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.tb_fornecedorbindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.tb_fornecedorbindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_fornecedorbindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_fornecedorbindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_fornecedorbindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_fornecedorbindingNavigator1.Name = "tb_fornecedorbindingNavigator1";
            this.tb_fornecedorbindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_fornecedorbindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.tb_fornecedorbindingNavigator1.TabIndex = 0;
            this.tb_fornecedorbindingNavigator1.Text = "bindingNavigator1";
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
            // tb_fornecedortableAdapterManager1
            // 
            this.tb_fornecedortableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tb_fornecedortableAdapterManager1.tb_clienteTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.tb_conta_pagarTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.tb_contapagarTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.tb_contas___pagarTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.tb_contas_receberTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter1;
            this.tb_fornecedortableAdapterManager1.tb_usuarioTableAdapter = null;
            this.tb_fornecedortableAdapterManager1.UpdateOrder = ProjetoContar.BDcontasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Location = new System.Drawing.Point(245, 332);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(57, 20);
            ds_emailLabel.TabIndex = 99;
            ds_emailLabel.Text = "E-mail:";
            // 
            // cd_ielabel6
            // 
            cd_ielabel6.AutoSize = true;
            cd_ielabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ielabel6.Location = new System.Drawing.Point(245, 307);
            cd_ielabel6.Name = "cd_ielabel6";
            cd_ielabel6.Size = new System.Drawing.Size(29, 20);
            cd_ielabel6.TabIndex = 98;
            cd_ielabel6.Text = "IE:";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(245, 282);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(53, 20);
            cd_cnpjLabel.TabIndex = 97;
            cd_cnpjLabel.Text = "CNPJ:";
            cd_cnpjLabel.Click += new System.EventHandler(this.cd_cpfLabel_Click);
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(245, 257);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(75, 20);
            ds_telefoneLabel.TabIndex = 96;
            ds_telefoneLabel.Text = "Telefone:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(245, 232);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 95;
            cd_cepLabel.Text = "CEP:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(245, 207);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_estadoLabel.TabIndex = 94;
            sg_estadoLabel.Text = "Estado:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(245, 182);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_cidadeLabel.TabIndex = 93;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(333, 182);
            this.nm_cidadeTextBox.MaxLength = 15;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_cidadeTextBox.TabIndex = 92;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_cepTextBox.Location = new System.Drawing.Point(333, 232);
            this.cd_cepTextBox.MaxLength = 8;
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(67, 21);
            this.cd_cepTextBox.TabIndex = 91;
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(333, 257);
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(140, 21);
            this.ds_telefoneTextBox.TabIndex = 90;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_bairroTextBox.Location = new System.Drawing.Point(333, 157);
            this.nm_bairroTextBox.MaxLength = 10;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_bairroTextBox.TabIndex = 89;
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(333, 281);
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_cnpjTextBox.TabIndex = 88;
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_ieTextBox.Location = new System.Drawing.Point(333, 308);
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_ieTextBox.TabIndex = 87;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ds_emailTextBox.Location = new System.Drawing.Point(333, 335);
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(140, 21);
            this.ds_emailTextBox.TabIndex = 86;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sg_estadoTextBox.Location = new System.Drawing.Point(333, 207);
            this.sg_estadoTextBox.MaxLength = 15;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(140, 21);
            this.sg_estadoTextBox.TabIndex = 85;
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(245, 57);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(63, 20);
            cd_fornecedorLabel.TabIndex = 76;
            cd_fornecedorLabel.Text = "Código:";
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_fornecedorTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(333, 57);
            this.cd_fornecedorTextBox.MaxLength = 15;
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(111, 21);
            this.cd_fornecedorTextBox.TabIndex = 77;
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(245, 82);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(55, 20);
            nm_fornecedorLabel.TabIndex = 78;
            nm_fornecedorLabel.Text = "Nome:";
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(333, 82);
            this.nm_fornecedorTextBox.MaxLength = 40;
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(291, 21);
            this.nm_fornecedorTextBox.TabIndex = 79;
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.Location = new System.Drawing.Point(245, 107);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(82, 20);
            nm_enderecoLabel.TabIndex = 80;
            nm_enderecoLabel.Text = "Endereço:";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_numeroLabel.Location = new System.Drawing.Point(245, 132);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(69, 20);
            cd_numeroLabel.TabIndex = 81;
            cd_numeroLabel.Text = "Número:";
            // 
            // nm_enderecoTextBox
            // 
            this.nm_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nm_enderecoTextBox.Location = new System.Drawing.Point(333, 107);
            this.nm_enderecoTextBox.MaxLength = 20;
            this.nm_enderecoTextBox.Name = "nm_enderecoTextBox";
            this.nm_enderecoTextBox.Size = new System.Drawing.Size(140, 21);
            this.nm_enderecoTextBox.TabIndex = 82;
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(245, 157);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 83;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cd_numeroTextBox.Location = new System.Drawing.Point(333, 132);
            this.cd_numeroTextBox.MaxLength = 13;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(140, 21);
            this.cd_numeroTextBox.TabIndex = 84;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(611, 444);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 75;
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
            this.btnImprimir.Location = new System.Drawing.Point(482, 444);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 30);
            this.btnImprimir.TabIndex = 74;
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
            this.btnPesquisar.Location = new System.Drawing.Point(353, 444);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 73;
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
            this.btnCancelar.Location = new System.Drawing.Point(224, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 72;
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
            this.btnSalvar.Location = new System.Drawing.Point(95, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 71;
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
            this.btnExcluir.Location = new System.Drawing.Point(611, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 70;
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
            this.btnAlterar.Location = new System.Drawing.Point(482, 388);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 69;
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
            this.btnNovo.Location = new System.Drawing.Point(353, 388);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 68;
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
            this.btnProximo.Location = new System.Drawing.Point(224, 388);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(100, 30);
            this.btnProximo.TabIndex = 67;
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
            this.btnAnterior.Location = new System.Drawing.Point(95, 388);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAnterior.Size = new System.Drawing.Size(100, 32);
            this.btnAnterior.TabIndex = 66;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(cd_ielabel6);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(this.ds_telefoneTextBox);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(this.cd_cnpjTextBox);
            this.Controls.Add(this.cd_ieTextBox);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
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
            this.Controls.Add(this.tb_fornecedorbindingNavigator1);
            this.Name = "frmFornecedor";
            this.Text = "frmFornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDcontasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorbindingNavigator1)).EndInit();
            this.tb_fornecedorbindingNavigator1.ResumeLayout(false);
            this.tb_fornecedorbindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDcontasDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter1;
        private BDcontasDataSet bDcontasDataSet1;
        private System.Windows.Forms.BindingSource tb_fornecedorbindingSource1;
        private System.Windows.Forms.BindingNavigator tb_fornecedorbindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private BDcontasDataSetTableAdapters.TableAdapterManager tb_fornecedortableAdapterManager1;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox ds_telefoneTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox cd_cnpjTextBox;
        private System.Windows.Forms.TextBox cd_ieTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}