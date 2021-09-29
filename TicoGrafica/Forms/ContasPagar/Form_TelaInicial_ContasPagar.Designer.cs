﻿namespace TicoGrafica.Forms.Forms.ContasPagar
{
    partial class Form_TelaInicial_ContasPagar
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
            this.dataGridViewContasPagar = new System.Windows.Forms.DataGridView();
            this.panelBotoesPessoas = new System.Windows.Forms.Panel();
            this.buttonExcluirContasPagar = new System.Windows.Forms.Button();
            this.buttonAlterarContasPagar = new System.Windows.Forms.Button();
            this.buttonCadastrarContasPagar = new System.Windows.Forms.Button();
            this.panelPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasPagar)).BeginInit();
            this.panelBotoesPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPessoas
            // 
            this.panelPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoas.Controls.Add(this.dataGridViewContasPagar);
            this.panelPessoas.Controls.Add(this.panelBotoesPessoas);
            this.panelPessoas.Location = new System.Drawing.Point(-1, -1);
            this.panelPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoas.Name = "panelPessoas";
            this.panelPessoas.Size = new System.Drawing.Size(1146, 741);
            this.panelPessoas.TabIndex = 3;
            // 
            // dataGridViewContasPagar
            // 
            this.dataGridViewContasPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContasPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContasPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewContasPagar.Location = new System.Drawing.Point(8, 59);
            this.dataGridViewContasPagar.MultiSelect = false;
            this.dataGridViewContasPagar.Name = "dataGridViewContasPagar";
            this.dataGridViewContasPagar.ReadOnly = true;
            this.dataGridViewContasPagar.RowTemplate.Height = 25;
            this.dataGridViewContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContasPagar.Size = new System.Drawing.Size(1135, 679);
            this.dataGridViewContasPagar.TabIndex = 1;
            this.dataGridViewContasPagar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            this.dataGridViewContasPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdutos_KeyPress);
            // 
            // panelBotoesPessoas
            // 
            this.panelBotoesPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoesPessoas.Controls.Add(this.buttonExcluirContasPagar);
            this.panelBotoesPessoas.Controls.Add(this.buttonAlterarContasPagar);
            this.panelBotoesPessoas.Controls.Add(this.buttonCadastrarContasPagar);
            this.panelBotoesPessoas.Location = new System.Drawing.Point(3, 3);
            this.panelBotoesPessoas.Name = "panelBotoesPessoas";
            this.panelBotoesPessoas.Size = new System.Drawing.Size(2236, 54);
            this.panelBotoesPessoas.TabIndex = 0;
            // 
            // buttonExcluirContasPagar
            // 
            this.buttonExcluirContasPagar.Location = new System.Drawing.Point(192, 4);
            this.buttonExcluirContasPagar.Name = "buttonExcluirContasPagar";
            this.buttonExcluirContasPagar.Size = new System.Drawing.Size(88, 45);
            this.buttonExcluirContasPagar.TabIndex = 2;
            this.buttonExcluirContasPagar.Text = "EXCLUIR";
            this.buttonExcluirContasPagar.UseVisualStyleBackColor = true;
            this.buttonExcluirContasPagar.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterarContasPagar
            // 
            this.buttonAlterarContasPagar.Location = new System.Drawing.Point(98, 4);
            this.buttonAlterarContasPagar.Name = "buttonAlterarContasPagar";
            this.buttonAlterarContasPagar.Size = new System.Drawing.Size(88, 45);
            this.buttonAlterarContasPagar.TabIndex = 1;
            this.buttonAlterarContasPagar.Text = "ALTERAR";
            this.buttonAlterarContasPagar.UseVisualStyleBackColor = true;
            this.buttonAlterarContasPagar.Click += new System.EventHandler(this.buttonAlterarPessoa_Click);
            // 
            // buttonCadastrarContasPagar
            // 
            this.buttonCadastrarContasPagar.Location = new System.Drawing.Point(4, 4);
            this.buttonCadastrarContasPagar.Name = "buttonCadastrarContasPagar";
            this.buttonCadastrarContasPagar.Size = new System.Drawing.Size(88, 45);
            this.buttonCadastrarContasPagar.TabIndex = 0;
            this.buttonCadastrarContasPagar.Text = "CADASTRAR";
            this.buttonCadastrarContasPagar.UseVisualStyleBackColor = true;
            this.buttonCadastrarContasPagar.Click += new System.EventHandler(this.buttonCadastrarProduto_Click);
            // 
            // Form_TelaInicial_ContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 749);
            this.Controls.Add(this.panelPessoas);
            this.Name = "Form_TelaInicial_ContasPagar";
            this.Text = "TelaInicialPessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_TelaInicial_Produtos_Load);
            this.panelPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasPagar)).EndInit();
            this.panelBotoesPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPessoas;
        private System.Windows.Forms.Panel panelBotoesPessoas;
        private System.Windows.Forms.Button buttonExcluirContasPagar;
        private System.Windows.Forms.Button buttonAlterarContasPagar;
        private System.Windows.Forms.Button buttonCadastrarContasPagar;
        private System.Windows.Forms.DataGridView dataGridViewContasPagar;
    }
}