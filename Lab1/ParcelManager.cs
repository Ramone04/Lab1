using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;

namespace ParcelTracking;

public class ParcelManager
{
    private List<Parcel> parcels;

    public ParcelManager(List<Parcel> initialParcels)
    {
        parcels = new List<Parcel>(initialParcels);
    }

    public List<Parcel> GetParcels()
    {
        return new List<Parcel>(parcels);
    }
}