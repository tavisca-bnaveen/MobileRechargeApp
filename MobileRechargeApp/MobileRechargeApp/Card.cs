namespace MobileRechargeApp
{
    public class Card : IPaymentSource
    {
        //string cardNumber;
        //RechargePlan rechargePlan;
        double rechargeAmount;
        string rechargePlanName;
        public Card( RechargePlan rechargePlan)
        {
            //this.cardNumber = cardNumber;
            this.rechargeAmount = rechargePlan.RechargeplanAmount;
            rechargePlanName = rechargePlan.RechargeplanName;
        }
        public string MakePayment()
        {
            //throw new NotImplementedException();
            return "Mobile Recharge of " + rechargePlanName + " of amount " + rechargeAmount.ToString() + " is succesfull through Card";
        }
    }


}
