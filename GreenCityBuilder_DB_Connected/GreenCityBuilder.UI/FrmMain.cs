using System;
    using System.Windows.Forms;

    namespace GreenCityBuilder.UI
    {
        public partial class FrmMain : Form
        {
            public FrmMain()
            {
                InitializeComponent();
            }
            private void btnCiudades_Click(object sender, EventArgs e)
{
    var f = new FrmCiudades();
    f.Show();
}

private void btnEdificios_Click(object sender, EventArgs e)
{
    var f = new FrmEdificios();
    f.Show();
}

private void btnRecursos_Click(object sender, EventArgs e)
{
    var f = new FrmRecursos();
    f.Show();
}
        }
    }
