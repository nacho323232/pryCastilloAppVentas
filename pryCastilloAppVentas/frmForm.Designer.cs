namespace pryCastilloAppVentas
{
    partial class frmForm
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
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnCancelar = new Button();
            lstProducto = new ComboBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(14, 15);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            lblFecha.Click += label1_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.Location = new Point(14, 57);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(65, 19);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(14, 103);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(64, 19);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F);
            lblPrecio.Location = new Point(12, 154);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(97, 19);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio unitario";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(272, 215);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 33);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.TextChanged += btnRegistrar_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(134, 9);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(240, 25);
            dtpFecha.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(134, 103);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(240, 25);
            txtCantidad.TabIndex = 8;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.Location = new Point(134, 154);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(240, 25);
            txtPrecio.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(164, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.TextChanged += btnCancelar_TextChanged;
            // 
            // lstProducto
            // 
            lstProducto.Font = new Font("Segoe UI", 10F);
            lstProducto.FormattingEnabled = true;
            lstProducto.Location = new Point(134, 57);
            lstProducto.Name = "lstProducto";
            lstProducto.Size = new Size(240, 25);
            lstProducto.TabIndex = 11;
            lstProducto.TextChanged += lstProducto_TextChanged;
            // 
            // frmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 274);
            Controls.Add(lstProducto);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(dtpFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Name = "frmForm";
            Text = "App Registro de venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecio;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnCancelar;
        private ComboBox lstProducto;
    }
}