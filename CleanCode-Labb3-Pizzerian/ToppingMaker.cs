using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode_Labb3_Pizzerian
{
    public class ToppingMaker
    {
        private readonly ToppingBuilder builder;

        public ToppingMaker(ToppingBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildTopping()
        {
            builder.CreateNewTopping();
            builder.SetId();
            builder.SetName();
            builder.SetCost();
        }

        public Topping GetTopping()
        {
            return builder.GetTopping();
        }
    }
}
