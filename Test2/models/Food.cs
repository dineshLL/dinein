using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public Food()
        {

        }
    }
}
