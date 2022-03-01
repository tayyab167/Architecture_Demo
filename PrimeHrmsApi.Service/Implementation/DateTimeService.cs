using PrimeHrmsApi.Service.Contract;
using System;

namespace PrimeHrmsApi.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}