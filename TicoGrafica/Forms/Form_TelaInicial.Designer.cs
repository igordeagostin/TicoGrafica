
using TicoGrafica.Services.Services.IServices;

namespace TicoGrafica
{
    partial class Form_TelaInicial
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPessoas = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonPessoas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 718);
            this.panel1.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(193, 49);
            this.button9.TabIndex = 5;
            this.button9.Text = "ÍNICIO";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "ORÇAMENTOS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "CONTAS A RECEBER";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "CONTAS A PAGAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "PRODUTOS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPessoas
            // 
            this.buttonPessoas.Location = new System.Drawing.Point(4, 60);
            this.buttonPessoas.Name = "buttonPessoas";
            this.buttonPessoas.Size = new System.Drawing.Size(193, 49);
            this.buttonPessoas.TabIndex = 0;
            this.buttonPessoas.Text = "PESSOAS";
            this.buttonPessoas.UseVisualStyleBackColor = true;
            this.buttonPessoas.Click += new System.EventHandler(this.buttonPessoas_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Location = new System.Drawing.Point(213, 12);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1290, 718);
            this.panelPrincipal.TabIndex = 2;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 742);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInicial";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPessoas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button button9;
    }
}

