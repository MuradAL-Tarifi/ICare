﻿using ICare.Core.ApiDTO;
using ICare.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICare.Core.IRepository
{
   public interface IOrderRepository : ICRUDRepository<Order>
    {
        IEnumerable<GetPaymentOrdersDTO.Response> GetPaymentOrders();
        IEnumerable<GetPaymentOrdersDTO.Response> SearchInByDatePaymentOrders(GetPaymentOrdersDTO.Resqust resqust);
        IEnumerable<GetSalesStatsLast5YearDTO> GetSalesStatsLast5Year();


    }
}
