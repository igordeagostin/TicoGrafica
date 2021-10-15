
namespace TicoGrafica.Forms.Forms.ContasPagar
{
    partial class Form_Cadastrar_ContasPagar
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoConta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataDeVencimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataDeEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdPessoa = new System.Windows.Forms.TextBox();
            this.buttonBuscarPessoa = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(296, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR CONTA A PAGAR";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxTipoConta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.maskedTextBoxDataDeVencimento);
            this.panel1.Controls.Add(this.maskedTextBoxDataDeEntrega);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDescricao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIdPessoa);
            this.panel1.Controls.Add(this.buttonBuscarPessoa);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 188);
            this.panel1.TabIndex = 1;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(371, 98);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(131, 23);
            this.textBoxValor.TabIndex = 17;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxTipoConta
            // 
            this.comboBoxTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoConta.FormattingEnabled = true;
            this.comboBoxTipoConta.Location = new System.Drawing.Point(103, 100);
            this.comboBoxTipoConta.Name = "comboBoxTipoConta";
            this.comboBoxTipoConta.Size = new System.Drawing.Size(140, 23);
            this.comboBoxTipoConta.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Situação:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maskedTextBoxDataDeVencimento
            // 
            this.maskedTextBoxDataDeVencimento.Location = new System.Drawing.Point(371, 67);
            this.maskedTextBoxDataDeVencimento.Mask = "00/00/0000";
            this.maskedTextBoxDataDeVencimento.Name = "maskedTextBoxDataDeVencimento";
            this.maskedTextBoxDataDeVencimento.Size = new System.Drawing.Size(131, 23);
            this.maskedTextBoxDataDeVencimento.TabIndex = 14;
            this.maskedTextBoxDataDeVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataDeEntrega
            // 
            this.maskedTextBoxDataDeEntrega.Location = new System.Drawing.Point(103, 67);
            this.maskedTextBoxDataDeEntrega.Mask = "00/00/0000";
            this.maskedTextBoxDataDeEntrega.Name = "maskedTextBoxDataDeEntrega";
            this.maskedTextBoxDataDeEntrega.Size = new System.Drawing.Size(140, 23);
            this.maskedTextBoxDataDeEntrega.TabIndex = 13;
            this.maskedTextBoxDataDeEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de vencimento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de entrega:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(103, 33);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(399, 23);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxIdPessoa
            // 
            this.textBoxIdPessoa.Location = new System.Drawing.Point(4, 151);
            this.textBoxIdPessoa.Name = "textBoxIdPessoa";
            this.textBoxIdPessoa.ReadOnly = true;
            this.textBoxIdPessoa.Size = new System.Drawing.Size(16, 23);
            this.textBoxIdPessoa.TabIndex = 6;
            this.textBoxIdPessoa.Visible = false;
            // 
            // buttonBuscarPessoa
            // 
            this.buttonBuscarPessoa.Location = new System.Drawing.Point(427, 3);
            this.buttonBuscarPessoa.Name = "buttonBuscarPessoa";
            this.buttonBuscarPessoa.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPessoa.TabIndex = 5;
            this.buttonBuscarPessoa.Text = "Buscar";
            this.buttonBuscarPessoa.UseVisualStyleBackColor = true;
            this.buttonBuscarPessoa.Click += new System.EventHandler(this.buttonBuscarPessoa_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(346, 151);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(427, 151);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(103, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(318, 23);
            this.textBoxNome.TabIndex = 1;
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
            // Form_Cadastrar_ContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Cadastrar_ContasPagar";
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
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonBuscarPessoa;
        private System.Windows.Forms.TextBox textBoxIdPessoa;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataDeVencimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataDeEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoConta;
        private System.Windows.Forms.Label label7;
    }
}