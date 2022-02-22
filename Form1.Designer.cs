namespace Ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPantalla = new System.Windows.Forms.TextBox();
            this.BtnAC = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.BtnPorcentaje = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnSiete = new System.Windows.Forms.Button();
            this.BtnOcho = new System.Windows.Forms.Button();
            this.BtnNueve = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPantalla
            // 
            this.TxtPantalla.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPantalla.Location = new System.Drawing.Point(12, 10);
            this.TxtPantalla.MaxLength = 20;
            this.TxtPantalla.Name = "TxtPantalla";
            this.TxtPantalla.ReadOnly = true;
            this.TxtPantalla.Size = new System.Drawing.Size(318, 39);
            this.TxtPantalla.TabIndex = 0;
            this.TxtPantalla.Text = "0";
            this.TxtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAC
            // 
            this.BtnAC.Location = new System.Drawing.Point(12, 55);
            this.BtnAC.Name = "BtnAC";
            this.BtnAC.Size = new System.Drawing.Size(75, 23);
            this.BtnAC.TabIndex = 1;
            this.BtnAC.Text = "AC";
            this.BtnAC.UseVisualStyleBackColor = true;
            this.BtnAC.Click += new System.EventHandler(this.BtnAC_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(93, 55);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 23);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "+/-";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // BtnPorcentaje
            // 
            this.BtnPorcentaje.Location = new System.Drawing.Point(174, 55);
            this.BtnPorcentaje.Name = "BtnPorcentaje";
            this.BtnPorcentaje.Size = new System.Drawing.Size(75, 23);
            this.BtnPorcentaje.TabIndex = 3;
            this.BtnPorcentaje.Text = "%";
            this.BtnPorcentaje.UseVisualStyleBackColor = true;
            this.BtnPorcentaje.Click += new System.EventHandler(this.FuncOperador);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(255, 55);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 23);
            this.BtnDivision.TabIndex = 4;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.FuncOperador);
            // 
            // BtnSiete
            // 
            this.BtnSiete.Location = new System.Drawing.Point(12, 84);
            this.BtnSiete.Name = "BtnSiete";
            this.BtnSiete.Size = new System.Drawing.Size(75, 23);
            this.BtnSiete.TabIndex = 5;
            this.BtnSiete.Text = "7";
            this.BtnSiete.UseVisualStyleBackColor = true;
            this.BtnSiete.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnOcho
            // 
            this.BtnOcho.Location = new System.Drawing.Point(93, 84);
            this.BtnOcho.Name = "BtnOcho";
            this.BtnOcho.Size = new System.Drawing.Size(75, 23);
            this.BtnOcho.TabIndex = 6;
            this.BtnOcho.Text = "8";
            this.BtnOcho.UseVisualStyleBackColor = true;
            this.BtnOcho.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnNueve
            // 
            this.BtnNueve.Location = new System.Drawing.Point(174, 84);
            this.BtnNueve.Name = "BtnNueve";
            this.BtnNueve.Size = new System.Drawing.Size(75, 23);
            this.BtnNueve.TabIndex = 7;
            this.BtnNueve.Text = "9";
            this.BtnNueve.UseVisualStyleBackColor = true;
            this.BtnNueve.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Location = new System.Drawing.Point(255, 84);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiplicar.TabIndex = 8;
            this.BtnMultiplicar.Text = "*";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.FuncOperador);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.Location = new System.Drawing.Point(12, 113);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(75, 23);
            this.BtnCuatro.TabIndex = 9;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = true;
            this.BtnCuatro.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnCinco
            // 
            this.BtnCinco.Location = new System.Drawing.Point(93, 113);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(75, 23);
            this.BtnCinco.TabIndex = 10;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = true;
            this.BtnCinco.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnSeis
            // 
            this.BtnSeis.Location = new System.Drawing.Point(174, 113);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(75, 23);
            this.BtnSeis.TabIndex = 11;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = true;
            this.BtnSeis.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Location = new System.Drawing.Point(255, 113);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(75, 23);
            this.BtnMenos.TabIndex = 12;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.FuncOperador);
            // 
            // BtnUno
            // 
            this.BtnUno.Location = new System.Drawing.Point(12, 142);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(75, 23);
            this.BtnUno.TabIndex = 13;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnDos
            // 
            this.BtnDos.Location = new System.Drawing.Point(93, 142);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(75, 23);
            this.BtnDos.TabIndex = 14;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = true;
            this.BtnDos.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnTres
            // 
            this.BtnTres.Location = new System.Drawing.Point(174, 142);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(75, 23);
            this.BtnTres.TabIndex = 15;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(255, 142);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 16;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.FuncOperador);
            // 
            // BtnCero
            // 
            this.BtnCero.Location = new System.Drawing.Point(12, 171);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(156, 23);
            this.BtnCero.TabIndex = 17;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = true;
            this.BtnCero.Click += new System.EventHandler(this.FuncAgregar);
            // 
            // BtnPunto
            // 
            this.BtnPunto.Location = new System.Drawing.Point(174, 171);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(75, 23);
            this.BtnPunto.TabIndex = 18;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click);
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(255, 171);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(75, 23);
            this.BtnResultado.TabIndex = 19;
            this.BtnResultado.Text = "=";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(345, 214);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.BtnPunto);
            this.Controls.Add(this.BtnCero);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnDos);
            this.Controls.Add(this.BtnUno);
            this.Controls.Add(this.BtnMenos);
            this.Controls.Add(this.BtnSeis);
            this.Controls.Add(this.BtnCinco);
            this.Controls.Add(this.BtnCuatro);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnNueve);
            this.Controls.Add(this.BtnOcho);
            this.Controls.Add(this.BtnSiete);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPorcentaje);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnAC);
            this.Controls.Add(this.TxtPantalla);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtPantalla;
        private Button BtnAC;
        private Button BtnConvert;
        private Button BtnPorcentaje;
        private Button BtnDivision;
        private Button BtnSiete;
        private Button BtnOcho;
        private Button BtnNueve;
        private Button BtnMultiplicar;
        private Button BtnCuatro;
        private Button BtnCinco;
        private Button BtnSeis;
        private Button BtnMenos;
        private Button BtnUno;
        private Button BtnDos;
        private Button BtnTres;
        private Button BtnSuma;
        private Button BtnCero;
        private Button BtnPunto;
        private Button BtnResultado;
    }
}