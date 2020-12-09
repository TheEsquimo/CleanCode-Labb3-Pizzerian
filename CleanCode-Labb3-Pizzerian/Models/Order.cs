using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class Order
    {
        public enum OrderStatus { Canceled, Active, Completed }
        
        public int ID { get; set; }
        public DateTime CreationTime { get; set; }
        public OrderStatus Status { get; set; }
        public List<IOrdable> Content { get; set; }
        public double TotalCost { get; set; }
    }
}
