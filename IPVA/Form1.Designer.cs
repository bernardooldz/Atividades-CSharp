namespace IPVA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtFipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbCarro = new System.Windows.Forms.RadioButton();
            this.rdbCaminhonetes = new System.Windows.Forms.RadioButton();
            this.rdbMoto = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.bntVerificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(53, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(152, 21);
            this.cmbEstado.TabIndex = 0;
            this.cmbEstado.Text = "Estado";
            // 
            // txtFipe
            // 
            this.txtFipe.Location = new System.Drawing.Point(53, 234);
            this.txtFipe.Name = "txtFipe";
            this.txtFipe.Size = new System.Drawing.Size(100, 20);
            this.txtFipe.TabIndex = 1;
            this.txtFipe.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o tipo do seu veículo:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione o seu estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira o valor da FIPE do seu veículo";
            // 
            // rdbCarro
            // 
            this.rdbCarro.AutoSize = true;
            this.rdbCarro.Location = new System.Drawing.Point(53, 124);
            this.rdbCarro.Name = "rdbCarro";
            this.rdbCarro.Size = new System.Drawing.Size(104, 17);
            this.rdbCarro.TabIndex = 5;
            this.rdbCarro.TabStop = true;
            this.rdbCarro.Text = "Carro de passeio\r\n";
            this.rdbCarro.UseVisualStyleBackColor = true;
            // 
            // rdbCaminhonetes
            // 
            this.rdbCaminhonetes.AutoSize = true;
            this.rdbCaminhonetes.Location = new System.Drawing.Point(53, 147);
            this.rdbCaminhonetes.Name = "rdbCaminhonetes";
            this.rdbCaminhonetes.Size = new System.Drawing.Size(144, 17);
            this.rdbCaminhonetes.TabIndex = 6;
            this.rdbCaminhonetes.TabStop = true;
            this.rdbCaminhonetes.Text = "Caminhonetes e utilitários";
            this.rdbCaminhonetes.UseVisualStyleBackColor = true;
            // 
            // rdbMoto
            // 
            this.rdbMoto.AutoSize = true;
            this.rdbMoto.Location = new System.Drawing.Point(53, 170);
            this.rdbMoto.Name = "rdbMoto";
            this.rdbMoto.Size = new System.Drawing.Size(85, 17);
            this.rdbMoto.TabIndex = 7;
            this.rdbMoto.TabStop = true;
            this.rdbMoto.Text = "Motocicletas";
            this.rdbMoto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do seu IPVA:";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.Location = new System.Drawing.Point(15, 27);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(100, 21);
            this.txtValorFinal.TabIndex = 9;
            this.txtValorFinal.Text = "0,00";
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bntVerificar
            // 
            this.bntVerificar.BackColor = System.Drawing.Color.Bisque;
            this.bntVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntVerificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVerificar.Location = new System.Drawing.Point(115, 332);
            this.bntVerificar.Name = "bntVerificar";
            this.bntVerificar.Size = new System.Drawing.Size(163, 48);
            this.bntVerificar.TabIndex = 10;
            this.bntVerificar.Text = "Veificar o valor do IPVA";
            this.bntVerificar.UseVisualStyleBackColor = false;
            this.bntVerificar.Click += new System.EventHandler(this.bntVerificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rdbMoto);
            this.panel1.Controls.Add(this.rdbCaminhonetes);
            this.panel1.Controls.Add(this.rdbCarro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFipe);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Location = new System.Drawing.Point(71, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 271);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtValorFinal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(126, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 60);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtFipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbCarro;
        private System.Windows.Forms.RadioButton rdbCaminhonetes;
        private System.Windows.Forms.RadioButton rdbMoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Button bntVerificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

