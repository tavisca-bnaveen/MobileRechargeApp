using System;

namespace MobileRechargeApp
{
    public class PaymentFactory
    {
        string paymentMethod;
        RechargePlan rechargePlan;
        public PaymentFactory(RechargePlan rechargePlan, string paymentMethod)
        {
            this.paymentMethod = paymentMethod;
            this.rechargePlan = rechargePlan;
        }
        public IPaymentSource PaymentSource()
        {
            
            switch (paymentMethod)
            {
                case "UPI":
                    return new UPI(rechargePlan);
                case "Card":
                    return new Card(rechargePlan);
                default:
                    throw new NotImplementedException();


            }
        }
    }


}
