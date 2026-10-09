using System;
using System.Collections.Generic;

namespace ParcelTracking;

class Program
{
    static void Main(string[] args)
    {
        
        List<Parcel> initialParcels = new List<Parcel>
        {
            new Parcel { TrackingCode = "PKG001", RecipientName = "Ana Silva", Weight = 2.40, Status = ParcelStatus.InTransit, EstimatedDeliveryDate = new DateTime(2026, 10, 9) },
            new Parcel { TrackingCode = "PKG002", RecipientName = "Rui Costa", Weight = 0.75, Status = ParcelStatus.Delivered, EstimatedDeliveryDate = new DateTime(2026, 10, 6), ActualDeliveryDate = new DateTime(2026, 10, 6) },
            new Parcel { TrackingCode = "PKG003", RecipientName = "Marta Lopes", Weight = 4.20, Status = ParcelStatus.Registered },
            new Parcel { TrackingCode = "PKG004", RecipientName = "Pedro Reis", Weight = 1.80, Status = ParcelStatus.OutForDelivery, EstimatedDeliveryDate = new DateTime(2026, 10, 7) },
            new Parcel { TrackingCode = "PKG005", RecipientName = "Sofia Martins", Weight = 6.10, Status = ParcelStatus.DeliveryFailed, EstimatedDeliveryDate = new DateTime(2026, 10, 5) }
        };

        var manager = new ParcelManager(initialParcels);

        
        foreach (var parcel in manager.GetParcels())
        {
            Console.WriteLine(parcel.Summary);
        }
    }
}