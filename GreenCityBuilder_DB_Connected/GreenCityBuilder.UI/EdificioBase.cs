using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCityBuilder.UI.Domain
{
    public abstract class EdificioBase
    {
        public string Nombre { get; set; }
        public decimal CostoBase { get; set; }

        public abstract string CalcularImpacto();

        public override string ToString()
        {
            return $"{GetType().Name}: {Nombre} (Costo: {CostoBase:C})";
        }
    }
}
