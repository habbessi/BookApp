﻿using BookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
        void UpdateStatus(int id, string orderStatus, string paymentStatus=null);
        void UpdatePaymentStripeId(int id, string sessionId, string paymentIntentId);


    }
}
