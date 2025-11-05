using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCityBuilder.UI.Domain
{
    public class EdificioResidencial : EdificioBase
    {
        public override string CalcularImpacto()
        {
            return $"Residencial: consumo moderado, buena eficiencia energética.";
        }
    }
}

