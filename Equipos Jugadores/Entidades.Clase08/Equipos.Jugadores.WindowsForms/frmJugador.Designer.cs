namespace Equipos.Jugadores.WindowsForms
{
    partial class frmJugador
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPartidosJugados = new System.Windows.Forms.Label();
            this.lblGoles = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPartidosJugados = new System.Windows.Forms.TextBox();
            this.txtGoles = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(23, 14);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPartidosJugados
            // 
            this.lblPartidosJugados.AutoSize = true;
            this.lblPartidosJugados.Location = new System.Drawing.Point(22, 123);
            this.lblPartidosJugados.Name = "lblPartidosJugados";
            this.lblPartidosJugados.Size = new System.Drawing.Size(88, 13);
            this.lblPartidosJugados.TabIndex = 2;
            this.lblPartidosJugados.Text = "Partidos Jugados";
            // 
            // lblGoles
            // 
            this.lblGoles.AutoSize = true;
            this.lblGoles.Location = new System.Drawing.Point(22, 180);
            this.lblGoles.Name = "lblGoles";
            this.lblGoles.Size = new System.Drawing.Size(34, 13);
            this.lblGoles.TabIndex = 3;
            this.lblGoles.Text = "Goles";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(26, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(146, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPartidosJugados
            // 
            this.txtPartidosJugados.Location = new System.Drawing.Point(26, 139);
            this.txtPartidosJugados.Name = "txtPartidosJugados";
            this.txtPartidosJugados.Size = new System.Drawing.Size(146, 20);
            this.txtPartidosJugados.TabIndex = 3;
            // 
            // txtGoles
            // 
            this.txtGoles.Location = new System.Drawing.Point(26, 196);
            this.txtGoles.Name = "txtGoles";
            this.txtGoles.Size = new System.Drawing.Size(146, 20);
            this.txtGoles.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(103, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 288);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtGoles);
            this.Controls.Add(this.txtPartidosJugados);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblGoles);
            this.Controls.Add(this.lblPartidosJugados);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Name = "frmJugador";
            this.Text = "Jugador";
            this.Load += new System.EventHandler(this.frmJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPartidosJugados;
        private System.Windows.Forms.Label lblGoles;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPartidosJugados;
        private System.Windows.Forms.TextBox txtGoles;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

