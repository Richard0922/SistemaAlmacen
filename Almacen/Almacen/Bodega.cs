using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    public class Bodega
    {
        private List<Producto> productos = new List<Producto>();
        private List<int> cantidades = new List<int>();
        
        public Bodega()
        {
            try
            {
                StreamReader lector = new StreamReader(@"C:\info\bodega.txt");
                string linea = lector.ReadLine();
                while(linea != null)
                {
                    string[] arrayProducto = linea.Split(':');
                    string nombre = arrayProducto[0];
                    int precioCompra = Convert.ToInt32(arrayProducto[1]);
                    int precioVenta = Convert.ToInt32(arrayProducto[2]);
                    int cantidad = Convert.ToInt32(arrayProducto[3]);

                    var productoIngresar = new Producto();
                    productoIngresar.Nombre = nombre;
                    productoIngresar.PrecioCompra = precioCompra;
                    productoIngresar.PrecioVenta = precioVenta;
                    this.Ingresar(productoIngresar, cantidad);
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            catch (Exception ex)
            {
               //
            }
        }
        ~Bodega()
        {
            try
            {
                StreamWriter escritor = new StreamWriter(@"C:\info\bodega.txt");
                for (int i = 0; i < productos.Count; i++)
                {
                    var producto = productos[i];
                    var cantidad = cantidades[i];
                    escritor.WriteLine(producto.Nombre + ":" + producto.PrecioCompra + ":" + producto.PrecioVenta + ":" + cantidad);
                }
                escritor.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public List<String> miListaDeProductos()
        {
            try
            {
                List<String> listita = new List<string>();

                StreamReader lector = new StreamReader(@"C:\info\bodega.txt");
                while (lector.Peek() >= 0)
                {
                    listita.Add(lector.ReadLine().Split(':')[0]);
                }
                return listita;
            }
            catch (Exception a)
            {

            }
            return null;
        }
        public List<String> todosLosProductos()
        {
            try
            {
                List<String> listita = new List<string>();

                StreamReader lector = new StreamReader(@"C:\info\bodega.txt");

                while (lector.Peek() >= 0)
                {
                    string[] lect = lector.ReadLine().Split(':');
                

                }
                return listita;



            }
            catch (Exception a)
            {

            }
            return null;
        }
        public void Ingresar(Producto prodIngresar, int cuantos)
        {
            bool existe = false;
            for (int i = 0; i < productos.Count; i++)
            {
                var productoI = productos[i];
                if (productoI.Nombre == prodIngresar.Nombre)
                {
                    existe = true;
                    cantidades[i] = cantidades[i] + cuantos;
                }
            }
            if (existe == false)
            {
                productos.Add(prodIngresar);
                cantidades.Add(cuantos);
            }

            StreamWriter escritor = new StreamWriter(@"C:\info\bodega.txt");
            for (int i = 0; i < productos.Count; i++)
            {
                var producto = productos[i];
                var cantidad = cantidades[i];
                escritor.WriteLine(producto.Nombre + ":" + producto.PrecioCompra + ":" + producto.PrecioVenta + ":" + cantidad);
            }
            escritor.Close();
        }

        public Producto Sacar(string nombre, int cantidad)
        {
            bool existe = false;
            for (int i = 0; i < productos.Count; i++)
            {
                var productoI = productos[i];
                if (nombre == productoI.Nombre)
                {
                    existe = true;
                    if (cantidades[i] >= cantidad)
                    {
                        cantidades[i] = cantidades[i] - cantidad;
                        return productoI;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            if (existe == false)
            {
                return null;
            }

            return null;
        }

        public int Stock(string nombre)
        {
            bool existe = false;
            for (int i = 0; i < productos.Count; i++)
            {
                var productoI = productos[i];
                if (nombre == productoI.Nombre)
                {
                    existe = true;
                    return cantidades[i];
                }

            }
            if (existe == false)
            {
                return 0;
            }
            return 0;
        }
    }
}
