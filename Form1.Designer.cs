namespace ArreglosMultidimensionales_G2_2024_II
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
            this.txtbDisplay = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.lbOperando1 = new System.Windows.Forms.Label();
            this.lbOperando2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtbDisplay
            // 
            this.txtbDisplay.Location = new System.Drawing.Point(62, 55);
            this.txtbDisplay.Name = "txtbDisplay";
            this.txtbDisplay.Size = new System.Drawing.Size(727, 22);
            this.txtbDisplay.TabIndex = 0;
            this.txtbDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDisplay_KeyPress);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(62, 207);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(140, 132);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(253, 207);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(140, 132);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(429, 207);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(140, 132);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(626, 207);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(163, 132);
            this.btnSeno.TabIndex = 1;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            // 
            // lbOperando1
            // 
            this.lbOperando1.AutoSize = true;
            this.lbOperando1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperando1.Location = new System.Drawing.Point(62, 105);
            this.lbOperando1.Name = "lbOperando1";
            this.lbOperando1.Size = new System.Drawing.Size(48, 60);
            this.lbOperando1.TabIndex = 2;
            this.lbOperando1.Text = "1 2\r\n3 4\r\n";
            // 
            // lbOperando2
            // 
            this.lbOperando2.AutoSize = true;
            this.lbOperando2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperando2.Location = new System.Drawing.Point(295, 105);
            this.lbOperando2.Name = "lbOperando2";
            this.lbOperando2.Size = new System.Drawing.Size(48, 60);
            this.lbOperando2.TabIndex = 2;
            this.lbOperando2.Text = "5 7\r\n9 2\r\n";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(656, 105);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(87, 78);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "6 9\r\n12 6\r\n";
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDeg.Location = new System.Drawing.Point(62, 12);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(70, 30);
            this.rdbDeg.TabIndex = 3;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "Deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRad.Location = new System.Drawing.Point(212, 12);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(70, 30);
            this.rdbRad.TabIndex = 3;
            this.rdbRad.TabStop = true;
            this.rdbRad.Text = "Rad";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 370);
            this.Controls.Add(this.rdbRad);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbOperando2);
            this.Controls.Add(this.lbOperando1);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDisplay;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Label lbOperando1;
        private System.Windows.Forms.Label lbOperando2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.RadioButton rdbRad;
    }
}

