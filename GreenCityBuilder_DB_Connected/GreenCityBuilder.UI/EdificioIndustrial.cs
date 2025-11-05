using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCityBuilder.UI.Domain
{
    public class EdificioIndustrial : EdificioBase
    {
        public override string CalcularImpacto()
        {
            return $"Industrial: alto consumo de energía y mayor contaminación.";
        }
    }
}
