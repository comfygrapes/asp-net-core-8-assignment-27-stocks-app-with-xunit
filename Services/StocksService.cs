﻿using ServiceContracts;
using ServiceContracts.DTOs;

namespace Services
{
    public class StocksService : IStocksService
    {
        public Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? buyOrderRequest)
        {
            throw new NotImplementedException();
        }

        public Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? sellOrderRequest)
        {
            throw new NotImplementedException();
        }

        public Task<List<BuyOrderResponse>> GetAllBuyOrders()
        {
            throw new NotImplementedException();
        }

        public Task<List<SellOrderResponse>> GetAllSellOrders()
        {
            throw new NotImplementedException();
        }
    }
}
