namespace AppCaculator.FE
{
    partial class frmCalculadora
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
            this.txtOperador1 = new System.Windows.Forms.TextBox();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btMultiplicacion = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOperador2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOperador1
            // 
            this.txtOperador1.BackColor = System.Drawing.Color.Silver;
            this.txtOperador1.Enabled = false;
            this.txtOperador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador1.Location = new System.Drawing.Point(12, 18);
            this.txtOperador1.Name = "txtOperador1";
            this.txtOperador1.Size = new System.Drawing.Size(319, 53);
            this.txtOperador1.TabIndex = 0;
            this.txtOperador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btSuma
            // 
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(13, 141);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 73);
            this.btSuma.TabIndex = 1;
            this.btSuma.Text = "&+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResta.Location = new System.Drawing.Point(94, 141);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(75, 73);
            this.btResta.TabIndex = 2;
            this.btResta.Text = "&-";
            this.btResta.UseVisualStyleBackColor = true;
            // 
            // btMultiplicacion
            // 
            this.btMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacion.Location = new System.Drawing.Point(175, 141);
            this.btMultiplicacion.Name = "btMultiplicacion";
            this.btMultiplicacion.Size = new System.Drawing.Size(75, 73);
            this.btMultiplicacion.TabIndex = 3;
            this.btMultiplicacion.Text = "&*";
            this.btMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(336, 157);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 53);
            this.btIgual.TabIndex = 4;
            this.btIgual.Text = "&=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btDivision
            // 
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(256, 141);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(75, 73);
            this.btDivision.TabIndex = 5;
            this.btDivision.Text = "&/";
            this.btDivision.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(13, 222);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(318, 53);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "&AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOperador2
            // 
            this.txtOperador2.BackColor = System.Drawing.Color.Silver;
            this.txtOperador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador2.Location = new System.Drawing.Point(12, 77);
            this.txtOperador2.Name = "txtOperador2";
            this.txtOperador2.Size = new System.Drawing.Size(317, 53);
            this.txtOperador2.TabIndex = 0;
            this.txtOperador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 328);
            this.Controls.Add(this.txtOperador2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMultiplicacion);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.txtOperador1);
            this.Name = "frmCalculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperador1;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btMultiplicacion;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOperador2;
    }
}

