﻿
namespace TicoGrafica.Forms.Forms.Orcamento
{
    partial class Form_Cadastrar_Orcamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdPessoa = new System.Windows.Forms.TextBox();
            this.buttonBuscarPessoa = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxPessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR ORÇAMENTO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxIdProduto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxProduto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxFormaDePagamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxQuantidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIdPessoa);
            this.panel1.Controls.Add(this.buttonBuscarPessoa);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.textBoxPessoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 195);
            this.panel1.TabIndex = 1;
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(26, 150);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.ReadOnly = true;
            this.textBoxIdProduto.Size = new System.Drawing.Size(16, 23);
            this.textBoxIdProduto.TabIndex = 22;
            this.textBoxIdProduto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(82, 32);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.ReadOnly = true;
            this.textBoxProduto.Size = new System.Drawing.Size(318, 23);
            this.textBoxProduto.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Produto:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(350, 62);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(131, 23);
            this.textBoxValor.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxFormaDePagamento
            // 
            this.comboBoxFormaDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaDePagamento.FormattingEnabled = true;
            this.comboBoxFormaDePagamento.Location = new System.Drawing.Point(81, 95);
            this.comboBoxFormaDePagamento.Name = "comboBoxFormaDePagamento";
            this.comboBoxFormaDePagamento.Size = new System.Drawing.Size(140, 23);
            this.comboBoxFormaDePagamento.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pagamento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(82, 62);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(140, 23);
            this.textBoxQuantidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxIdPessoa
            // 
            this.textBoxIdPessoa.Location = new System.Drawing.Point(4, 150);
            this.textBoxIdPessoa.Name = "textBoxIdPessoa";
            this.textBoxIdPessoa.ReadOnly = true;
            this.textBoxIdPessoa.Size = new System.Drawing.Size(16, 23);
            this.textBoxIdPessoa.TabIndex = 6;
            this.textBoxIdPessoa.Visible = false;
            // 
            // buttonBuscarPessoa
            // 
            this.buttonBuscarPessoa.Location = new System.Drawing.Point(406, 3);
            this.buttonBuscarPessoa.Name = "buttonBuscarPessoa";
            this.buttonBuscarPessoa.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPessoa.TabIndex = 5;
            this.buttonBuscarPessoa.Text = "Buscar";
            this.buttonBuscarPessoa.UseVisualStyleBackColor = true;
            this.buttonBuscarPessoa.Click += new System.EventHandler(this.buttonBuscarPessoa_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(325, 167);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(406, 167);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxPessoa
            // 
            this.textBoxPessoa.Location = new System.Drawing.Point(82, 4);
            this.textBoxPessoa.Name = "textBoxPessoa";
            this.textBoxPessoa.ReadOnly = true;
            this.textBoxPessoa.Size = new System.Drawing.Size(318, 23);
            this.textBoxPessoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pessoa:";
            // 
            // Form_Cadastrar_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Cadastrar_Orcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar conta a pagar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonBuscarPessoa;
        private System.Windows.Forms.TextBox textBoxIdPessoa;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFormaDePagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdProduto;
    }
}