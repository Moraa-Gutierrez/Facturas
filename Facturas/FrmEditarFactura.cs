using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class FrmEditarFactura : Form
    {
        FrmInicio formInicio;

        public FrmEditarFactura(FrmInicio formInicio)
        {
            InitializeComponent();
            this.formInicio = formInicio;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Hide();
        }
        Factura facturamodificar;
        public void MostrarEditar(Factura facturaeditar)
        {
            Factura editarFactura = facturaeditar;
            TxtNombreEditar.Text =  editarFactura.Nombre;
            ChkEditarRelleno.Checked = editarFactura.Relleno;
            TxtPrecioEditar.Text  = editarFactura.Precio.ToString();
            facturamodificar = facturaeditar;
            this.Show();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            facturamodificar.ModificarEnBD();
            formInicio.Show();
            this.Hide();
        }
    }
}
