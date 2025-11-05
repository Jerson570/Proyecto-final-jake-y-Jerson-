using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCityBuilder.UI.Domain
{
    public interface IEdificioFactory
    {
        EdificioBase CrearEdificio(string tipo, string nombre, decimal costo);
    }
}
