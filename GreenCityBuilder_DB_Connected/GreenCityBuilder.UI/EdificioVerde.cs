using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCityBuilder.UI.Domain
{
    public class EdificioVerde : EdificioBase
    {
        public override string CalcularImpacto()
        {
            return $"Verde: eficiencia alta y reducción de contaminación.";
        }
    }
}
