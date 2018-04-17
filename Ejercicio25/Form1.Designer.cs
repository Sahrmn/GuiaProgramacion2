namespace Ejercicio25
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBin1 = new System.Windows.Forms.TextBox();
            this.txtDec1 = new System.Windows.Forms.TextBox();
            this.txtDec2 = new System.Windows.Forms.TextBox();
            this.txtBin2 = new System.Windows.Forms.TextBox();
            this.btnConverBin = new System.Windows.Forms.Button();
            this.btnConverDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal a Binario";
            // 
            // txtBin1
            // 
            this.txtBin1.Location = new System.Drawing.Point(140, 40);
            this.txtBin1.Name = "txtBin1";
            this.txtBin1.Size = new System.Drawing.Size(100, 20);
            this.txtBin1.TabIndex = 2;
            // 
            // txtDec1
            // 
            this.txtDec1.Location = new System.Drawing.Point(140, 75);
            this.txtDec1.Name = "txtDec1";
            this.txtDec1.Size = new System.Drawing.Size(100, 20);
            this.txtDec1.TabIndex = 3;
            // 
            // txtDec2
            // 
            this.txtDec2.Enabled = false;
            this.txtDec2.Location = new System.Drawing.Point(345, 75);
            this.txtDec2.Name = "txtDec2";
            this.txtDec2.Size = new System.Drawing.Size(139, 20);
            this.txtDec2.TabIndex = 5;
            // 
            // txtBin2
            // 
            this.txtBin2.Enabled = false;
            this.txtBin2.Location = new System.Drawing.Point(345, 40);
            this.txtBin2.Name = "txtBin2";
            this.txtBin2.Size = new System.Drawing.Size(139, 20);
            this.txtBin2.TabIndex = 4;
            // 
            // btnConverBin
            // 
            this.btnConverBin.Location = new System.Drawing.Point(254, 38);
            this.btnConverBin.Name = "btnConverBin";
            this.btnConverBin.Size = new System.Drawing.Size(75, 23);
            this.btnConverBin.TabIndex = 6;
            this.btnConverBin.Text = "->";
            this.btnConverBin.UseVisualStyleBackColor = true;
            this.btnConverBin.Click += new System.EventHandler(this.btnConverBin_Click);
            // 
            // btnConverDec
            // 
            this.btnConverDec.Location = new System.Drawing.Point(254, 75);
            this.btnConverDec.Name = "btnConverDec";
            this.btnConverDec.Size = new System.Drawing.Size(75, 23);
            this.btnConverDec.TabIndex = 7;
            this.btnConverDec.Text = "->";
            this.btnConverDec.UseVisualStyleBackColor = true;
            this.btnConverDec.Click += new System.EventHandler(this.btnConverDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 135);
            this.Controls.Add(this.btnConverDec);
            this.Controls.Add(this.btnConverBin);
            this.Controls.Add(this.txtDec2);
            this.Controls.Add(this.txtBin2);
            this.Controls.Add(this.txtDec1);
            this.Controls.Add(this.txtBin1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBin1;
        private System.Windows.Forms.TextBox txtDec1;
        private System.Windows.Forms.TextBox txtDec2;
        private System.Windows.Forms.TextBox txtBin2;
        private System.Windows.Forms.Button btnConverBin;
        private System.Windows.Forms.Button btnConverDec;
    }
}

