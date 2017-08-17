namespace TarefaConversor
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
            this.labelNr = new System.Windows.Forms.Label();
            this.textNr = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.radioDecimal = new System.Windows.Forms.RadioButton();
            this.radioHexa = new System.Windows.Forms.RadioButton();
            this.radioOctal = new System.Windows.Forms.RadioButton();
            this.radioBinario = new System.Windows.Forms.RadioButton();
            this.botaoConverter = new System.Windows.Forms.Button();
            this.resultDecimal = new System.Windows.Forms.Label();
            this.resultOctal = new System.Windows.Forms.Label();
            this.resultHexa = new System.Windows.Forms.Label();
            this.resultBinario = new System.Windows.Forms.Label();
            this.boxDecimal = new System.Windows.Forms.TextBox();
            this.boxOctal = new System.Windows.Forms.TextBox();
            this.boxBinario = new System.Windows.Forms.TextBox();
            this.boxHexa = new System.Windows.Forms.TextBox();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNr
            // 
            this.labelNr.AutoSize = true;
            this.labelNr.Location = new System.Drawing.Point(12, 22);
            this.labelNr.Name = "labelNr";
            this.labelNr.Size = new System.Drawing.Size(78, 13);
            this.labelNr.TabIndex = 0;
            this.labelNr.Text = "Insira um valor:";
            // 
            // textNr
            // 
            this.textNr.Location = new System.Drawing.Point(119, 22);
            this.textNr.Name = "textNr";
            this.textNr.Size = new System.Drawing.Size(100, 20);
            this.textNr.TabIndex = 1;
            this.textNr.TextChanged += new System.EventHandler(this.textNr_TextChanged);
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(12, 62);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(207, 13);
            this.labelBase.TabIndex = 2;
            this.labelBase.Text = "Selecione o tipo da base do valor inserido:";
            // 
            // radioDecimal
            // 
            this.radioDecimal.AutoSize = true;
            this.radioDecimal.Location = new System.Drawing.Point(15, 93);
            this.radioDecimal.Name = "radioDecimal";
            this.radioDecimal.Size = new System.Drawing.Size(63, 17);
            this.radioDecimal.TabIndex = 3;
            this.radioDecimal.TabStop = true;
            this.radioDecimal.Text = "Decimal";
            this.radioDecimal.UseVisualStyleBackColor = true;
            this.radioDecimal.CheckedChanged += new System.EventHandler(this.radioDecimal_CheckedChanged);
            // 
            // radioHexa
            // 
            this.radioHexa.AutoSize = true;
            this.radioHexa.Location = new System.Drawing.Point(109, 93);
            this.radioHexa.Name = "radioHexa";
            this.radioHexa.Size = new System.Drawing.Size(86, 17);
            this.radioHexa.TabIndex = 4;
            this.radioHexa.TabStop = true;
            this.radioHexa.Text = "Hexadecimal";
            this.radioHexa.UseVisualStyleBackColor = true;
            this.radioHexa.CheckedChanged += new System.EventHandler(this.radioHexa_CheckedChanged);
            // 
            // radioOctal
            // 
            this.radioOctal.AutoSize = true;
            this.radioOctal.Location = new System.Drawing.Point(227, 93);
            this.radioOctal.Name = "radioOctal";
            this.radioOctal.Size = new System.Drawing.Size(50, 17);
            this.radioOctal.TabIndex = 5;
            this.radioOctal.TabStop = true;
            this.radioOctal.Text = "Octal";
            this.radioOctal.UseVisualStyleBackColor = true;
            this.radioOctal.CheckedChanged += new System.EventHandler(this.radioOctal_CheckedChanged);
            // 
            // radioBinario
            // 
            this.radioBinario.AutoSize = true;
            this.radioBinario.Location = new System.Drawing.Point(318, 93);
            this.radioBinario.Name = "radioBinario";
            this.radioBinario.Size = new System.Drawing.Size(57, 17);
            this.radioBinario.TabIndex = 6;
            this.radioBinario.TabStop = true;
            this.radioBinario.Text = "Binário";
            this.radioBinario.UseVisualStyleBackColor = true;
            this.radioBinario.CheckedChanged += new System.EventHandler(this.radioBinario_CheckedChanged);
            // 
            // botaoConverter
            // 
            this.botaoConverter.Location = new System.Drawing.Point(183, 146);
            this.botaoConverter.Name = "botaoConverter";
            this.botaoConverter.Size = new System.Drawing.Size(75, 23);
            this.botaoConverter.TabIndex = 7;
            this.botaoConverter.Text = "Converter";
            this.botaoConverter.UseVisualStyleBackColor = true;
            this.botaoConverter.Click += new System.EventHandler(this.botaoConverter_Click);
            // 
            // resultDecimal
            // 
            this.resultDecimal.AutoSize = true;
            this.resultDecimal.Location = new System.Drawing.Point(24, 209);
            this.resultDecimal.Name = "resultDecimal";
            this.resultDecimal.Size = new System.Drawing.Size(45, 13);
            this.resultDecimal.TabIndex = 8;
            this.resultDecimal.Text = "Decimal";
            // 
            // resultOctal
            // 
            this.resultOctal.AutoSize = true;
            this.resultOctal.Location = new System.Drawing.Point(249, 209);
            this.resultOctal.Name = "resultOctal";
            this.resultOctal.Size = new System.Drawing.Size(32, 13);
            this.resultOctal.TabIndex = 9;
            this.resultOctal.Text = "Octal";
            // 
            // resultHexa
            // 
            this.resultHexa.AutoSize = true;
            this.resultHexa.Location = new System.Drawing.Point(22, 251);
            this.resultHexa.Name = "resultHexa";
            this.resultHexa.Size = new System.Drawing.Size(68, 13);
            this.resultHexa.TabIndex = 10;
            this.resultHexa.Text = "Hexadecimal";
            // 
            // resultBinario
            // 
            this.resultBinario.AutoSize = true;
            this.resultBinario.Location = new System.Drawing.Point(249, 251);
            this.resultBinario.Name = "resultBinario";
            this.resultBinario.Size = new System.Drawing.Size(39, 13);
            this.resultBinario.TabIndex = 11;
            this.resultBinario.Text = "Binário";
            // 
            // boxDecimal
            // 
            this.boxDecimal.Location = new System.Drawing.Point(95, 206);
            this.boxDecimal.Name = "boxDecimal";
            this.boxDecimal.Size = new System.Drawing.Size(100, 20);
            this.boxDecimal.TabIndex = 12;
            this.boxDecimal.TextChanged += new System.EventHandler(this.boxDecimal_TextChanged);
            // 
            // boxOctal
            // 
            this.boxOctal.Location = new System.Drawing.Point(294, 206);
            this.boxOctal.Name = "boxOctal";
            this.boxOctal.Size = new System.Drawing.Size(100, 20);
            this.boxOctal.TabIndex = 13;
            this.boxOctal.TextChanged += new System.EventHandler(this.boxOctal_TextChanged);
            // 
            // boxBinario
            // 
            this.boxBinario.Location = new System.Drawing.Point(294, 248);
            this.boxBinario.Name = "boxBinario";
            this.boxBinario.Size = new System.Drawing.Size(100, 20);
            this.boxBinario.TabIndex = 14;
            this.boxBinario.TextChanged += new System.EventHandler(this.boxBinario_TextChanged);
            // 
            // boxHexa
            // 
            this.boxHexa.Location = new System.Drawing.Point(95, 248);
            this.boxHexa.Name = "boxHexa";
            this.boxHexa.Size = new System.Drawing.Size(100, 20);
            this.boxHexa.TabIndex = 15;
            this.boxHexa.TextChanged += new System.EventHandler(this.boxHexa_TextChanged);
            // 
            // botaoSair
            // 
            this.botaoSair.Location = new System.Drawing.Point(331, 297);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(75, 23);
            this.botaoSair.TabIndex = 16;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(240, 297);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 17;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 332);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.boxHexa);
            this.Controls.Add(this.boxBinario);
            this.Controls.Add(this.boxOctal);
            this.Controls.Add(this.boxDecimal);
            this.Controls.Add(this.resultBinario);
            this.Controls.Add(this.resultHexa);
            this.Controls.Add(this.resultOctal);
            this.Controls.Add(this.resultDecimal);
            this.Controls.Add(this.botaoConverter);
            this.Controls.Add(this.radioBinario);
            this.Controls.Add(this.radioOctal);
            this.Controls.Add(this.radioHexa);
            this.Controls.Add(this.radioDecimal);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.textNr);
            this.Controls.Add(this.labelNr);
            this.Name = "Form1";
            this.Text = "CONVERSOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNr;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.RadioButton radioDecimal;
        private System.Windows.Forms.RadioButton radioHexa;
        private System.Windows.Forms.RadioButton radioOctal;
        private System.Windows.Forms.RadioButton radioBinario;
        private System.Windows.Forms.Button botaoConverter;
        private System.Windows.Forms.Label resultDecimal;
        private System.Windows.Forms.Label resultOctal;
        private System.Windows.Forms.Label resultHexa;
        private System.Windows.Forms.Label resultBinario;
        private System.Windows.Forms.TextBox boxDecimal;
        private System.Windows.Forms.TextBox boxOctal;
        private System.Windows.Forms.TextBox boxBinario;
        private System.Windows.Forms.TextBox boxHexa;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoLimpar;
        public System.Windows.Forms.TextBox textNr;
    }
}

