namespace TicoGrafica.Forms.Forms.Pessoas
{
    partial class Form_TelaInicial_Pessoas
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
            this.dataGridViewPessoas = new System.Windows.Forms.DataGridView();
            this.panelBotoesPessoas = new System.Windows.Forms.Panel();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterarPessoa = new System.Windows.Forms.Button();
            this.buttonCadastrarPessoa = new System.Windows.Forms.Button();
            this.panelPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).BeginInit();
            this.panelBotoesPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPessoas
            // 
            this.panelPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoas.Controls.Add(this.dataGridViewPessoas);
            this.panelPessoas.Controls.Add(this.panelBotoesPessoas);
            this.panelPessoas.Location = new System.Drawing.Point(-1, -1);
            this.panelPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoas.Name = "panelPessoas";
            this.panelPessoas.Size = new System.Drawing.Size(1146, 741);
            this.panelPessoas.TabIndex = 3;
            // 
            // dataGridViewPessoas
            // 
            this.dataGridViewPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewPessoas.Location = new System.Drawing.Point(8, 59);
            this.dataGridViewPessoas.MultiSelect = false;
            this.dataGridViewPessoas.Name = "dataGridViewPessoas";
            this.dataGridViewPessoas.ReadOnly = true;
            this.dataGridViewPessoas.RowTemplate.Height = 25;
            this.dataGridViewPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPessoas.Size = new System.Drawing.Size(1135, 679);
            this.dataGridViewPessoas.TabIndex = 1;
            this.dataGridViewPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoas_CellDoubleClick);
            this.dataGridViewPessoas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPessoas_KeyPress);
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
            this.panelBotoesPessoas.Size = new System.Drawing.Size(2236, 54);
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
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterarPessoa
            // 
            this.buttonAlterarPessoa.Location = new System.Drawing.Point(98, 4);
            this.buttonAlterarPessoa.Name = "buttonAlterarPessoa";
            this.buttonAlterarPessoa.Size = new System.Drawing.Size(88, 45);
            this.buttonAlterarPessoa.TabIndex = 1;
            this.buttonAlterarPessoa.Text = "ALTERAR";
            this.buttonAlterarPessoa.UseVisualStyleBackColor = true;
            this.buttonAlterarPessoa.Click += new System.EventHandler(this.buttonAlterarPessoa_Click);
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
            // Form_TelaInicial_Pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 749);
            this.Controls.Add(this.panelPessoas);
            this.Name = "Form_TelaInicial_Pessoas";
            this.Text = "TelaInicialPessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_TelaInicial_Pessoas_Load);
            this.panelPessoas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).EndInit();
            this.panelBotoesPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPessoas;
        private System.Windows.Forms.Panel panelBotoesPessoas;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterarPessoa;
        private System.Windows.Forms.Button buttonCadastrarPessoa;
        private System.Windows.Forms.DataGridView dataGridViewPessoas;
    }
}