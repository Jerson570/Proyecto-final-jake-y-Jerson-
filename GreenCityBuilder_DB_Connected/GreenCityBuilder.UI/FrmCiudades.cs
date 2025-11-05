using System;
using System.Linq;
using System.Windows.Forms;
using GreenCityBuilder.UI.Data.Repositories;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI
{
    public partial class FrmCiudades : Form
    {
        private readonly ICiudadRepository _repo = new SqlCiudadRepository();

        public FrmCiudades()
        {
            InitializeComponent();
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            CargarCiudades();
        }

        private void CargarCiudades()
        {
            try
            {
                dgvCiudades.DataSource = _repo.GetAll().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando ciudades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            nudSostenibilidad.Value = 50;
            nudPoblacion.Value = 0;
            nudContaminacion.Value = 40;
            MessageBox.Show("Formulario limpio.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (nudContaminacion.Value > 100)
            {
                MessageBox.Show("La contaminación no puede ser mayor a 100.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ciudad = new Ciudad
                {
                    Nombre = txtNombre.Text.Trim(),
                    NivelSostenibilidad = (int)nudSostenibilidad.Value,
                    Poblacion = (int)nudPoblacion.Value,
                    Contaminacion = (int)nudContaminacion.Value
                };

                var id = _repo.Add(ciudad);
                MessageBox.Show("Ciudad guardada con Id " + id, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCiudades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando ciudad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
