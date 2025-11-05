using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public class SqlCiudadRepository : ICiudadRepository
    {
        public int Add(Ciudad ciudad)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand(@"INSERT INTO Ciudad (Nombre, NivelSostenibilidad, Poblacion, Contaminacion)
                                              VALUES (@n,@ns,@p,@c);
                                              SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@n", ciudad.Nombre);
                cmd.Parameters.AddWithValue("@ns", ciudad.NivelSostenibilidad);
                cmd.Parameters.AddWithValue("@p", ciudad.Poblacion);
                cmd.Parameters.AddWithValue("@c", ciudad.Contaminacion);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand("DELETE FROM Ciudad WHERE IdCiudad=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Ciudad> GetAll()
        {
            var list = new List<Ciudad>();
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand("SELECT IdCiudad, Nombre, NivelSostenibilidad, Poblacion, Contaminacion FROM Ciudad ORDER BY IdCiudad DESC", conn))
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    list.Add(new Ciudad
                    {
                        IdCiudad = rd.GetInt32(0),
                        Nombre = rd.GetString(1),
                        NivelSostenibilidad = rd.GetInt32(2),
                        Poblacion = rd.GetInt32(3),
                        Contaminacion = rd.GetInt32(4)
                    });
                }
            }
            return list;
        }

        public Ciudad GetById(int id)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand("SELECT IdCiudad, Nombre, NivelSostenibilidad, Poblacion, Contaminacion FROM Ciudad WHERE IdCiudad=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return new Ciudad
                        {
                            IdCiudad = rd.GetInt32(0),
                            Nombre = rd.GetString(1),
                            NivelSostenibilidad = rd.GetInt32(2),
                            Poblacion = rd.GetInt32(3),
                            Contaminacion = rd.GetInt32(4)
                        };
                    }
                }
            }
            return null;
        }

        public void Update(Ciudad ciudad)
        {
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand(@"UPDATE Ciudad SET Nombre=@n, NivelSostenibilidad=@ns, 
                                              Poblacion=@p, Contaminacion=@c WHERE IdCiudad=@id", conn))
            {
                cmd.Parameters.AddWithValue("@n", ciudad.Nombre);
                cmd.Parameters.AddWithValue("@ns", ciudad.NivelSostenibilidad);
                cmd.Parameters.AddWithValue("@p", ciudad.Poblacion);
                cmd.Parameters.AddWithValue("@c", ciudad.Contaminacion);
                cmd.Parameters.AddWithValue("@id", ciudad.IdCiudad);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
