
namespace TicoGrafica.Forms.Forms.Pessoas
{
    partial class Form_Cadastrar_Pessoa
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxMunicipio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonFisica = new System.Windows.Forms.RadioButton();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR PESSOA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.textBoxMunicipio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxCEP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxComplemento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxNumero);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxBairro);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxEndereco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButtonJuridica);
            this.panel1.Controls.Add(this.radioButtonFisica);
            this.panel1.Controls.Add(this.textBoxDocumento);
            this.panel1.Controls.Add(this.labelDocumento);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTelefone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 355);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(196, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(277, 327);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxMunicipio
            // 
            this.textBoxMunicipio.Location = new System.Drawing.Point(227, 240);
            this.textBoxMunicipio.Name = "textBoxMunicipio";
            this.textBoxMunicipio.Size = new System.Drawing.Size(125, 23);
            this.textBoxMunicipio.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Município";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Location = new System.Drawing.Point(64, 240);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(97, 23);
            this.textBoxCEP.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "CEP:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(227, 211);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(125, 23);
            this.textBoxComplemento.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Complemento:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(64, 211);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(64, 23);
            this.textBoxNumero.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(64, 182);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(288, 23);
            this.textBoxBairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bairro:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(64, 153);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(288, 23);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Endereço:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonJuridica
            // 
            this.radioButtonJuridica.AutoSize = true;
            this.radioButtonJuridica.Location = new System.Drawing.Point(124, 91);
            this.radioButtonJuridica.Name = "radioButtonJuridica";
            this.radioButtonJuridica.Size = new System.Drawing.Size(65, 19);
            this.radioButtonJuridica.TabIndex = 5;
            this.radioButtonJuridica.TabStop = true;
            this.radioButtonJuridica.Text = "Jurídica";
            this.radioButtonJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonJuridica.UseVisualStyleBackColor = true;
            // 
            // radioButtonFisica
            // 
            this.radioButtonFisica.AutoSize = true;
            this.radioButtonFisica.Location = new System.Drawing.Point(64, 91);
            this.radioButtonFisica.Name = "radioButtonFisica";
            this.radioButtonFisica.Size = new System.Drawing.Size(54, 19);
            this.radioButtonFisica.TabIndex = 4;
            this.radioButtonFisica.TabStop = true;
            this.radioButtonFisica.Text = "Física";
            this.radioButtonFisica.UseVisualStyleBackColor = true;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(64, 124);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(288, 23);
            this.textBoxDocumento.TabIndex = 6;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(4, 127);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(31, 15);
            this.labelDocumento.TabIndex = 6;
            this.labelDocumento.Text = "CPF:";
            this.labelDocumento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(64, 62);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(288, 23);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(64, 33);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(288, 23);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(64, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(288, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // CadastrarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastrarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarPessoa";
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
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonJuridica;
        private System.Windows.Forms.RadioButton radioButtonFisica;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
    }
}