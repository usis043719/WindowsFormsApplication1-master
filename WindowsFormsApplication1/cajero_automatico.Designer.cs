namespace WindowsFormsApplication1
{
    partial class cajero_automatico
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
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.btnretirar = new System.Windows.Forms.Button();
            this.txtcantidad2 = new System.Windows.Forms.TextBox();
            this.lblefectivo = new System.Windows.Forms.Label();
            this.btnprimo = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.btnfibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(12, 28);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(90, 13);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "cantidad  a pagar\r\n";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(108, 25);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 1;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(227, 28);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(53, 13);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "respuesta";
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(367, 9);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(84, 36);
            this.btnretirar.TabIndex = 3;
            this.btnretirar.Text = "RETIRAR";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // txtcantidad2
            // 
            this.txtcantidad2.Location = new System.Drawing.Point(108, 63);
            this.txtcantidad2.Name = "txtcantidad2";
            this.txtcantidad2.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad2.TabIndex = 4;
            // 
            // lblefectivo
            // 
            this.lblefectivo.AutoSize = true;
            this.lblefectivo.Location = new System.Drawing.Point(57, 66);
            this.lblefectivo.Name = "lblefectivo";
            this.lblefectivo.Size = new System.Drawing.Size(45, 13);
            this.lblefectivo.TabIndex = 5;
            this.lblefectivo.Text = "efectivo";
            // 
            // btnprimo
            // 
            this.btnprimo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimo.Location = new System.Drawing.Point(51, 149);
            this.btnprimo.Name = "btnprimo";
            this.btnprimo.Size = new System.Drawing.Size(84, 36);
            this.btnprimo.TabIndex = 6;
            this.btnprimo.Text = "N° Primo";
            this.btnprimo.UseVisualStyleBackColor = true;
            this.btnprimo.Click += new System.EventHandler(this.btnprimo_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(179, 146);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 7;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(330, 149);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(53, 13);
            this.lblres.TabIndex = 8;
            this.lblres.Text = "respuesta";
            // 
            // btnfibo
            // 
            this.btnfibo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfibo.Location = new System.Drawing.Point(177, 221);
            this.btnfibo.Name = "btnfibo";
            this.btnfibo.Size = new System.Drawing.Size(102, 36);
            this.btnfibo.TabIndex = 9;
            this.btnfibo.Text = "Fibonacci";
            this.btnfibo.UseVisualStyleBackColor = true;
            this.btnfibo.Click += new System.EventHandler(this.btnfibo_Click);
            // 
            // cajero_automatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.btnfibo);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnprimo);
            this.Controls.Add(this.lblefectivo);
            this.Controls.Add(this.txtcantidad2);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cajero_automatico";
            this.Text = "Cajero Automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.TextBox txtcantidad2;
        private System.Windows.Forms.Label lblefectivo;
        private System.Windows.Forms.Button btnprimo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnfibo;
    }
}

