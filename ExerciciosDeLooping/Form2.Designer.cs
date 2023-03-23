namespace ExerciciosDeLooping
{
    partial class frmexercicio1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lbllitro = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtlitro = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(189, 287);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(107, 41);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(344, 287);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(107, 41);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(490, 287);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(107, 41);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(104, 122);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(345, 13);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Digite A se for o tipo de combustivel for alcool e G se o tipo for gasolina:";
            // 
            // lbllitro
            // 
            this.lbllitro.AutoSize = true;
            this.lbllitro.Location = new System.Drawing.Point(262, 169);
            this.lbllitro.Name = "lbllitro";
            this.lbllitro.Size = new System.Drawing.Size(187, 13);
            this.lbllitro.TabIndex = 4;
            this.lbllitro.Text = "Digite a quantidade de litros vendidos:";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(372, 211);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(77, 13);
            this.lblpreco.TabIndex = 5;
            this.lblpreco.Text = "Preço a pagar:";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(466, 119);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(101, 20);
            this.txttipo.TabIndex = 6;
            // 
            // txtlitro
            // 
            this.txtlitro.Location = new System.Drawing.Point(466, 165);
            this.txtlitro.Name = "txtlitro";
            this.txtlitro.Size = new System.Drawing.Size(101, 20);
            this.txtlitro.TabIndex = 7;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(466, 207);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(101, 20);
            this.txtpreco.TabIndex = 8;
            // 
            // frmexercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtlitro);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbllitro);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "frmexercicio1";
            this.Text = "Exercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lbllitro;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtlitro;
        private System.Windows.Forms.TextBox txtpreco;
    }
}