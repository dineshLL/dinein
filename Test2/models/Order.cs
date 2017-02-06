using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.models
{
    public class Order
    {
        private List<Food> items = new List<Food>();

        public int OrderId { get; set; }
        public string OrderType { get; set; }
        public string CustomerName { get; set; }
        public string OrderName { get; set; }

        public List<Food> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Order(string orderType)
        {
            this.OrderType = orderType;
        }

        
    }

}
