using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracking;


public enum ParcelStatus
{
    Registered,
    InTransit,
    OutForDelivery,
    Delivered,
    DeliveryFailed
}
