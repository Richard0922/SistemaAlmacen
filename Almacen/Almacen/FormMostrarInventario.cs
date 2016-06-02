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

namespace SistemaAlmacen
{
    public partial class FormMostrarInventario : Form
    {
        public FormMostrarInventario()
        {
            InitializeComponent();
            recargarGrid();
        }

        private void FormMostrarInventario_Load(object sender, EventArgs e)
        {

        }
        public void recargarGrid()
        {
            try
            {
                DataTable dt = new DataTable();   //en dt cargo todos los datos como yo quiera, y despues dt lo paso al gridview

                dt.Columns.Add(new DataColumn("Nombre Producto", typeof(string)));
                dt.Columns.Add(new DataColumn("Precio Venta", typeof(string)));
                dt.Columns.Add(new DataColumn("Precio Compra", typeof(string)));
                //dt.Columns.Add(new DataColumn("Cantidad", typeof(string)));

                //List<String> listita = new List<string>();

                //StreamReader lector = new StreamReader(@"C:\info\bodega.txt");
                //String linea = lector.ReadLine();
                //while (linea != null)
                //{
                //    string[] array = linea.Split(':');
                var arr = MenuAdmin.miBodega.todosLosProductos();
                    //dt.Rows.Add(arr[0],arr[1],arr[2]);
              

                 //cada dato de la fila separado por coma
                    //}
                
                gridInventario.DataSource = dt;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
