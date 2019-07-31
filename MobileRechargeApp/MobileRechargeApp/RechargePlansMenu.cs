using System.Collections.Generic;

namespace MobileRechargeApp
{
    public class RechargePlansMenu:AbstractRechargePlansMenu
    {
        List<RechargePlan> _rechargePlans = new List<RechargePlan>();
        public override void AddPlan(RechargePlan rechargePlan)
        {
            if (!_rechargePlans.Contains(rechargePlan))
                _rechargePlans.Add(rechargePlan);
        }
        public override List<RechargePlan> GetRechargePlansMenu()
        {
            return _rechargePlans;
        }

    }


}
