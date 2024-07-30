namespace presentacion
{
    partial class formInfoArticulo
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(136, 31);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(332, 276);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 0;
            this.pbxArticulo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(126, 320);
            this.lblNombre.MinimumSize = new System.Drawing.Size(352, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(352, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del artículo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(285, 356);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(34, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "AAA";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(126, 423);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(352, 53);
            this.lblDescripcion.MinimumSize = new System.Drawing.Size(352, 53);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(2);
            this.lblDescripcion.Size = new System.Drawing.Size(352, 53);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción.";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(179, 372);
            this.lblMarca.MaximumSize = new System.Drawing.Size(100, 20);
            this.lblMarca.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(100, 20);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(325, 372);
            this.lblCategoria.MaximumSize = new System.Drawing.Size(100, 20);
            this.lblCategoria.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 20);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(126, 510);
            this.lblPrecio.MinimumSize = new System.Drawing.Size(352, 29);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(352, 29);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "$99999,99";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(259, 577);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formInfoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 637);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbxArticulo);
            this.MaximizeBox = false;
            this.Name = "formInfoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del artículo";
            this.Load += new System.EventHandler(this.formInfoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnVolver;
    }
}