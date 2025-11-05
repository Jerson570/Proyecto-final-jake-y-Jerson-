using System;

namespace GreenCityBuilder.UI.Entities
{
    public class EdificioListado
    {
        public int IdEdificio { get; set; }
        public string Ciudad { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaConstruccion { get; set; }
    }
}
