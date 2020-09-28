namespace Ejercicio_Nro_40_Form
{
    partial class FormMenu
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
            this.btn_GenerarLLamada = new System.Windows.Forms.Button();
            this.btn_FacturacionTotal = new System.Windows.Forms.Button();
            this.btn_FacturacionProvincial = new System.Windows.Forms.Button();
            this.btn_FacturacionLocal = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerarLLamada
            // 
            this.btn_GenerarLLamada.Location = new System.Drawing.Point(12, 21);
            this.btn_GenerarLLamada.Name = "btn_GenerarLLamada";
            this.btn_GenerarLLamada.Size = new System.Drawing.Size(299, 73);
            this.btn_GenerarLLamada.TabIndex = 0;
            this.btn_GenerarLLamada.Text = "Generar Llamada";
            this.btn_GenerarLLamada.UseVisualStyleBackColor = true;
            this.btn_GenerarLLamada.Click += new System.EventHandler(this.GenerarLlamada_Click);
            // 
            // btn_FacturacionTotal
            // 
            this.btn_FacturacionTotal.Location = new System.Drawing.Point(12, 100);
            this.btn_FacturacionTotal.Name = "btn_FacturacionTotal";
            this.btn_FacturacionTotal.Size = new System.Drawing.Size(299, 73);
            this.btn_FacturacionTotal.TabIndex = 1;
            this.btn_FacturacionTotal.Text = "Facturacion Total";
            this.btn_FacturacionTotal.UseVisualStyleBackColor = true;
            this.btn_FacturacionTotal.Click += new System.EventHandler(this.FacturacionTotal_Click);
            // 
            // btn_FacturacionProvincial
            // 
            this.btn_FacturacionProvincial.Location = new System.Drawing.Point(12, 258);
            this.btn_FacturacionProvincial.Name = "btn_FacturacionProvincial";
            this.btn_FacturacionProvincial.Size = new System.Drawing.Size(299, 73);
            this.btn_FacturacionProvincial.TabIndex = 3;
            this.btn_FacturacionProvincial.Text = "Facturacion Provincial";
            this.btn_FacturacionProvincial.UseVisualStyleBackColor = true;
            this.btn_FacturacionProvincial.Click += new System.EventHandler(this.FacturacionProvincial_Click);
            // 
            // btn_FacturacionLocal
            // 
            this.btn_FacturacionLocal.Location = new System.Drawing.Point(12, 179);
            this.btn_FacturacionLocal.Name = "btn_FacturacionLocal";
            this.btn_FacturacionLocal.Size = new System.Drawing.Size(299, 73);
            this.btn_FacturacionLocal.TabIndex = 2;
            this.btn_FacturacionLocal.Text = "Facturacion Local";
            this.btn_FacturacionLocal.UseVisualStyleBackColor = true;
            this.btn_FacturacionLocal.Click += new System.EventHandler(this.FacturacionLocal_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 337);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(299, 73);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_FacturacionProvincial);
            this.Controls.Add(this.btn_FacturacionLocal);
            this.Controls.Add(this.btn_FacturacionTotal);
            this.Controls.Add(this.btn_GenerarLLamada);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerarLLamada;
        private System.Windows.Forms.Button btn_FacturacionTotal;
        private System.Windows.Forms.Button btn_FacturacionProvincial;
        private System.Windows.Forms.Button btn_FacturacionLocal;
        private System.Windows.Forms.Button btn_Salir;
    }
}

