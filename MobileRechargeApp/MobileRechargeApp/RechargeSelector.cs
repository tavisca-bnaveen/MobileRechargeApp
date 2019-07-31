namespace MobileRechargeApp
{
    public class RechargeSelector
    {
        AbstractRechargePlansMenu rechargePlansMenu;
        RechargePlan rechargePlan;
        public RechargeSelector(RechargePlansMenu rechargePlansMenu)
        {
            this.rechargePlansMenu = rechargePlansMenu;
        }
        public void ValidateRecharge(RechargePlan rechargePlan)
        {
            var plans = rechargePlansMenu.GetRechargePlansMenu();
            if (plans.Contains(rechargePlan))
                this.rechargePlan = rechargePlan;
            else
                throw new RechargePlanNotFoundException();
        }
        public RechargePlan GetRechargePlan()
        {
            return this.rechargePlan;
        }
    }


}
