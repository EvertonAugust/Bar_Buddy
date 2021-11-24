
namespace Bar_Buddy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.checkBoxTaxa = new System.Windows.Forms.CheckBox();
            this.checkBoxCover = new System.Windows.Forms.CheckBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxAmigos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Buddy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amigos";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(59, 396);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 3;
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResultado.Location = new System.Drawing.Point(43, 314);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(277, 41);
            this.buttonResultado.TabIndex = 4;
            this.buttonResultado.Text = "Resultado";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // checkBoxTaxa
            // 
            this.checkBoxTaxa.AutoSize = true;
            this.checkBoxTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTaxa.Location = new System.Drawing.Point(43, 183);
            this.checkBoxTaxa.Name = "checkBoxTaxa";
            this.checkBoxTaxa.Size = new System.Drawing.Size(171, 33);
            this.checkBoxTaxa.TabIndex = 5;
            this.checkBoxTaxa.Text = "Taxa/Gorjeta";
            this.checkBoxTaxa.UseVisualStyleBackColor = true;
            // 
            // checkBoxCover
            // 
            this.checkBoxCover.AutoSize = true;
            this.checkBoxCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCover.Location = new System.Drawing.Point(43, 231);
            this.checkBoxCover.Name = "checkBoxCover";
            this.checkBoxCover.Size = new System.Drawing.Size(187, 33);
            this.checkBoxCover.TabIndex = 6;
            this.checkBoxCover.Text = "Cover Artístico";
            this.checkBoxCover.UseVisualStyleBackColor = true;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(43, 102);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(80, 20);
            this.textBoxValor.TabIndex = 7;
            // 
            // textBoxAmigos
            // 
            this.textBoxAmigos.Location = new System.Drawing.Point(180, 102);
            this.textBoxAmigos.Name = "textBoxAmigos";
            this.textBoxAmigos.Size = new System.Drawing.Size(80, 20);
            this.textBoxAmigos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 463);
            this.Controls.Add(this.textBoxAmigos);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.checkBoxCover);
            this.Controls.Add(this.checkBoxTaxa);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonResultado;
        private System.Windows.Forms.CheckBox checkBoxTaxa;
        private System.Windows.Forms.CheckBox checkBoxCover;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxAmigos;
    }
}

