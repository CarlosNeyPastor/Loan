namespace Loan
{
    partial class Prestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBoxIDDispositivo = new System.Windows.Forms.TextBox();
            this.lblIDDispositivo = new System.Windows.Forms.Label();
            this.textBoxDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.textBoxDevolucion = new System.Windows.Forms.TextBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(157, 75);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 17);
            this.lblVersion.TabIndex = 23;
            this.lblVersion.Text = "v 0.3";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(12, 9);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(166, 97);
            this.lblLoan.TabIndex = 22;
            this.lblLoan.Text = "Loan";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(175, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtBoxIDDispositivo
            // 
            this.txtBoxIDDispositivo.Location = new System.Drawing.Point(148, 123);
            this.txtBoxIDDispositivo.Name = "txtBoxIDDispositivo";
            this.txtBoxIDDispositivo.Size = new System.Drawing.Size(186, 20);
            this.txtBoxIDDispositivo.TabIndex = 29;
            // 
            // lblIDDispositivo
            // 
            this.lblIDDispositivo.AutoSize = true;
            this.lblIDDispositivo.Location = new System.Drawing.Point(29, 126);
            this.lblIDDispositivo.Name = "lblIDDispositivo";
            this.lblIDDispositivo.Size = new System.Drawing.Size(88, 13);
            this.lblIDDispositivo.TabIndex = 28;
            this.lblIDDispositivo.Text = "ID de dispositivo:";
            // 
            // textBoxDepartamento
            // 
            this.textBoxDepartamento.Location = new System.Drawing.Point(148, 158);
            this.textBoxDepartamento.Name = "textBoxDepartamento";
            this.textBoxDepartamento.Size = new System.Drawing.Size(186, 20);
            this.textBoxDepartamento.TabIndex = 31;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(29, 161);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 30;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 33;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(29, 200);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(38, 13);
            this.lblPersona.TabIndex = 32;
            this.lblPersona.Text = "Retira:";
            // 
            // textBoxDevolucion
            // 
            this.textBoxDevolucion.Location = new System.Drawing.Point(148, 239);
            this.textBoxDevolucion.Name = "textBoxDevolucion";
            this.textBoxDevolucion.Size = new System.Drawing.Size(186, 20);
            this.textBoxDevolucion.TabIndex = 35;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Location = new System.Drawing.Point(29, 242);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(64, 13);
            this.lblDevolucion.TabIndex = 34;
            this.lblDevolucion.Text = "Devolución:";
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 332);
            this.Controls.Add(this.textBoxDevolucion);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.textBoxDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtBoxIDDispositivo);
            this.Controls.Add(this.lblIDDispositivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prestamo";
            this.Text = "Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtBoxIDDispositivo;
        private System.Windows.Forms.Label lblIDDispositivo;
        private System.Windows.Forms.TextBox textBoxDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.TextBox textBoxDevolucion;
        private System.Windows.Forms.Label lblDevolucion;
    }
}