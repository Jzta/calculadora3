namespace calculadora3
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
            this.textBoxEcuacion1 = new System.Windows.Forms.TextBox();
            this.textBoxEcuacion2 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEcuacion1
            // 
            this.textBoxEcuacion1.Location = new System.Drawing.Point(282, 133);
            this.textBoxEcuacion1.Name = "textBoxEcuacion1";
            this.textBoxEcuacion1.Size = new System.Drawing.Size(237, 20);
            this.textBoxEcuacion1.TabIndex = 0;
            // 
            // textBoxEcuacion2
            // 
            this.textBoxEcuacion2.Location = new System.Drawing.Point(282, 188);
            this.textBoxEcuacion2.Name = "textBoxEcuacion2";
            this.textBoxEcuacion2.Size = new System.Drawing.Size(238, 20);
            this.textBoxEcuacion2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(282, 238);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(238, 61);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "CALCULAR";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(374, 332);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(35, 13);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "label1";
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESCRIBA SU ECUACIÓN 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ESCRIBA SU ECUACIÓN 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxEcuacion2);
            this.Controls.Add(this.textBoxEcuacion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEcuacion1;
        private System.Windows.Forms.TextBox textBoxEcuacion2;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

