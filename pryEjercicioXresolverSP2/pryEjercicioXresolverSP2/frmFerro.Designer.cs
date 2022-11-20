namespace pryEjercicioXresolverSP2
{
    partial class frmFerro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerro));
            this.grpBienvenido = new System.Windows.Forms.GroupBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblDías = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.nmrDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.grpCosto = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontoPrecio = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.grpBienvenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).BeginInit();
            this.grpCosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBienvenido
            // 
            this.grpBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.grpBienvenido.Controls.Add(this.lblBienvenido);
            this.grpBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBienvenido.Location = new System.Drawing.Point(119, 35);
            this.grpBienvenido.Name = "grpBienvenido";
            this.grpBienvenido.Size = new System.Drawing.Size(404, 83);
            this.grpBienvenido.TabIndex = 10;
            this.grpBienvenido.TabStop = false;
            this.grpBienvenido.Text = ".";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(32, 27);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(349, 32);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO A FERRO";
            // 
            // lblDías
            // 
            this.lblDías.AutoSize = true;
            this.lblDías.BackColor = System.Drawing.Color.Transparent;
            this.lblDías.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDías.Location = new System.Drawing.Point(190, 182);
            this.lblDías.Name = "lblDías";
            this.lblDías.Size = new System.Drawing.Size(35, 16);
            this.lblDías.TabIndex = 11;
            this.lblDías.Text = "Días";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lblDistancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDistancia.Location = new System.Drawing.Point(190, 221);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(63, 16);
            this.lblDistancia.TabIndex = 12;
            this.lblDistancia.Text = "Distancia";
            // 
            // nmrDias
            // 
            this.nmrDias.Location = new System.Drawing.Point(259, 180);
            this.nmrDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDias.Name = "nmrDias";
            this.nmrDias.Size = new System.Drawing.Size(65, 22);
            this.nmrDias.TabIndex = 13;
            this.nmrDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(259, 218);
            this.txtDistancia.MaxLength = 30;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(88, 22);
            this.txtDistancia.TabIndex = 14;
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // grpCosto
            // 
            this.grpCosto.BackColor = System.Drawing.Color.Transparent;
            this.grpCosto.Controls.Add(this.btnCalcular);
            this.grpCosto.Controls.Add(this.lblPrecio);
            this.grpCosto.Controls.Add(this.lblTotal);
            this.grpCosto.Controls.Add(this.lblMontoPrecio);
            this.grpCosto.Controls.Add(this.lblMontoTotal);
            this.grpCosto.ForeColor = System.Drawing.Color.Black;
            this.grpCosto.Location = new System.Drawing.Point(119, 260);
            this.grpCosto.Name = "grpCosto";
            this.grpCosto.Size = new System.Drawing.Size(469, 159);
            this.grpCosto.TabIndex = 15;
            this.grpCosto.TabStop = false;
            this.grpCosto.Text = "COSTO";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 99);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 36);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio.Location = new System.Drawing.Point(39, 34);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(39, 67);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblMontoPrecio
            // 
            this.lblMontoPrecio.AutoSize = true;
            this.lblMontoPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontoPrecio.Location = new System.Drawing.Point(109, 34);
            this.lblMontoPrecio.Name = "lblMontoPrecio";
            this.lblMontoPrecio.Size = new System.Drawing.Size(63, 16);
            this.lblMontoPrecio.TabIndex = 1;
            this.lblMontoPrecio.Text = "________";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontoTotal.Location = new System.Drawing.Point(109, 67);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(63, 16);
            this.lblMontoTotal.TabIndex = 3;
            this.lblMontoTotal.Text = "________";
            // 
            // frmFerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEjercicioXresolverSP2.Properties.Resources.Ferrocarril_imagen;
            this.ClientSize = new System.Drawing.Size(639, 627);
            this.Controls.Add(this.grpCosto);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.nmrDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDías);
            this.Controls.Add(this.grpBienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFerro";
            this.Text = " Ferro - Ferrocarriles";
            this.grpBienvenido.ResumeLayout(false);
            this.grpBienvenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).EndInit();
            this.grpCosto.ResumeLayout(false);
            this.grpCosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBienvenido;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblDías;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.NumericUpDown nmrDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox grpCosto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontoPrecio;
        private System.Windows.Forms.Label lblMontoTotal;
    }
}

