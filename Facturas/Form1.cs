namespace Facturas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmMain FrmAgregar;

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            FrmAgregar.();
            this.Hide();
        }
    }
}
