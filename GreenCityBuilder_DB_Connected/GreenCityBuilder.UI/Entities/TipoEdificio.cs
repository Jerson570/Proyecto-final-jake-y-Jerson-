namespace GreenCityBuilder.UI.Entities
{
    public class TipoEdificio
    {
        public int IdTipoEdificio { get; set; }
        public string Nombre { get; set; }
        public int CostoBase { get; set; }
        public int ImpactoEnergia { get; set; }
        public int ImpactoAgua { get; set; }
        public int ImpactoAlimentos { get; set; }
        public int ImpactoContaminacion { get; set; }
    }
}
