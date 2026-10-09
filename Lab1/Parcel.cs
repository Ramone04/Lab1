using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracking;

public class Parcel
{
    
    public string TrackingCode { 
        get; 
        set; 
    }
    public string RecipientName { 
        get;
        set; 
    }
    public double Weight { get; set; }
    public ParcelStatus Status { get; set; }
    public DateTime? EstimatedDeliveryDate { get; set; }
    public DateTime? ActualDeliveryDate { get; set; }

    
    public string Summary => $"{TrackingCode} - {RecipientName} - {Weight:F2} kg";
}
