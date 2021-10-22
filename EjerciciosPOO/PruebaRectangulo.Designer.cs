
namespace EjerciciosPOO
{
    partial class PruebaRectangulo
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
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTituloPerimetro = new System.Windows.Forms.Label();
            this.lblTituloArea = new System.Windows.Forms.Label();
            this.txBase = new System.Windows.Forms.TextBox();
            this.txAltura = new System.Windows.Forms.TextBox();
            this.lblTituloBase = new System.Windows.Forms.Label();
            this.lblTituloAltura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(223, 154);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(108, 23);
            this.btnPerimetro.TabIndex = 19;
            this.btnPerimetro.Text = "Calcular Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(223, 118);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(108, 23);
            this.btnArea.TabIndex = 18;
            this.btnArea.Text = "Calcular Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(157, 159);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 17;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(157, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 16;
            // 
            // lblTituloPerimetro
            // 
            this.lblTituloPerimetro.AutoSize = true;
            this.lblTituloPerimetro.Location = new System.Drawing.Point(69, 159);
            this.lblTituloPerimetro.Name = "lblTituloPerimetro";
            this.lblTituloPerimetro.Size = new System.Drawing.Size(59, 13);
            this.lblTituloPerimetro.TabIndex = 15;
            this.lblTituloPerimetro.Text = "Perímetro: ";
            // 
            // lblTituloArea
            // 
            this.lblTituloArea.AutoSize = true;
            this.lblTituloArea.Location = new System.Drawing.Point(96, 123);
            this.lblTituloArea.Name = "lblTituloArea";
            this.lblTituloArea.Size = new System.Drawing.Size(32, 13);
            this.lblTituloArea.TabIndex = 14;
            this.lblTituloArea.Text = "Área:";
            // 
            // txBase
            // 
            this.txBase.Location = new System.Drawing.Point(141, 83);
            this.txBase.Name = "txBase";
            this.txBase.Size = new System.Drawing.Size(51, 20);
            this.txBase.TabIndex = 13;
            // 
            // txAltura
            // 
            this.txAltura.Location = new System.Drawing.Point(141, 46);
            this.txAltura.Name = "txAltura";
            this.txAltura.Size = new System.Drawing.Size(51, 20);
            this.txAltura.TabIndex = 12;
            // 
            // lblTituloBase
            // 
            this.lblTituloBase.AutoSize = true;
            this.lblTituloBase.Location = new System.Drawing.Point(33, 83);
            this.lblTituloBase.Name = "lblTituloBase";
            this.lblTituloBase.Size = new System.Drawing.Size(95, 13);
            this.lblTituloBase.TabIndex = 11;
            this.lblTituloBase.Text = "Introduce la base: ";
            // 
            // lblTituloAltura
            // 
            this.lblTituloAltura.AutoSize = true;
            this.lblTituloAltura.Location = new System.Drawing.Point(33, 46);
            this.lblTituloAltura.Name = "lblTituloAltura";
            this.lblTituloAltura.Size = new System.Drawing.Size(98, 13);
            this.lblTituloAltura.TabIndex = 10;
            this.lblTituloAltura.Text = "Introduce la altura: ";
            // 
            // PruebaRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 233);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblTituloPerimetro);
            this.Controls.Add(this.lblTituloArea);
            this.Controls.Add(this.txBase);
            this.Controls.Add(this.txAltura);
            this.Controls.Add(this.lblTituloBase);
            this.Controls.Add(this.lblTituloAltura);
            this.Name = "PruebaRectangulo";
            this.Text = "PruebaRectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTituloPerimetro;
        private System.Windows.Forms.Label lblTituloArea;
        private System.Windows.Forms.TextBox txBase;
        private System.Windows.Forms.TextBox txAltura;
        private System.Windows.Forms.Label lblTituloBase;
        private System.Windows.Forms.Label lblTituloAltura;
    }
}