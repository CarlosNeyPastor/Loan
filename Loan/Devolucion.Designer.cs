namespace Loan
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxIDPrestamo = new System.Windows.Forms.TextBox();
            this.lblIDPrestamo = new System.Windows.Forms.Label();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(157, 75);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 17);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "v 0.3";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(12, 9);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(166, 97);
            this.lblLoan.TabIndex = 20;
            this.lblLoan.Text = "Loan";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxIDPrestamo
            // 
            this.textBoxIDPrestamo.Location = new System.Drawing.Point(145, 126);
            this.textBoxIDPrestamo.Name = "textBoxIDPrestamo";
            this.textBoxIDPrestamo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDPrestamo.TabIndex = 24;
            // 
            // lblIDPrestamo
            // 
            this.lblIDPrestamo.AutoSize = true;
            this.lblIDPrestamo.Location = new System.Drawing.Point(26, 129);
            this.lblIDPrestamo.Name = "lblIDPrestamo";
            this.lblIDPrestamo.Size = new System.Drawing.Size(82, 13);
            this.lblIDPrestamo.TabIndex = 23;
            this.lblIDPrestamo.Text = "ID de prestamo:";
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(100, 172);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(75, 23);
            this.btnDevolucion.TabIndex = 22;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 220);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBoxIDPrestamo);
            this.Controls.Add(this.lblIDPrestamo);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxIDPrestamo;
        private System.Windows.Forms.Label lblIDPrestamo;
        private System.Windows.Forms.Button btnDevolucion;
    }
}