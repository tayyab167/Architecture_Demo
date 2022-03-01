using System;

namespace PrimeHrmsApi.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
