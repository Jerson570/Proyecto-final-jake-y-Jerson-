using System.Collections.Generic;
using System.Data.SqlClient;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public class SqlCiudadRecursoRepository : ICiudadRecursoRepository
    {
        public IEnumerable<CiudadRecurso> GetByCiudad(int idCiudad)
        {
            var list = new List<CiudadRecurso>();
            using (var conn = DbConnectionSingleton.Instance.Create())
            {
                conn.Open();
                using (var cmd = new SqlCommand(@"
                    SELECT cr.IdCiudad, cr.IdRecurso, cr.CantidadActual, cr.CantidadMaxima, r.Nombre, r.Unidad
                    FROM CiudadRecurso cr
                    JOIN Recurso r ON cr.IdRecurso = r.IdRecurso
                    WHERE cr.IdCiudad = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCiudad);
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new CiudadRecurso
                            {
                                IdCiudad = rd.GetInt32(0),
                                IdRecurso = rd.GetInt32(1),
                                CantidadActual = rd.GetInt32(2),
                                CantidadMaxima = rd.GetInt32(3),
                                RecursoNombre = rd.GetString(4),
                                Unidad = rd.GetString(5)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}

