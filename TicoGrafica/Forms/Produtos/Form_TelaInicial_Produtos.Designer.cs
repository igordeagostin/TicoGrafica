namespace TicoGrafica.Forms.Forms.Produtos
{
    partial class Form_TelaInicial_Produtos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelPessoas = new System.Windows.Forms.Panel();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.panelBotoesPessoas = new System.Windows.Forms.Panel();
            this.buttonExcluirProduto = new System.Windows.Forms.Button();
            this.buttonAlterarProduto = new System.Windows.Forms.Button();
            this.buttonCadastrarProduto = new System.Windows.Forms.Button();
            this.panelPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.panelBotoesPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPessoas
            // 
            this.panelPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoas.Controls.Add(this.dataGridViewProdutos);
            this.panelPessoas.Controls.Add(this.panelBotoesPessoas);
            this.panelPessoas.Location = new System.Drawing.Point(-1, -1);
            this.panelPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoas.Name = "panelPessoas";
            this.panelPessoas.Size = new System.Drawing.Size(1146, 741);
            this.panelPessoas.TabIndex = 3;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(8, 59);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(1135, 679);
            this.dataGridViewProdutos.TabIndex = 1;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            this.dataGridViewProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdutos_KeyPress);
            // 
            // panelBotoesPessoas
            // 
            this.panelBotoesPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoesPessoas.Controls.Add(this.buttonExcluirProduto);
            this.panelBotoesPessoas.Controls.Add(this.buttonAlterarProduto);
            this.panelBotoesPessoas.Controls.Add(this.buttonCadastrarProduto);
            this.panelBotoesPessoas.Location = new System.Drawing.Point(3, 3);
            this.panelBotoesPessoas.Name = "panelBotoesPessoas";
            this.panelBotoesPessoas.Size = new System.Drawing.Size(2236, 54);
            this.panelBotoesPessoas.TabIndex = 0;
            // 
            // buttonExcluirProduto
            // 
            this.buttonExcluirProduto.Location = new System.Drawing.Point(192, 4);
            this.buttonExcluirProduto.Name = "buttonExcluirProduto";
            this.buttonExcluirProduto.Size = new System.Drawing.Size(88, 45);
            this.buttonExcluirProduto.TabIndex = 2;
            this.buttonExcluirProduto.Text = "EXCLUIR";
            this.buttonExcluirProduto.UseVisualStyleBackColor = true;
            this.buttonExcluirProduto.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterarProduto
            // 
            this.buttonAlterarProduto.Location = new System.Drawing.Point(98, 4);
            this.buttonAlterarProduto.Name = "buttonAlterarProduto";
            this.buttonAlterarProduto.Size = new System.Drawing.Size(88, 45);
            this.buttonAlterarProduto.TabIndex = 1;
            this.buttonAlterarProduto.Text = "ALTERAR";
            this.buttonAlterarProduto.UseVisualStyleBackColor = true;
            this.buttonAlterarProduto.Click += new System.EventHandler(this.buttonAlterarPessoa_Click);
            // 
            // buttonCadastrarProduto
            // 
            this.buttonCadastrarProduto.Location = new System.Drawing.Point(4, 4);
            this.buttonCadastrarProduto.Name = "buttonCadastrarProduto";
            this.buttonCadastrarProduto.Size = new System.Drawing.Size(88, 45);
            this.buttonCadastrarProduto.TabIndex = 0;
            this.buttonCadastrarProduto.Text = "CADASTRAR";
            this.buttonCadastrarProduto.UseVisualStyleBackColor = true;
            this.buttonCadastrarProduto.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // Form_TelaInicial_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 749);
            this.Controls.Add(this.panelPessoas);
            this.Name = "Form_TelaInicial_Produtos";
            this.Text = "TelaInicialPessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_TelaInicial_Produtos_Load);
            this.panelPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.panelBotoesPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPessoas;
        private System.Windows.Forms.Panel panelBotoesPessoas;
        private System.Windows.Forms.Button buttonExcluirProduto;
        private System.Windows.Forms.Button buttonAlterarProduto;
        private System.Windows.Forms.Button buttonCadastrarProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
    }
}