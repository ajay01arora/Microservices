using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aggregator
{
    public class Order
    {
        public int orderId { get; set; }

        public int UserId { get; set; }

        public int orderAmount { get; set; }

        public string orderDate { get; set; }

    }
}
