using System;

namespace GreenCityBuilder.UI.Domain
{
    public class EdificioFactory : IEdificioFactory
    {
        public EdificioBase CrearEdificio(string tipo, string nombre, decimal costo)
        {
            EdificioBase edificio;
            switch (tipo.Trim().ToLower())
            {
                case "residencial":
                    edificio = new EdificioResidencial();
                    break;
                case "industrial":
                    edificio = new EdificioIndustrial();
                    break;
                case "verde":
                    edificio = new EdificioVerde();
                    break;
                default:
                    throw new ArgumentException("Tipo de edificio no válido", nameof(tipo));
            }

            edificio.Nombre = nombre;
            edificio.CostoBase = costo;
            return edificio;
        }
    }
}
