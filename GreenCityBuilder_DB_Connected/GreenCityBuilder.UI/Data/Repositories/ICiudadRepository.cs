using System.Collections.Generic;
using GreenCityBuilder.UI.Entities;

namespace GreenCityBuilder.UI.Data.Repositories
{
    public interface ICiudadRepository
    {
        IEnumerable<Ciudad> GetAll();
        Ciudad GetById(int id);
        int Add(Ciudad ciudad);
        void Update(Ciudad ciudad);
        void Delete(int id);
    }
}
