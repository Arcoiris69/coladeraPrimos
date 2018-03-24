namespace Coladera_de_Eratostenes
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
            this.txtPrimos = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnDale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimos
            // 
            this.txtPrimos.Location = new System.Drawing.Point(50, 68);
            this.txtPrimos.Multiline = true;
            this.txtPrimos.Name = "txtPrimos";
            this.txtPrimos.ReadOnly = true;
            this.txtPrimos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrimos.Size = new System.Drawing.Size(938, 474);
            this.txtPrimos.TabIndex = 0;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(197, 42);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 20);
            this.txtVal.TabIndex = 1;
            // 
            // btnDale
            // 
            this.btnDale.Location = new System.Drawing.Point(388, 38);
            this.btnDale.Name = "btnDale";
            this.btnDale.Size = new System.Drawing.Size(75, 23);
            this.btnDale.TabIndex = 2;
            this.btnDale.Text = "button1";
            this.btnDale.UseVisualStyleBackColor = true;
            this.btnDale.Click += new System.EventHandler(this.btnDale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 554);
            this.Controls.Add(this.btnDale);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtPrimos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimos;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnDale;
    }
}

