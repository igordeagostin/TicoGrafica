
namespace TicoGrafica.Forms.Forms.Pessoas
{
    partial class Form_TelaInicial_Pessoas
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
            this.panelPessoas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBotoesPessoas = new System.Windows.Forms.Panel();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterarPessoa = new System.Windows.Forms.Button();
            this.buttonCadastrarPessoa = new System.Windows.Forms.Button();
            this.panelPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBotoesPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPessoas
            // 
            this.panelPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoas.Controls.Add(this.dataGridView1);
            this.panelPessoas.Controls.Add(this.panelBotoesPessoas);
            this.panelPessoas.Location = new System.Drawing.Point(-1, -1);
            this.panelPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoas.Name = "panelPessoas";
            this.panelPessoas.Size = new System.Drawing.Size(1272, 680);
            this.panelPessoas.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone,
            this.Documento});
            this.dataGridView1.Location = new System.Drawing.Point(8, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(2358, 1240);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome ";
            this.Nome.Name = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "CPF/CNPJ";
            this.Documento.Name = "Documento";
            // 
            // panelBotoesPessoas
            // 
            this.panelBotoesPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoesPessoas.Controls.Add(this.buttonExcluir);
            this.panelBotoesPessoas.Controls.Add(this.buttonAlterarPessoa);
            this.panelBotoesPessoas.Controls.Add(this.buttonCadastrarPessoa);
            this.panelBotoesPessoas.Location = new System.Drawing.Point(3, 3);
            this.panelBotoesPessoas.Name = "panelBotoesPessoas";
            this.panelBotoesPessoas.Size = new System.Drawing.Size(2362, 54);
            this.panelBotoesPessoas.TabIndex = 0;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(192, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(88, 45);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "EXCLUIR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarPessoa
            // 
            this.buttonAlterarPessoa.Location = new System.Drawing.Point(98, 4);
            this.buttonAlterarPessoa.Name = "buttonAlterarPessoa";
            this.buttonAlterarPessoa.Size = new System.Drawing.Size(88, 45);
            this.buttonAlterarPessoa.TabIndex = 1;
            this.buttonAlterarPessoa.Text = "ALTERAR";
            this.buttonAlterarPessoa.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarPessoa
            // 
            this.buttonCadastrarPessoa.Location = new System.Drawing.Point(4, 4);
            this.buttonCadastrarPessoa.Name = "buttonCadastrarPessoa";
            this.buttonCadastrarPessoa.Size = new System.Drawing.Size(88, 45);
            this.buttonCadastrarPessoa.TabIndex = 0;
            this.buttonCadastrarPessoa.Text = "CADASTRAR";
            this.buttonCadastrarPessoa.UseVisualStyleBackColor = true;
            this.buttonCadastrarPessoa.Click += new System.EventHandler(this.buttonCadastrarPessoa_Click);
            // 
            // TelaInicialPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 766);
            this.Controls.Add(this.panelPessoas);
            this.Name = "TelaInicialPessoas";
            this.Text = "TelaInicialPessoas";
            this.panelPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBotoesPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPessoas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.Panel panelBotoesPessoas;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterarPessoa;
        private System.Windows.Forms.Button buttonCadastrarPessoa;
    }
}