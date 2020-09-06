namespace Ejercicio_Nro_25
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtDeDecimalABinario = new System.Windows.Forms.TextBox();
            this.txtDeBinarioADecimal = new System.Windows.Forms.TextBox();
            this.btnBinarioADecimal = new System.Windows.Forms.Button();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(117, 38);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(99, 20);
            this.txtBinario.TabIndex = 2;
            this.txtBinario.Leave += new System.EventHandler(this.txtBinario_Leave);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(117, 66);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(99, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // txtDeDecimalABinario
            // 
            this.txtDeDecimalABinario.Location = new System.Drawing.Point(279, 66);
            this.txtDeDecimalABinario.Name = "txtDeDecimalABinario";
            this.txtDeDecimalABinario.Size = new System.Drawing.Size(99, 20);
            this.txtDeDecimalABinario.TabIndex = 5;
            // 
            // txtDeBinarioADecimal
            // 
            this.txtDeBinarioADecimal.Location = new System.Drawing.Point(279, 38);
            this.txtDeBinarioADecimal.Name = "txtDeBinarioADecimal";
            this.txtDeBinarioADecimal.Size = new System.Drawing.Size(99, 20);
            this.txtDeBinarioADecimal.TabIndex = 4;
            // 
            // btnBinarioADecimal
            // 
            this.btnBinarioADecimal.Location = new System.Drawing.Point(222, 38);
            this.btnBinarioADecimal.Name = "btnBinarioADecimal";
            this.btnBinarioADecimal.Size = new System.Drawing.Size(51, 20);
            this.btnBinarioADecimal.TabIndex = 6;
            this.btnBinarioADecimal.Text = "--->";
            this.btnBinarioADecimal.UseVisualStyleBackColor = true;
            this.btnBinarioADecimal.Click += new System.EventHandler(this.btnBinarioADecimal_Click);
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(222, 66);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(51, 20);
            this.btnDecimalABinario.TabIndex = 7;
            this.btnDecimalABinario.Text = "--->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            this.btnDecimalABinario.Click += new System.EventHandler(this.btnDecimalABinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 118);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.btnBinarioADecimal);
            this.Controls.Add(this.txtDeDecimalABinario);
            this.Controls.Add(this.txtDeBinarioADecimal);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtDeDecimalABinario;
        private System.Windows.Forms.TextBox txtDeBinarioADecimal;
        private System.Windows.Forms.Button btnBinarioADecimal;
        private System.Windows.Forms.Button btnDecimalABinario;
    }
}

