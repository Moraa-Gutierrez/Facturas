using Microsoft.Data.Sqlite;

+using System;
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
        public void InsertarEnBD()
        {
            string consulta = "INSERT INTO factura (nombre, relleno, precio) VALUES (@nombre, @relleno, @precio)";
             List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@Nombre",Nombre));
            parametros.Add(new SqliteParameter("@Relleno", Relleno));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            GestorConexion.Instancia.ModificarDB(consulta,parametros);
        }
        public void ModificarEnBD()
        {
            string consulta = "UPDATE factura SET @Nombre = Nombre, @Relleno = Relleno, @Precio = Precio WHERE Id_Factura = @Id_Factura";
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Relleno", Relleno));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            parametros.Add(new SqliteParameter("@Id_Factura", Id_Factura));
            GestorConexion.Instancia.ModificarDB(consulta, parametros);
        }
        public void EliminarEnBD()
        {   
            string consulta = "DELETE FROM factura WHERE Id_Factura = @Id_Factura";
            GestorConexion.Instancia.ModificarDB(consulta);
        }
    }
}
