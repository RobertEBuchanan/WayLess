using System;
using System.Collections.Generic;
using WayLess.Domain.Interfaces;

namespace Wayless.Domain
{
    public class Entry : IEntry
    {
        public DateTime EnteredOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPerson EnteredFor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IMeasurement> Measurements { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
