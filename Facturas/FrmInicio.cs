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

        public FrmAgregarFactura FormAgregar
        {
            get
            {
                if (formAgregar == null)
                    formAgregar = new FrmAgregarFactura(this);

                return formAgregar;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar.Show();
            this.Hide();
        }

        public void ActualizarDataGrid()
        {
            listaFactura = Factura.TraerTodos();
            if (listaFactura.Count <= 0)
            {
                return;
            }
            DgvFactura.Rows.Clear();
            foreach (Factura factura in listaFactura)
                DgvFactura.Rows.Add(factura.IdFactura, factura.Nombre, factura.Relleno, factura.Precio);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Factura.TraerFactura(){

            }
            .EliminarEnBD();
        }
    }
}
