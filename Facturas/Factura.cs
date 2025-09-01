using Microsoft.Data.Sqlite;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura
    {
        protected int idFactura;
        protected string nombre;
        protected bool relleno;
        protected int precio;

        public static Factura TraerFactura(int idFactura)
        {
            Factura factura = new Factura();

            return factura;
        }
        public void InsertarEnBD()
        {
            string consulta = "INSERT INTO factura (nombre, relleno, precio) VALUES (@nombre, @relleno, @precio)";
             List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@nombre",nombre));
            parametros.Add(new SqliteParameter("@relleno", relleno ? 1 : 0));
            parametros.Add(new SqliteParameter("@precio", precio));
            GestorConexion.Instancia.ModificarBD(consulta,parametros);
        }
        public void ModificarEnBD()
        {
            string consulta = "UPDATE factura SET @nombre = nombre, @relleno = relleno, @precio = precio WHERE idFactura = @idFactura";
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@nombre", nombre));
            parametros.Add(new SqliteParameter("@relleno", relleno ? 1 : 0));
            parametros.Add(new SqliteParameter("@precio", precio));
            parametros.Add(new SqliteParameter("@idFactura", idFactura));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void EliminarEnBD()
        {   
            string consulta = "DELETE FROM factura WHERE idFactura = @idFactura";
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@nombre", nombre));
            parametros.Add(new SqliteParameter("@relleno", relleno ? 1: 0));
            parametros.Add(new SqliteParameter("@precio", precio));
            parametros.Add(new SqliteParameter("@idFactura", idFactura));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);

        }
        public static List<Factura> TraerTodos()
        {
            List <Factura> lista=new List<Factura>();
            string consulta = "SELECT * FROM tabla";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Factura nuevaFactura = new Factura();
                nuevaFactura.idFactura = int.Parse(fila["idFactura"].ToString());
                nuevaFactura.nombre = fila["nombre"].ToString();
                nuevaFactura.relleno = int.Parse(fila["relleno"].ToString()) == 1;
                nuevaFactura.precio = int.Parse(fila["precio"].ToString());
                lista.Add(nuevaFactura);
            }
            return lista;
        }
        public static Factura TraerUno(int idFactura)
        {
            Factura factura = new Factura();   
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT FROM tabla WHERE idFactura = @idFactura";
            parametros.Add(new SqliteParameter("@idFactura", idFactura));
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            factura.idFactura = int.Parse( tabla.Rows[0]["Id_Factura"].ToString());
            factura.nombre = (tabla.Rows[0]["nombre"].ToString());
            factura.relleno = int.Parse(tabla.Rows[0]["relleno"].ToString()) == 1;
            factura.precio = int.Parse(tabla.Rows[0]["precio"].ToString());
            return factura;
        }
    
    }
}
