namespace Almacen
{
    partial class FormComprarProd
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidadIngresar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtProdPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtNombreProdIngresar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Cantidad:";
            // 
            // txtCantidadIngresar
            // 
            this.txtCantidadIngresar.Location = new System.Drawing.Point(100, 172);
            this.txtCantidadIngresar.Name = "txtCantidadIngresar";
            this.txtCantidadIngresar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadIngresar.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Precio Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Precio Compra:";
            // 
            // txtProdPrecioVenta
            // 
            this.txtProdPrecioVenta.Location = new System.Drawing.Point(99, 144);
            this.txtProdPrecioVenta.Name = "txtProdPrecioVenta";
            this.txtProdPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtProdPrecioVenta.TabIndex = 54;
            // 
            // txtProdPrecioCompra
            // 
            this.txtProdPrecioCompra.Location = new System.Drawing.Point(99, 107);
            this.txtProdPrecioCompra.Name = "txtProdPrecioCompra";
            this.txtProdPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtProdPrecioCompra.TabIndex = 53;
            // 
            // txtNombreProdIngresar
            // 
            this.txtNombreProdIngresar.Location = new System.Drawing.Point(99, 70);
            this.txtNombreProdIngresar.Name = "txtNombreProdIngresar";
            this.txtNombreProdIngresar.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProdIngresar.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Nombre:";
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Location = new System.Drawing.Point(205, 68);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarProducto.TabIndex = 50;
            this.btnIngresarProducto.Text = "Ingresar";
            this.btnIngresarProducto.UseVisualStyleBackColor = true;
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // FormComprarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 290);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidadIngresar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProdPrecioVenta);
            this.Controls.Add(this.txtProdPrecioCompra);
            this.Controls.Add(this.txtNombreProdIngresar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIngresarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComprarProd";
            this.Text = "FormComprarProd";
            this.Load += new System.EventHandler(this.FormComprarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadIngresar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProdPrecioVenta;
        private System.Windows.Forms.TextBox txtProdPrecioCompra;
        private System.Windows.Forms.TextBox txtNombreProdIngresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngresarProducto;
    }
}