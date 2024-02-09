namespace StreamingCalculator.Models
{
    public class RoyaltyCalculatorModel
    {
        public long NumberOfStreams { get; set; }
        public decimal RoyaltyPerStream { get; set; } = 0.00437m; // Example rate
        public decimal TotalRoyalty => NumberOfStreams * RoyaltyPerStream;
    }

}
