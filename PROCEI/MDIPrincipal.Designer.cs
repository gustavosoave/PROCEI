namespace PROCEI
{
    partial class MDIPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastrarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastrarFotos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnCadastrarSKU = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdicionarItensSKU = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastrarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGerarPicking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRastreadorEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRegistrarEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAvaliarFeedbacks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGerenciarProblemasPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelProdutosMaisVisualizados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelProdutosMaisComprados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelProdutosMelhoresAvaliacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelItensVolumeMinimo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelItensAcimaVolumeMaximo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelInventarioEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelValorMedioCompraCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelCategoriasMaisCompradas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRelCategoriasMenosCompradas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnEstoque,
            this.mnPedidos,
            this.mnRelatorios});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnProdutos
            // 
            this.mnProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastrarProdutos,
            this.mnCadastrarCategorias,
            this.mnCadastrarFotos});
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(67, 20);
            this.mnProdutos.Text = "Produtos";
            // 
            // mnCadastrarProdutos
            // 
            this.mnCadastrarProdutos.Name = "mnCadastrarProdutos";
            this.mnCadastrarProdutos.Size = new System.Drawing.Size(227, 22);
            this.mnCadastrarProdutos.Text = "Cadastrar / Alterar produtos";
            // 
            // mnCadastrarCategorias
            // 
            this.mnCadastrarCategorias.Name = "mnCadastrarCategorias";
            this.mnCadastrarCategorias.Size = new System.Drawing.Size(227, 22);
            this.mnCadastrarCategorias.Text = "Cadastrar / Alterar categorias";
            // 
            // mnCadastrarFotos
            // 
            this.mnCadastrarFotos.Name = "mnCadastrarFotos";
            this.mnCadastrarFotos.Size = new System.Drawing.Size(227, 22);
            this.mnCadastrarFotos.Text = "Cadastrar / Alterar fotos";
            // 
            // mnEstoque
            // 
            this.mnEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastrarSKU,
            this.mnAdicionarItensSKU});
            this.mnEstoque.Name = "mnEstoque";
            this.mnEstoque.Size = new System.Drawing.Size(61, 20);
            this.mnEstoque.Text = "Estoque";
            // 
            // mnPedidos
            // 
            this.mnPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastrarPedidos,
            this.mnGerarPicking,
            this.mnRastreadorEntrega,
            this.mnRegistrarEntrega,
            this.mnAvaliarFeedbacks,
            this.mnGerenciarProblemasPedidos});
            this.mnPedidos.Name = "mnPedidos";
            this.mnPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnPedidos.Text = "Pedidos";
            // 
            // mnRelatorios
            // 
            this.mnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelProdutos,
            this.mnRelEstoque,
            this.mnRelPedidos});
            this.mnRelatorios.Name = "mnRelatorios";
            this.mnRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnRelatorios.Text = "Relatórios";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mnCadastrarSKU
            // 
            this.mnCadastrarSKU.Name = "mnCadastrarSKU";
            this.mnCadastrarSKU.Size = new System.Drawing.Size(194, 22);
            this.mnCadastrarSKU.Text = "Cadastrar / Alterar SKU";
            // 
            // mnAdicionarItensSKU
            // 
            this.mnAdicionarItensSKU.Name = "mnAdicionarItensSKU";
            this.mnAdicionarItensSKU.Size = new System.Drawing.Size(194, 22);
            this.mnAdicionarItensSKU.Text = "Adicionar itens SKU";
            // 
            // mnCadastrarPedidos
            // 
            this.mnCadastrarPedidos.Name = "mnCadastrarPedidos";
            this.mnCadastrarPedidos.Size = new System.Drawing.Size(326, 22);
            this.mnCadastrarPedidos.Text = "Consultar / Alterar pedidos";
            // 
            // mnGerarPicking
            // 
            this.mnGerarPicking.Name = "mnGerarPicking";
            this.mnGerarPicking.Size = new System.Drawing.Size(326, 22);
            this.mnGerarPicking.Text = "Gerar guia de picking";
            // 
            // mnRastreadorEntrega
            // 
            this.mnRastreadorEntrega.Name = "mnRastreadorEntrega";
            this.mnRastreadorEntrega.Size = new System.Drawing.Size(326, 22);
            this.mnRastreadorEntrega.Text = "Adcionar rastreador entrega";
            // 
            // mnRegistrarEntrega
            // 
            this.mnRegistrarEntrega.Name = "mnRegistrarEntrega";
            this.mnRegistrarEntrega.Size = new System.Drawing.Size(326, 22);
            this.mnRegistrarEntrega.Text = "Registrar entrega pedido";
            // 
            // mnAvaliarFeedbacks
            // 
            this.mnAvaliarFeedbacks.Name = "mnAvaliarFeedbacks";
            this.mnAvaliarFeedbacks.Size = new System.Drawing.Size(326, 22);
            this.mnAvaliarFeedbacks.Text = "Avaliar feedbacks site";
            // 
            // mnGerenciarProblemasPedidos
            // 
            this.mnGerenciarProblemasPedidos.Name = "mnGerenciarProblemasPedidos";
            this.mnGerenciarProblemasPedidos.Size = new System.Drawing.Size(326, 22);
            this.mnGerenciarProblemasPedidos.Text = "Gerencia de pedidos com problemas de entrega";
            // 
            // mnRelProdutos
            // 
            this.mnRelProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelProdutosMaisVisualizados,
            this.mnRelProdutosMaisComprados,
            this.mnRelProdutosMelhoresAvaliacoes});
            this.mnRelProdutos.Name = "mnRelProdutos";
            this.mnRelProdutos.Size = new System.Drawing.Size(152, 22);
            this.mnRelProdutos.Text = "Produtos";
            // 
            // mnRelEstoque
            // 
            this.mnRelEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelItensVolumeMinimo,
            this.mnRelItensAcimaVolumeMaximo,
            this.mnRelInventarioEstoque});
            this.mnRelEstoque.Name = "mnRelEstoque";
            this.mnRelEstoque.Size = new System.Drawing.Size(152, 22);
            this.mnRelEstoque.Text = "Estoque";
            // 
            // mnRelPedidos
            // 
            this.mnRelPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnRelValorMedioCompraCategoria,
            this.mnRelCategoriasMaisCompradas,
            this.mnRelCategoriasMenosCompradas});
            this.mnRelPedidos.Name = "mnRelPedidos";
            this.mnRelPedidos.Size = new System.Drawing.Size(152, 22);
            this.mnRelPedidos.Text = "Pedidos";
            // 
            // mnRelProdutosMaisVisualizados
            // 
            this.mnRelProdutosMaisVisualizados.Name = "mnRelProdutosMaisVisualizados";
            this.mnRelProdutosMaisVisualizados.Size = new System.Drawing.Size(258, 22);
            this.mnRelProdutosMaisVisualizados.Text = "Produtos mais visualizados";
            // 
            // mnRelProdutosMaisComprados
            // 
            this.mnRelProdutosMaisComprados.Name = "mnRelProdutosMaisComprados";
            this.mnRelProdutosMaisComprados.Size = new System.Drawing.Size(258, 22);
            this.mnRelProdutosMaisComprados.Text = "Produtos mais comprados";
            // 
            // mnRelProdutosMelhoresAvaliacoes
            // 
            this.mnRelProdutosMelhoresAvaliacoes.Name = "mnRelProdutosMelhoresAvaliacoes";
            this.mnRelProdutosMelhoresAvaliacoes.Size = new System.Drawing.Size(258, 22);
            this.mnRelProdutosMelhoresAvaliacoes.Text = "Produtos com melhores avaliações";
            // 
            // mnRelItensVolumeMinimo
            // 
            this.mnRelItensVolumeMinimo.Name = "mnRelItensVolumeMinimo";
            this.mnRelItensVolumeMinimo.Size = new System.Drawing.Size(255, 22);
            this.mnRelItensVolumeMinimo.Text = "Itens próximos ao volume minimo";
            // 
            // mnRelItensAcimaVolumeMaximo
            // 
            this.mnRelItensAcimaVolumeMaximo.Name = "mnRelItensAcimaVolumeMaximo";
            this.mnRelItensAcimaVolumeMaximo.Size = new System.Drawing.Size(255, 22);
            this.mnRelItensAcimaVolumeMaximo.Text = "Itens acima do volume máximo";
            // 
            // mnRelInventarioEstoque
            // 
            this.mnRelInventarioEstoque.Name = "mnRelInventarioEstoque";
            this.mnRelInventarioEstoque.Size = new System.Drawing.Size(255, 22);
            this.mnRelInventarioEstoque.Text = "Inventário de Estoque";
            // 
            // mnRelValorMedioCompraCategoria
            // 
            this.mnRelValorMedioCompraCategoria.Name = "mnRelValorMedioCompraCategoria";
            this.mnRelValorMedioCompraCategoria.Size = new System.Drawing.Size(271, 22);
            this.mnRelValorMedioCompraCategoria.Text = "Valor médio de compra por categoria";
            // 
            // mnRelCategoriasMaisCompradas
            // 
            this.mnRelCategoriasMaisCompradas.Name = "mnRelCategoriasMaisCompradas";
            this.mnRelCategoriasMaisCompradas.Size = new System.Drawing.Size(271, 22);
            this.mnRelCategoriasMaisCompradas.Text = "Categorias mais compradas";
            // 
            // mnRelCategoriasMenosCompradas
            // 
            this.mnRelCategoriasMenosCompradas.Name = "mnRelCategoriasMenosCompradas";
            this.mnRelCategoriasMenosCompradas.Size = new System.Drawing.Size(271, 22);
            this.mnRelCategoriasMenosCompradas.Text = "Categorias menos compradas";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "..::  P R O C E I  ::..";
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrarCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrarFotos;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrarSKU;
        private System.Windows.Forms.ToolStripMenuItem mnAdicionarItensSKU;
        private System.Windows.Forms.ToolStripMenuItem mnCadastrarPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnGerarPicking;
        private System.Windows.Forms.ToolStripMenuItem mnRastreadorEntrega;
        private System.Windows.Forms.ToolStripMenuItem mnRegistrarEntrega;
        private System.Windows.Forms.ToolStripMenuItem mnAvaliarFeedbacks;
        private System.Windows.Forms.ToolStripMenuItem mnGerenciarProblemasPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnRelProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnRelEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnRelPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnRelProdutosMaisVisualizados;
        private System.Windows.Forms.ToolStripMenuItem mnRelProdutosMaisComprados;
        private System.Windows.Forms.ToolStripMenuItem mnRelProdutosMelhoresAvaliacoes;
        private System.Windows.Forms.ToolStripMenuItem mnRelItensVolumeMinimo;
        private System.Windows.Forms.ToolStripMenuItem mnRelItensAcimaVolumeMaximo;
        private System.Windows.Forms.ToolStripMenuItem mnRelInventarioEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnRelValorMedioCompraCategoria;
        private System.Windows.Forms.ToolStripMenuItem mnRelCategoriasMaisCompradas;
        private System.Windows.Forms.ToolStripMenuItem mnRelCategoriasMenosCompradas;
    }
}



