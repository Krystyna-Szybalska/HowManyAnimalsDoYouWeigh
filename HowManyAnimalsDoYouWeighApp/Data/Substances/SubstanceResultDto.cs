namespace HowManyAnimalsDoYouWeighApp.Data.Substances
{
    public class SubstanceResultDto
    {
        public string Name { get; set; }
        public decimal Density { get; set; }
        public decimal CalculatedVolume { get; set; }
        public string CalculatedVolumeString { get; set; }
        public string ClosestVisualization { get; set; }
    }
}