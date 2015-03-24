namespace HolaMundoForms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.nudNumero1 = new System.Windows.Forms.NumericUpDown();
            this.nudNumero2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.ForeColor = System.Drawing.Color.White;
            this.lblNum1.Location = new System.Drawing.Point(6, 28);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(59, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero 1 :";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.ForeColor = System.Drawing.Color.White;
            this.lblNum2.Location = new System.Drawing.Point(6, 66);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(59, 13);
            this.lblNum2.TabIndex = 0;
            this.lblNum2.Text = "Numero 2 :";
            // 
            // btnSumar
            // 
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSumar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSumar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSumar.Location = new System.Drawing.Point(125, 168);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(94, 45);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Resultado";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOperacion);
            this.groupBox1.Controls.Add(this.nudNumero1);
            this.groupBox1.Controls.Add(this.nudNumero2);
            this.groupBox1.Controls.Add(this.lblNum1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNum2);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la sumadora:";
            // 
            // cbOperacion
            // 
            this.cbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División (#1/#2)"});
            this.cbOperacion.Location = new System.Drawing.Point(71, 101);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Size = new System.Drawing.Size(134, 21);
            this.cbOperacion.TabIndex = 2;
            this.cbOperacion.SelectedIndexChanged += new System.EventHandler(this.cbOperacion_SelectedIndexChanged);
            // 
            // nudNumero1
            // 
            this.nudNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumero1.DecimalPlaces = 2;
            this.nudNumero1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNumero1.Location = new System.Drawing.Point(71, 26);
            this.nudNumero1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudNumero1.Name = "nudNumero1";
            this.nudNumero1.Size = new System.Drawing.Size(136, 20);
            this.nudNumero1.TabIndex = 1;
            this.nudNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudNumero2
            // 
            this.nudNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumero2.DecimalPlaces = 2;
            this.nudNumero2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudNumero2.Location = new System.Drawing.Point(71, 64);
            this.nudNumero2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudNumero2.Name = "nudNumero2";
            this.nudNumero2.Size = new System.Drawing.Size(136, 20);
            this.nudNumero2.TabIndex = 1;
            this.nudNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNumero2.ValueChanged += new System.EventHandler(this.nudNumero2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(337, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSumar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumadora Super Básica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudNumero2;
        private System.Windows.Forms.NumericUpDown nudNumero1;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.Label label1;
    }
}

