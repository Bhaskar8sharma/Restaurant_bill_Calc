using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_bill
{
    public class MainCourse
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int quantity { get; set; }
        public double total
        {
            get
            {
                return Price * quantity;
            }
            set
            {
                total = value;
            }
        }
        public double tax
        {
            get
            {
                return total * 0.13;
            }
            set
            {
                tax = value;
            }
        }
    }
}