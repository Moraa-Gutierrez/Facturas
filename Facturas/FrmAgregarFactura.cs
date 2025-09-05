using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
namespace Facturas
{
    public partial class FrmAgregarFactura : Form
    {
        FrmInicio formInicio;
        public FrmAgregarFactura(FrmInicio formInicio)
        {
            InitializeComponent();
            this.formInicio = formInicio;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            Factura agregarFactura = new Factura();// nueva instancia de memoria de la clase Factura
            agregarFactura.Nombre = TxtNombre.Text;
            agregarFactura.Relleno = ChkRelleno.Checked;
            agregarFactura.Precio = float.Parse(TxtPrecio.Text);
            agregarFactura.InsertarEnBD();// agregar factura a la base de datos,pasamos factura y conexion
            this.Hide();// se esconde
        }
        public void MostrarAgregar()// prepara al formulario para agregar
        {
            this.Show();
            formInicio.Hide();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Hide();
        }
    }
}
