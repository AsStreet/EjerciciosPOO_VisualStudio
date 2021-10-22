
namespace EjerciciosPOO
{
    partial class PruebaCoche
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
            this.btnEditarColor = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregarCoche = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txPuertas = new System.Windows.Forms.TextBox();
            this.txCaballos = new System.Windows.Forms.TextBox();
            this.txColor = new System.Windows.Forms.TextBox();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.lblTituloPuertas = new System.Windows.Forms.Label();
            this.lblTituloCaballos = new System.Windows.Forms.Label();
            this.lblTituloColor = new System.Windows.Forms.Label();
            this.lblTituloModelo = new System.Windows.Forms.Label();
            this.lblTituloMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditarColor
            // 
            this.btnEditarColor.Location = new System.Drawing.Point(245, 110);
            this.btnEditarColor.Name = "btnEditarColor";
            this.btnEditarColor.Size = new System.Drawing.Size(100, 23);
            this.btnEditarColor.TabIndex = 43;
            this.btnEditarColor.Text = "Modificar Color";
            this.btnEditarColor.UseVisualStyleBackColor = true;
            this.btnEditarColor.Click += new System.EventHandler(this.btnEditarColor_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(166, 260);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 42;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(85, 260);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 41;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(166, 231);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 40;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregarCoche
            // 
            this.btnAgregarCoche.Location = new System.Drawing.Point(85, 231);
            this.btnAgregarCoche.Name = "btnAgregarCoche";
            this.btnAgregarCoche.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCoche.TabIndex = 39;
            this.btnAgregarCoche.Text = "Agregar";
            this.btnAgregarCoche.UseVisualStyleBackColor = true;
            this.btnAgregarCoche.Click += new System.EventHandler(this.btnAgregarCoche_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(117, 215);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 38;
            // 
            // txPuertas
            // 
            this.txPuertas.Location = new System.Drawing.Point(112, 183);
            this.txPuertas.Name = "txPuertas";
            this.txPuertas.Size = new System.Drawing.Size(108, 20);
            this.txPuertas.TabIndex = 37;
            // 
            // txCaballos
            // 
            this.txCaballos.Location = new System.Drawing.Point(112, 146);
            this.txCaballos.Name = "txCaballos";
            this.txCaballos.Size = new System.Drawing.Size(108, 20);
            this.txCaballos.TabIndex = 36;
            // 
            // txColor
            // 
            this.txColor.Location = new System.Drawing.Point(112, 110);
            this.txColor.Name = "txColor";
            this.txColor.Size = new System.Drawing.Size(108, 20);
            this.txColor.TabIndex = 35;
            // 
            // txModelo
            // 
            this.txModelo.Location = new System.Drawing.Point(112, 71);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(108, 20);
            this.txModelo.TabIndex = 34;
            // 
            // txMarca
            // 
            this.txMarca.Location = new System.Drawing.Point(112, 33);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(108, 20);
            this.txMarca.TabIndex = 33;
            // 
            // lblTituloPuertas
            // 
            this.lblTituloPuertas.AutoSize = true;
            this.lblTituloPuertas.Location = new System.Drawing.Point(37, 186);
            this.lblTituloPuertas.Name = "lblTituloPuertas";
            this.lblTituloPuertas.Size = new System.Drawing.Size(49, 13);
            this.lblTituloPuertas.TabIndex = 32;
            this.lblTituloPuertas.Text = "Puertas: ";
            // 
            // lblTituloCaballos
            // 
            this.lblTituloCaballos.AutoSize = true;
            this.lblTituloCaballos.Location = new System.Drawing.Point(37, 149);
            this.lblTituloCaballos.Name = "lblTituloCaballos";
            this.lblTituloCaballos.Size = new System.Drawing.Size(53, 13);
            this.lblTituloCaballos.TabIndex = 31;
            this.lblTituloCaballos.Text = "Caballos: ";
            // 
            // lblTituloColor
            // 
            this.lblTituloColor.AutoSize = true;
            this.lblTituloColor.Location = new System.Drawing.Point(37, 113);
            this.lblTituloColor.Name = "lblTituloColor";
            this.lblTituloColor.Size = new System.Drawing.Size(37, 13);
            this.lblTituloColor.TabIndex = 30;
            this.lblTituloColor.Text = "Color: ";
            // 
            // lblTituloModelo
            // 
            this.lblTituloModelo.AutoSize = true;
            this.lblTituloModelo.Location = new System.Drawing.Point(37, 74);
            this.lblTituloModelo.Name = "lblTituloModelo";
            this.lblTituloModelo.Size = new System.Drawing.Size(48, 13);
            this.lblTituloModelo.TabIndex = 29;
            this.lblTituloModelo.Text = "Modelo: ";
            // 
            // lblTituloMarca
            // 
            this.lblTituloMarca.AutoSize = true;
            this.lblTituloMarca.Location = new System.Drawing.Point(37, 36);
            this.lblTituloMarca.Name = "lblTituloMarca";
            this.lblTituloMarca.Size = new System.Drawing.Size(43, 13);
            this.lblTituloMarca.TabIndex = 28;
            this.lblTituloMarca.Text = "Marca: ";
            // 
            // PruebaCoche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 303);
            this.Controls.Add(this.btnEditarColor);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregarCoche);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txPuertas);
            this.Controls.Add(this.txCaballos);
            this.Controls.Add(this.txColor);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.txMarca);
            this.Controls.Add(this.lblTituloPuertas);
            this.Controls.Add(this.lblTituloCaballos);
            this.Controls.Add(this.lblTituloColor);
            this.Controls.Add(this.lblTituloModelo);
            this.Controls.Add(this.lblTituloMarca);
            this.Name = "PruebaCoche";
            this.Text = "PruebaCoche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarColor;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregarCoche;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txPuertas;
        private System.Windows.Forms.TextBox txCaballos;
        private System.Windows.Forms.TextBox txColor;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.Label lblTituloPuertas;
        private System.Windows.Forms.Label lblTituloCaballos;
        private System.Windows.Forms.Label lblTituloColor;
        private System.Windows.Forms.Label lblTituloModelo;
        private System.Windows.Forms.Label lblTituloMarca;
    }
}