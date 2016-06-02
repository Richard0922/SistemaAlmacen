using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen
{
    public partial class FormComprarProd : Form
    {
        public FormComprarProd()
        {
            InitializeComponent();
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreProdIngresar.Text;
                int precioCompra = Convert.ToInt32(txtProdPrecioCompra.Text);
                int precioVenta = Convert.ToInt32(txtProdPrecioVenta.Text);
                int cantidad = Convert.ToInt32(txtCantidadIngresar.Text);

                int plata = precioCompra * cantidad;
                if (MenuAdmin.miCaja.Sacar(plata) == true)
                {
                    var prod = new Producto();
                    prod.Nombre = nombre;
                    prod.PrecioCompra = precioCompra;
                    prod.PrecioVenta = precioVenta;
                    MenuAdmin.miBodega.Ingresar(prod, cantidad);

                    txtNombreProdIngresar.Text = "";
                    txtProdPrecioCompra.Text = "";
                    txtProdPrecioVenta.Text = "";
                    txtCantidadIngresar.Text = "";

                    MessageBox.Show("Producto ingresado con éxito.");

                    //String nombresProductos = MenuAdmin.miBodega.todosLosProductos();
                    //StreamWriter escritor = new StreamWriter(@"C:\info\bodega3.txt");
                    //escritor.WriteLine(nombresProductos);
                    //escritor.Close();
                }
                else
                {
                    MessageBox.Show("No hay suficiente dinero en caja.");
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void FormComprarProd_Load(object sender, EventArgs e)
        {

        }
    }
}
