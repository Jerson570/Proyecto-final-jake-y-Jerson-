using System;
using System.Linq;
using System.Windows.Forms;
using GreenCityBuilder.UI.Data.Repositories;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI
{
    public partial class FrmRecursos : Form
    {
        private readonly ICiudadRepository _ciudadRepo = new SqlCiudadRepository();
        private readonly ICiudadRecursoRepository _crRepo = new SqlCiudadRecursoRepository();

        public FrmRecursos()
        {
            InitializeComponent();
        }

        private void FrmRecursos_Load(object sender, EventArgs e)
        {
            try
            {
                var ciudades = _ciudadRepo.GetAll().ToList();
                cboCiudadR.DataSource = ciudades;
                cboCiudadR.DisplayMember = nameof(Ciudad.Nombre);
                cboCiudadR.ValueMember = nameof(Ciudad.IdCiudad);
                if (ciudades.Any())
                {
                    CargarRecursos((int)cboCiudadR.SelectedValue);
                }
                cboCiudadR.SelectedIndexChanged += (s, ev) =>
                {
                    if (cboCiudadR.SelectedValue != null)
                        CargarRecursos((int)cboCiudadR.SelectedValue);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarRecursos(int idCiudad)
        {
            try
            {
                dgvRecursos.DataSource = _crRepo.GetByCiudad(idCiudad).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando recursos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
