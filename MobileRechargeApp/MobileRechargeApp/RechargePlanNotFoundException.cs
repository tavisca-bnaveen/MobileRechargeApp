using System;

namespace MobileRechargeApp
{
    internal class RechargePlanNotFoundException : Exception
    {
        public RechargePlanNotFoundException()
        {
        }

        public RechargePlanNotFoundException(string message) : base(message)
        {
        }

        public RechargePlanNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}