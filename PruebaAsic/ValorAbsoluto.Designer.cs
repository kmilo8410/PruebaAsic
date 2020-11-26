namespace PruebaAsic
{
    partial class ValorAbsoluto
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
            this.btnValorAbsoluto = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValorAbsoluto
            // 
            this.btnValorAbsoluto.Location = new System.Drawing.Point(67, 68);
            this.btnValorAbsoluto.Name = "btnValorAbsoluto";
            this.btnValorAbsoluto.Size = new System.Drawing.Size(75, 23);
            this.btnValorAbsoluto.TabIndex = 0;
            this.btnValorAbsoluto.Text = "Obtener Valor absoluto";
            this.btnValorAbsoluto.UseVisualStyleBackColor = true;
            this.btnValorAbsoluto.Click += new System.EventHandler(this.btnValorAbsoluto_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(67, 30);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // ValorAbsoluto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnValorAbsoluto);
            this.Name = "ValorAbsoluto";
            this.Text = "ValorAbsoluto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValorAbsoluto;
        private System.Windows.Forms.TextBox txtValor;
    }
}