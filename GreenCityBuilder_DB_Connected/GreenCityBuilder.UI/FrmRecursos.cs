using GreenCityBuilder.UI.Data;
using GreenCityBuilder.UI.Data.Repositories;
using GreenCityBuilder.UI.Entities;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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

        //nuevo
        private string NombreRecurso(int id)
        {
            switch (id)
            {
                case 1: return "Agua";
                case 2: return "Energía";
                case 3: return "Alimentos";
                case 4: return "Áreas Verdes";
                default: return "Recurso";
            }
        }

        private void btnPuzzle_Click(object sender, EventArgs e)
        {
            if (cboCiudadR.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una ciudad primero.");
                return;
            }

            Ciudad ciudad = (Ciudad)cboCiudadR.SelectedItem;

            FrmPuzzleRecursos puzzle = new FrmPuzzleRecursos();
            var resultado = puzzle.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                int ganados = puzzle.RecursosGanados;
                int idRecurso = puzzle.IdRecursoGanado;  

                if (ganados > 0)
                {
                    AumentarRecurso(ciudad.IdCiudad, idRecurso, ganados);  

                    string nombre = NombreRecurso(idRecurso);

                    

                    CargarRecursos(ciudad.IdCiudad); 
                }
            }
        }


        private void AumentarRecurso(int idCiudad, int idRecurso, int cantidad)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                
                using (var checkCmd = new SqlCommand(@"
            SELECT COUNT(*) FROM CiudadRecurso
            WHERE IdCiudad = @ciudad AND IdRecurso = @recurso
        ", conn))
                {
                    checkCmd.Parameters.AddWithValue("@ciudad", idCiudad);
                    checkCmd.Parameters.AddWithValue("@recurso", idRecurso);

                    int existe = (int)checkCmd.ExecuteScalar();

                   
                    if (existe == 0)
                    {
                        using (var insertCmd = new SqlCommand(@"
                    INSERT INTO CiudadRecurso (IdCiudad, IdRecurso, CantidadActual, CantidadMaxima)
                    VALUES (@ciudad, @recurso, 0, 100)
                ", conn))
                        {
                            insertCmd.Parameters.AddWithValue("@ciudad", idCiudad);
                            insertCmd.Parameters.AddWithValue("@recurso", idRecurso);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                
                using (var cmd = new SqlCommand(@"
            UPDATE CiudadRecurso
            SET CantidadActual =
                CASE
                    WHEN CantidadActual + @c <= CantidadMaxima 
                        THEN CantidadActual + @c
                    ELSE CantidadMaxima
                END
            WHERE IdCiudad = @ciudad AND IdRecurso = @recurso
        ", conn))
                {
                    cmd.Parameters.AddWithValue("@c", cantidad);
                    cmd.Parameters.AddWithValue("@ciudad", idCiudad);
                    cmd.Parameters.AddWithValue("@recurso", idRecurso);

                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
