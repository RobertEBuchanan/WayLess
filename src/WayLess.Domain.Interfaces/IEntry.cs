using System;
using System.Collections.Generic;

namespace WayLess.Domain.Interfaces
{
    // Note 
    // Every time weight, BP, or     
    public interface IEntry
    {
        DateTime EnteredOn { get; set; }
        IPerson EnteredFor { get; set; }
        List<IMeasurement> Measurements { get; set; }
    }
}
