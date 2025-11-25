using System.Collections.Generic;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public interface IEdificioRepository
    {
        IEnumerable<EdificioListado> GetAllByCiudad(int idCiudad);
        int Add(int idCiudad, int idTipoEdificio, string nombre);
    }
}
