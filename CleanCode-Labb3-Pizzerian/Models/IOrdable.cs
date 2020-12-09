using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public interface IOrdable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
