using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen
{
    public class Caja
    {
        public Caja()
        {
            try
            {
                StreamReader lector = new StreamReader("caja.dll");
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    int plata = Convert.ToInt32(linea);
                    this.Ingresar(plata);
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            catch (Exception ex)
            {
            }
        }

        ~Caja()
        {
            try
            {
                StreamWriter escritor = new StreamWriter("caja.dll");
                escritor.WriteLine(MenuAdmin.miCaja.Dinero);
                escritor.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public int Dinero { get; set; }

        public void Ingresar(int plata)
        {
            Dinero = Dinero + plata;
        }

        public bool Sacar(int plata)
        {
            if (Dinero < plata)
            {
                return false;
            }
            else
            {
                Dinero = Dinero - plata;
                return true;
            }
        }
    }
}
