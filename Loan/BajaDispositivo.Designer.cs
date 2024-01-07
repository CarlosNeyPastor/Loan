namespace Loan
{
    partial class BajaDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaDispositivo));
            this.btnBaja = new System.Windows.Forms.Button();
            this.lblIDDispositivo = new System.Windows.Forms.Label();
            this.textBoxIDDispositivo = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(106, 163);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Dar baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // lblIDDispositivo
            // 
            this.lblIDDispositivo.AutoSize = true;
            this.lblIDDispositivo.Location = new System.Drawing.Point(32, 120);
            this.lblIDDispositivo.Name = "lblIDDispositivo";
            this.lblIDDispositivo.Size = new System.Drawing.Size(88, 13);
            this.lblIDDispositivo.TabIndex = 1;
            this.lblIDDispositivo.Text = "ID de dispositivo:";
            // 
            // textBoxIDDispositivo
            // 
            this.textBoxIDDispositivo.Location = new System.Drawing.Point(151, 117);
            this.textBoxIDDispositivo.Name = "textBoxIDDispositivo";
            this.textBoxIDDispositivo.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDDispositivo.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(148, 64);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(33, 17);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "v 0.3";
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Agency FB", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan.Location = new System.Drawing.Point(3, -2);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(166, 97);
            this.lblLoan.TabIndex = 18;
            this.lblLoan.Text = "Loan";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BajaDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 209);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.textBoxIDDispositivo);
            this.Controls.Add(this.lblIDDispositivo);
            this.Controls.Add(this.btnBaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaDispositivo";
            this.Text = "Baja de dispositivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label lblIDDispositivo;
        private System.Windows.Forms.TextBox textBoxIDDispositivo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button btnCancelar;
    }
}