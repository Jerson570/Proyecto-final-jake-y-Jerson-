using System.Collections.Generic;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public interface IEntradaCatalogoRepository
    {
        IEnumerable<TipoEdificio> GetTiposEdificio();
    }
}
