using System.Collections.Generic;
using System.Data.SqlClient;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public class SqlEntradaCatalogoRepository : IEntradaCatalogoRepository
    {
        public IEnumerable<TipoEdificio> GetTiposEdificio()
        {
            var list = new List<TipoEdificio>();
            using (var conn = DbConnectionSingleton.Instance.Create())
            using (var cmd = new SqlCommand("SELECT IdTipoEdificio, Nombre, CostoBase, ImpactoEnergia, ImpactoAgua, ImpactoAlimentos, ImpactoContaminacion FROM TipoEdificio", conn))
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    list.Add(new TipoEdificio
                    {
                        IdTipoEdificio = rd.GetInt32(0),
                        Nombre = rd.GetString(1),
                        CostoBase = rd.GetInt32(2),
                        ImpactoEnergia = rd.GetInt32(3),
                        ImpactoAgua = rd.GetInt32(4),
                        ImpactoAlimentos = rd.GetInt32(5),
                        ImpactoContaminacion = rd.GetInt32(6)
                    });
                }
            }
            return list;
        }
    }
}
