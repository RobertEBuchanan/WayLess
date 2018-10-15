using System;
using WayLess.Domain.Interfaces;

namespace Wayless.Domain
{
    public abstract class Measurement : IMeasurement
    {
        public DateTime TakenAt => throw new NotImplementedException();
    }
}
