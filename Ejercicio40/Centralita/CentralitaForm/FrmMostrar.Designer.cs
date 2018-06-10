namespace CentralitaForm
{
    partial class FrmMostrar
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
            this.richtxtMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtxtMostrar
            // 
            this.richtxtMostrar.Location = new System.Drawing.Point(0, 0);
            this.richtxtMostrar.Name = "richtxtMostrar";
            this.richtxtMostrar.ReadOnly = true;
            this.richtxtMostrar.Size = new System.Drawing.Size(250, 143);
            this.richtxtMostrar.TabIndex = 0;
            this.richtxtMostrar.Text = "";
            this.richtxtMostrar.TextChanged += new System.EventHandler(this.richtxtMostrar_TextChanged);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 140);
            this.Controls.Add(this.richtxtMostrar);
            this.Name = "FrmMostrar";
            this.Text = "Mostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtMostrar;
    }
}