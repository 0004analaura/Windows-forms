namespace Prestamos
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
            this.montotxt = new System.Windows.Forms.TextBox();
            this.tasatxt = new System.Windows.Forms.TextBox();
            this.pagotxt = new System.Windows.Forms.TextBox();
            this.Cuota = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuotas de un prestamo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // montotxt
            // 
            this.montotxt.Location = new System.Drawing.Point(241, 85);
            this.montotxt.Name = "montotxt";
            this.montotxt.Size = new System.Drawing.Size(309, 22);
            this.montotxt.TabIndex = 1;
            // 
            // tasatxt
            // 
            this.tasatxt.Location = new System.Drawing.Point(241, 127);
            this.tasatxt.Name = "tasatxt";
            this.tasatxt.Size = new System.Drawing.Size(309, 22);
            this.tasatxt.TabIndex = 2;
            // 
            // pagotxt
            // 
            this.pagotxt.Location = new System.Drawing.Point(241, 178);
            this.pagotxt.Name = "pagotxt";
            this.pagotxt.Size = new System.Drawing.Size(309, 22);
            this.pagotxt.TabIndex = 3;
            // 
            // Cuota
            // 
            this.Cuota.Location = new System.Drawing.Point(241, 348);
            this.Cuota.Name = "Cuota";
            this.Cuota.Size = new System.Drawing.Size(309, 22);
            this.Cuota.TabIndex = 4;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Calcular.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(319, 232);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(143, 63);
            this.Calcular.TabIndex = 5;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Cuota);
            this.Controls.Add(this.pagotxt);
            this.Controls.Add(this.tasatxt);
            this.Controls.Add(this.montotxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox montotxt;
        private System.Windows.Forms.TextBox tasatxt;
        private System.Windows.Forms.TextBox pagotxt;
        private System.Windows.Forms.TextBox Cuota;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

