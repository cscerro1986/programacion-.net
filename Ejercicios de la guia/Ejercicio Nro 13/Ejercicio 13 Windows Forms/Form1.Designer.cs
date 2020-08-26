namespace Ejercicio_13_Windows_Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1DecimalABinario = new System.Windows.Forms.TextBox();
            this.textBox2BinarioADecimal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2BinarioADecimal);
            this.panel1.Controls.Add(this.textBox1DecimalABinario);
            this.panel1.Location = new System.Drawing.Point(20, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 131);
            this.panel1.TabIndex = 0;
            // 
            // textBox1DecimalABinario
            // 
            this.textBox1DecimalABinario.Location = new System.Drawing.Point(11, 18);
            this.textBox1DecimalABinario.Name = "textBox1DecimalABinario";
            this.textBox1DecimalABinario.Size = new System.Drawing.Size(165, 20);
            this.textBox1DecimalABinario.TabIndex = 0;
            // 
            // textBox2BinarioADecimal
            // 
            this.textBox2BinarioADecimal.Location = new System.Drawing.Point(212, 18);
            this.textBox2BinarioADecimal.Name = "textBox2BinarioADecimal";
            this.textBox2BinarioADecimal.Size = new System.Drawing.Size(164, 20);
            this.textBox2BinarioADecimal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convertir a Binario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ConvertirABinario);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Convertir a Decimal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ConvertirADecimal);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 202);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2BinarioADecimal;
        private System.Windows.Forms.TextBox textBox1DecimalABinario;
    }
}

