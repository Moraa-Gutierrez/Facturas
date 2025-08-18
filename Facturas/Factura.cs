using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura
    {
        protected int Id_Factura;
        protected string Nombre;
        protected bool Relleno;
        protected int Precio;

        public static Factura TraerFactura(int Id_Factura)
        {
            Factura factura = new Factura();
        }
    }
}
