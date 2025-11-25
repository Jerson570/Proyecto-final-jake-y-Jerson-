using System.Collections.Generic;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public interface ICiudadRecursoRepository
    {
        IEnumerable<CiudadRecurso> GetByCiudad(int idCiudad);
    }
}
