using System.ComponentModel.DataAnnotations;

namespace ServiceContracts.DTOs
{
    public class BuyOrderResponse
    {
        public Guid BuyOrderId { get; set; }
        public string? StockSymbol { get; set; }
        public string? StockName { get; set; }
        public DateTime DateAndTimeOfOrder { get; set; }
        public uint Quantity { get; set; }
        public double Price { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not BuyOrderResponse otherBuyOrderResponse) return false;
            return BuyOrderId == otherBuyOrderResponse.BuyOrderId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
