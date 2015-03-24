namespace HolaMundoForms.GUI.Menú
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_sucursales = new System.Windows.Forms.Button();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_almacen = new System.Windows.Forms.Button();
            this.btn_punto_venta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 43);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "Menú";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::HolaMundoForms.Properties.Resources.Windows_Close_icon;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(378, 214);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(96, 96);
            this.btn_salir.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btn_salir, "Salir");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HolaMundoForms.Properties.Resources.catdef1;
            this.pictureBox1.Location = new System.Drawing.Point(490, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackgroundImage = global::HolaMundoForms.Properties.Resources.users;
            this.btn_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.ForeColor = System.Drawing.Color.Black;
            this.btn_usuarios.Location = new System.Drawing.Point(252, 214);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(96, 96);
            this.btn_usuarios.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btn_usuarios, "Usuarios");
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_sucursales
            // 
            this.btn_sucursales.BackgroundImage = global::HolaMundoForms.Properties.Resources.shop_icon;
            this.btn_sucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sucursales.FlatAppearance.BorderSize = 0;
            this.btn_sucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sucursales.ForeColor = System.Drawing.Color.Black;
            this.btn_sucursales.Location = new System.Drawing.Point(133, 214);
            this.btn_sucursales.Name = "btn_sucursales";
            this.btn_sucursales.Size = new System.Drawing.Size(96, 96);
            this.btn_sucursales.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_sucursales, "Sucursales");
            this.btn_sucursales.UseVisualStyleBackColor = true;
            this.btn_sucursales.Click += new System.EventHandler(this.btn_sucursales_Click);
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.BackgroundImage = global::HolaMundoForms.Properties.Resources.proveedores;
            this.btn_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedor.ForeColor = System.Drawing.Color.Black;
            this.btn_proveedor.Location = new System.Drawing.Point(252, 87);
            this.btn_proveedor.Name = "btn_proveedor";
            this.btn_proveedor.Size = new System.Drawing.Size(96, 96);
            this.btn_proveedor.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_proveedor, "Proveedores");
            this.btn_proveedor.UseVisualStyleBackColor = true;
            this.btn_proveedor.Click += new System.EventHandler(this.btn_proveedor_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.BackgroundImage = global::HolaMundoForms.Properties.Resources.productos;
            this.btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.ForeColor = System.Drawing.Color.Black;
            this.btn_producto.Location = new System.Drawing.Point(12, 214);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(96, 96);
            this.btn_producto.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_producto, "Productos");
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackgroundImage = global::HolaMundoForms.Properties.Resources.Clients_icon;
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.ForeColor = System.Drawing.Color.Black;
            this.btn_cliente.Location = new System.Drawing.Point(378, 87);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(96, 96);
            this.btn_cliente.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn_cliente, "Clientes");
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_almacen
            // 
            this.btn_almacen.BackgroundImage = global::HolaMundoForms.Properties.Resources.warehouse;
            this.btn_almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_almacen.FlatAppearance.BorderSize = 0;
            this.btn_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_almacen.ForeColor = System.Drawing.Color.Black;
            this.btn_almacen.Location = new System.Drawing.Point(133, 87);
            this.btn_almacen.Name = "btn_almacen";
            this.btn_almacen.Size = new System.Drawing.Size(96, 96);
            this.btn_almacen.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_almacen, "Almacenes");
            this.btn_almacen.UseVisualStyleBackColor = true;
            this.btn_almacen.Click += new System.EventHandler(this.btn_almacen_Click);
            // 
            // btn_punto_venta
            // 
            this.btn_punto_venta.BackgroundImage = global::HolaMundoForms.Properties.Resources.Cash_register_icon;
            this.btn_punto_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_punto_venta.FlatAppearance.BorderSize = 0;
            this.btn_punto_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_punto_venta.ForeColor = System.Drawing.Color.Black;
            this.btn_punto_venta.Location = new System.Drawing.Point(12, 87);
            this.btn_punto_venta.Name = "btn_punto_venta";
            this.btn_punto_venta.Size = new System.Drawing.Size(96, 96);
            this.btn_punto_venta.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_punto_venta, "Punto de venta");
            this.btn_punto_venta.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(696, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_usuarios);
            this.Controls.Add(this.btn_sucursales);
            this.Controls.Add(this.btn_proveedor);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_almacen);
            this.Controls.Add(this.btn_punto_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_punto_venta;
        private System.Windows.Forms.Button btn_almacen;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_proveedor;
        private System.Windows.Forms.Button btn_sucursales;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}