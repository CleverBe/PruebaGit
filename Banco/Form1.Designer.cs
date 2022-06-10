namespace Banco
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitular = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCantidadMostrar = new System.Windows.Forms.TextBox();
            this.textBoxTitularMostrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegistrar.Location = new System.Drawing.Point(168, 203);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // textBoxTitular
            // 
            this.textBoxTitular.Location = new System.Drawing.Point(241, 72);
            this.textBoxTitular.Name = "textBoxTitular";
            this.textBoxTitular.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitular.TabIndex = 2;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(241, 121);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMostrar.Location = new System.Drawing.Point(168, 268);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 5;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // textBoxCantidadMostrar
            // 
            this.textBoxCantidadMostrar.Location = new System.Drawing.Point(241, 369);
            this.textBoxCantidadMostrar.Name = "textBoxCantidadMostrar";
            this.textBoxCantidadMostrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidadMostrar.TabIndex = 8;
            // 
            // textBoxTitularMostrar
            // 
            this.textBoxTitularMostrar.Location = new System.Drawing.Point(241, 320);
            this.textBoxTitularMostrar.Name = "textBoxTitularMostrar";
            this.textBoxTitularMostrar.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitularMostrar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titular";
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDepositar.Location = new System.Drawing.Point(115, 494);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 10;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRetirar.Location = new System.Drawing.Point(252, 494);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(75, 23);
            this.buttonRetirar.TabIndex = 11;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad a retirar o depositar";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(252, 449);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.buttonRetirar);
            this.Controls.Add(this.buttonDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCantidadMostrar);
            this.Controls.Add(this.textBoxTitularMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitular;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCantidadMostrar;
        private System.Windows.Forms.TextBox textBoxTitularMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMonto;
    }
}

