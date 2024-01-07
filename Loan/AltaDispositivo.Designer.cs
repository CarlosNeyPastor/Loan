namespace Loan
{
    partial class AltaDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaDispositivo));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.textBoxNroSerie = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
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
            this.btnCancelar.Location = new System.Drawing.Point(250, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 128);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(26, 163);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 25;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Location = new System.Drawing.Point(26, 200);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(57, 13);
            this.lblNroSerie.TabIndex = 26;
            this.lblNroSerie.Text = "Nro. Serie:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(26, 233);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(26, 264);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(73, 13);
            this.lblTag.TabIndex = 28;
            this.lblTag.Text = "Tag/Etiqueta:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(121, 233);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(204, 21);
            this.comboBoxTipo.TabIndex = 29;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(121, 264);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(204, 20);
            this.textBoxTag.TabIndex = 30;
            // 
            // textBoxNroSerie
            // 
            this.textBoxNroSerie.Location = new System.Drawing.Point(121, 200);
            this.textBoxNroSerie.Name = "textBoxNroSerie";
            this.textBoxNroSerie.Size = new System.Drawing.Size(204, 20);
            this.textBoxNroSerie.TabIndex = 31;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(121, 163);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(204, 20);
            this.textBoxModelo.TabIndex = 32;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(121, 128);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(204, 20);
            this.textBoxMarca.TabIndex = 33;
            // 
            // AltaDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 372);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxNroSerie);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNroSerie);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaDispositivo";
            this.Text = "Alta de dispositivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblNroSerie;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.TextBox textBoxNroSerie;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
    }
}