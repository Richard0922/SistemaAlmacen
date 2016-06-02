using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
            rellenaCombo();
        }
        private void rellenaCombo()
        {
            cmbProducto.DataSource = MenuAdmin.miBodega.miListaDeProductos();
        }
        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            String productoSeleccionado = Convert.ToString(cmbProducto.SelectedItem);
            var stock = MenuAdmin.miBodega.Stock(productoSeleccionado);
            lblCantidad.Text = "" + stock;
        }
    }
}
