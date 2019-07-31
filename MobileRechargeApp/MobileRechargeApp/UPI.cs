namespace MobileRechargeApp
{
    public class UPI : IPaymentSource
    {
        //string UPIID;
        //RechargePlan rechargePlan;
        double rechargeAmount;
        string rechargePlanName;
        public UPI( RechargePlan rechargePlan)
        {
            //this.UPIID = UPIID;
            this.rechargeAmount = rechargePlan.RechargeplanAmount;
            rechargePlanName = rechargePlan.RechargeplanName;
        }
        public string MakePayment()
        {
            //throw new NotImplementedException();
            return "Mobile Recharge of "+ rechargePlanName +" of amount "+ rechargeAmount.ToString() + " is succesfull through UPI";
        }
    }


}
