using GreenCityBuilder.UI.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public class SqlEdificioRepository : IEdificioRepository
    {
        public int Add(int idCiudad, int idTipoEdificio, string nombre)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            {
                conn.Open();   

                using (var cmd = new SqlCommand(@"INSERT INTO Edificio (IdCiudad, IdTipoEdificio, Nombre) 
                                                  VALUES (@c,@t,@n); SELECT SCOPE_IDENTITY();", conn))
                {
                    cmd.Parameters.AddWithValue("@c", idCiudad);
                    cmd.Parameters.AddWithValue("@t", idTipoEdificio);
                    cmd.Parameters.AddWithValue("@n", nombre);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public IEnumerable<EdificioListado> GetAllByCiudad(int idCiudad)
        {
            var list = new List<EdificioListado>();

            using (var conn = DbConnectionSingleton.Instance.Create())
            {
                conn.Open();   

                using (var cmd = new SqlCommand(@"
                    SELECT e.IdEdificio, c.Nombre AS Ciudad, te.Nombre AS Tipo, e.Nombre, e.FechaConstruccion
                    FROM Edificio e
                    JOIN Ciudad c ON e.IdCiudad = c.IdCiudad
                    JOIN TipoEdificio te ON e.IdTipoEdificio = te.IdTipoEdificio
                    WHERE e.IdCiudad = @id
                    ORDER BY e.IdEdificio DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCiudad);

                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new EdificioListado
                            {
                                IdEdificio = rd.GetInt32(0),
                                Ciudad = rd.GetString(1),
                                Tipo = rd.GetString(2),
                                Nombre = rd.GetString(3),
                                FechaConstruccion = rd.GetDateTime(4)
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
