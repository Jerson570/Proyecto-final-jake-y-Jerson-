using GreenCityBuilder.UI.Data.Repositories;
using GreenCityBuilder.UI.Domain;
using GreenCityBuilder.UI.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GreenCityBuilder.UI
{
    public partial class FrmEdificios : Form
    {
        private readonly ICiudadRepository _ciudadRepo = new SqlCiudadRepository();
        private readonly IEntradaCatalogoRepository _catalogoRepo = new SqlEntradaCatalogoRepository();
        private readonly IEdificioRepository _edificioRepo = new SqlEdificioRepository();

        public FrmEdificios()
        {
            InitializeComponent();
        }

        private void FrmEdificios_Load(object sender, EventArgs e)
        {
            try
            {
                var ciudades = _ciudadRepo.GetAll().ToList();
                cboCiudad.DataSource = ciudades;
                cboCiudad.DisplayMember = nameof(Ciudad.Nombre);
                cboCiudad.ValueMember = nameof(Ciudad.IdCiudad);

                var tipos = _catalogoRepo.GetTiposEdificio().ToList();
                cboTipoEdificio.DataSource = tipos;
                cboTipoEdificio.DisplayMember = nameof(TipoEdificio.Nombre);
                cboTipoEdificio.ValueMember = nameof(TipoEdificio.IdTipoEdificio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando combos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreEdificio.Text))
            {
                MessageBox.Show("Ingrese un nombre de edificio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idCiudad = (int)cboCiudad.SelectedValue;
                int idTipo = (int)cboTipoEdificio.SelectedValue;

                // Regla: si tipo es Industrial, verificar contaminación de la ciudad.
                var ciudad = _ciudadRepo.GetById(idCiudad);
                var tipoNombre = (cboTipoEdificio.Text ?? string.Empty).Trim();

                if (tipoNombre.Equals("Industrial", StringComparison.OrdinalIgnoreCase) && ciudad.Contaminacion > 70)
                {
                    MessageBox.Show("No se puede construir una fábrica porque la contaminación supera el 70%.", "Regla de negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var factory = new EdificioFactory();
                var tipoSeleccionado = cboTipoEdificio.Text;
                var edificio = factory.CrearEdificio(tipoSeleccionado, txtNombreEdificio.Text, (decimal)nudCosto.Value);

                MessageBox.Show(edificio.CalcularImpacto(), "Resultado del Factory", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var nuevoId = _edificioRepo.Add(idCiudad, idTipo, txtNombreEdificio.Text.Trim());
                MessageBox.Show("Edificio creado con Id " + nuevoId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar listado
                dgvEdificios.DataSource = _edificioRepo.GetAllByCiudad(idCiudad).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear edificio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
