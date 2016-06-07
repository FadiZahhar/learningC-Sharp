﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class BaconDiscount : Decorator
    {
        public BaconDiscount(SandwichComponent component)
            : base(component)
        {
            _name = "Bacon Discount";
            _price = -.50m;
        }
    }
}
