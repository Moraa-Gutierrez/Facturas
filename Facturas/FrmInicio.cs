using Microsoft.Data.Sqlite;

namespace Facturas
{
    public partial class FrmInicio : Form
    {
        List<Factura> listaFactura;
        public FrmInicio()
        {
            InitializeComponent();

            string stringConexion = "Data Source=facturas.db";

            ActualizarDataGrid();
        }
        FrmAgregarFactura formAgregar;
        FrmEditarFactura formEditar;

        public FrmAgregarFactura FormAgregar
        {
            get
            {
                if (formAgregar == null)
                    formAgregar = new FrmAgregarFactura(this);

                return formAgregar;
            }
        }
        public FrmEditarFactura FormEditar
        {
            get
            {
                if (formEditar == null)
                    formEditar = new FrmEditarFactura(this);

                return formEditar;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar.Show();
            this.Hide();
        }

        public void ActualizarDataGrid()
        {
            DgvFactura.Rows.Clear();
            listaFactura = Factura.TraerTodos();

            if (listaFactura.Count <= 0)
            {
                return;
            }

            foreach (Factura factura in listaFactura)
                DgvFactura.Rows.Add(factura.IdFactura, factura.Nombre, factura.Relleno, factura.Precio);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvFactura.SelectedRows.Count <= 0)
                return;
            int idSeleccionado = (int)DgvFactura.SelectedRows[0].Cells["Id_Factura"].Value;
            Factura facturaAEliminar = Factura.TraerUno(idSeleccionado);

            facturaAEliminar.EliminarEnBD();
            ActualizarDataGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)DgvFactura.SelectedRows[0].Cells["Id_Factura"].Value;
            Factura facturaeditar = Factura.TraerUno(idSeleccionado);
            FormEditar.MostrarEditar(facturaeditar);
            this.Hide();
        }
    }
}
