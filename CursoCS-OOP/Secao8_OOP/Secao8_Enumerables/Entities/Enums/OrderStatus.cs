﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao8_Enumerables.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
