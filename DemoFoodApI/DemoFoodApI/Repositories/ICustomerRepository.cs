﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFoodApI.Repositories
{
    interface ICustomerRepository
    {
        void AddOrder(int order);
    }
}
