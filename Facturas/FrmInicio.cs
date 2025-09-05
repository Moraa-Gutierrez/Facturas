namespace Facturas
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
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
    }
}
